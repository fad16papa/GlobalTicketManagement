using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Domain.Common
{
    public class AuditableEntity
    {
        public string CreateBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
