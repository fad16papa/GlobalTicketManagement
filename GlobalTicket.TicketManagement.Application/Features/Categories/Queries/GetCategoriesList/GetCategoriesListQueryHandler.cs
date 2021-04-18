using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Category> _categoruRepository;

        public GetCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<Category> categoruRepository)
        {
            _mapper = mapper;
            _categoruRepository = categoruRepository;
        }

        public async Task<List<CategoryListViewModel>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoruRepository.ListAllAsync()).OrderBy(x => x.Name);

            return _mapper.Map<List<CategoryListViewModel>>(allCategories);
        }
    }
}
