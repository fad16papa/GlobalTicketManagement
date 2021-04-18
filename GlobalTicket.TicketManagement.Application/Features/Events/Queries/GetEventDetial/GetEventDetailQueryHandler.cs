using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetial
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailsQuery, EventDetailsViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;

        public GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<EventDetailsViewModel> Handle(GetEventDetailsQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailsDto = _mapper.Map<EventDetailsViewModel>(@event);

            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);

            eventDetailsDto.Category = _mapper.Map<CategoryDTO>(category);

            return eventDetailsDto;
        }
    }
}
