using FluentValidation;

namespace CleanArchitecture.Application.UseCases.CreateUser;

public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        RuleFor(user => user.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(user => user.Email).NotEmpty().MaximumLength(50).EmailAddress();
    }
}
