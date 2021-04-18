﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryEventDto> Events { get; set; }
    }
}
