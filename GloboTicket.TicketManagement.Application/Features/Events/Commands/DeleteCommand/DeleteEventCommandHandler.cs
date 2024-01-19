using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using E = GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<E.Event> _eventRepository;        
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IAsyncRepository<E.Event> eventRepository,
            IAsyncRepository<E.Category> categoryRepository,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventId);
            await _eventRepository.DeleteAsync(eventToDelete);
        }
    }
}
