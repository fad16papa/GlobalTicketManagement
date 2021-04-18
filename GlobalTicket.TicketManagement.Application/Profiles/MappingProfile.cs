using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetial;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListViewModel>().ReverseMap();
            CreateMap<Event, EventDetailsViewModel>().ReverseMap();
            CreateMap<Category, CategoryDTO>();
        }
    }
}
