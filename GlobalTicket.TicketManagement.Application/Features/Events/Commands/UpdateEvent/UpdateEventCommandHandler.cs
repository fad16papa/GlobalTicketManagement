using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventReposirtory;

        public UpdateEventCommandHandler(IMapper mapper, IAsyncRepository<Event> eventReposirtory)
        {
            _mapper = mapper;
            _eventReposirtory = eventReposirtory;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventReposirtory.GetByIdAsync(request.EventId);

            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event));

            await _eventReposirtory.UpdateAsync(eventToUpdate);

            return Unit.Value;
        }
    }
}
