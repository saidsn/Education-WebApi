using FluentValidation;
using ServiceLayer.DTO_s.Contact;

namespace ServiceLayer.Validations.Contact
{
    public class ContactUpdateDtoValidator : AbstractValidator<ContactUpdateDto>
    {
        public ContactUpdateDtoValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(c => c.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(c => c.Message).NotNull().NotEmpty().MaximumLength(524288);
        }
    }
}
