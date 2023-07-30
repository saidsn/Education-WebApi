using FluentValidation;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Helpers;

namespace ServiceLayer.Validations.Account
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordDto>
    {
        public ResetPasswordValidator()
        {
            RuleFor(u => u.NewPassword).NotNull().NotEmpty().Length(6, 12).Must(u => PasswordExtentions.HasValidPassword(u));
        }
    }
}
