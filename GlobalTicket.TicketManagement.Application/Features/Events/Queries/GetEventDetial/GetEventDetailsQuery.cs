using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetial
{
    public class GetEventDetailsQuery : IRequest<EventDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}
