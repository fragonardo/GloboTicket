using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategiesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using E = GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<EventArgs, EventListVm>().ReverseMap();
            CreateMap<E.Event, EventDetailVm>().ReverseMap();
            CreateMap<E.Category, CategoryDto>().ReverseMap();
            CreateMap<E.Category, CreateCategoryDto>().ReverseMap();

            CreateMap<E.Category, CategoryListVm>().ReverseMap();
            CreateMap<E.Category, CategoryEventListVm>().ReverseMap();

            CreateMap<E.Event, CreateEventCommand>().ReverseMap();
            CreateMap<E.Event, UpdateEventCommand>().ReverseMap();
            CreateMap<E.Event, CategoryEventDto>().ReverseMap();
        }
    }
}
