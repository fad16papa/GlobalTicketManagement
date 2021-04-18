using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQuery : IRequest<List<EventListViewModel>>
    {
    }
}
