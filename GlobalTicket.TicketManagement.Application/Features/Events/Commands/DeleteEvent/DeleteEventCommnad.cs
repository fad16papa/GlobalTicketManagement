using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommnad : IRequest
    {
        public Guid EventId { get; set; }
    }
}
