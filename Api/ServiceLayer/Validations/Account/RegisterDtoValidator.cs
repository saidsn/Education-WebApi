using FluentValidation;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Helpers;

namespace ServiceLayer.Validations.Account
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(u => u.FullName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Username).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(u => u.Email).NotNull().NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(6, 12).Must(u => PasswordExtentions.HasValidPassword(u));
            RuleFor(u => u.ConfirmPassword).Equal(u => u.Password);
        }
    }
}
