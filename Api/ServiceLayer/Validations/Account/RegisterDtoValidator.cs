using FluentValidation;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Helpers;

namespace ServiceLayer.Validations.Account
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {

        public RegisterDtoValidator()
        {
            RuleFor(u => u.FullName).NotNull().NotEmpty().Length(5, 50)
                .Matches(@"^[^\W\d]+\s[^\W\d]+$")
                .WithMessage("Full name should contain exactly one space.");
            RuleFor(u => u.Username).NotNull().NotEmpty().Length(5, 50);
            RuleFor(u => u.Email).NotNull().NotEmpty().Length(10, 50).EmailAddress();
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(6, 12).Must(u => PasswordExtentions.HasValidPassword(u));
            RuleFor(u => u.ConfirmPassword).Equal(u => u.Password);
        }
    }
}
