using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using E = GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IAsyncRepository<E.Event> _eventRepository;        
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IAsyncRepository<E.Event> eventRepository,
            IAsyncRepository<E.Category> categoryRepository,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventRepository.GetByIdAsync(request.EventId);
            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(E.Event));
            await _eventRepository.UpdateAsync(eventToUpdate);
            
        }
    }
}
