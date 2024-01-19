using FluentValidation;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        //private readonly ICategoryRepository _categoryRepository;
        
        public CreateCategoryCommandValidator() 
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }

        //private async Task<bool> CategoryNameUnique(CreateCategoryCommand e, CancellationToken token)
        //{
        //    //return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
        //}
    }
}
