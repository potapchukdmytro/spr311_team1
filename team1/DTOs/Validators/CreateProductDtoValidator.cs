using FluentValidation;
using team1.DTOs;

public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
{
    public CreateProductDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
    }
}
