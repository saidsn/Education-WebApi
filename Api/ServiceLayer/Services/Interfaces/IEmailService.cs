using DomainLayer.Entities;
using ServiceLayer.DTO_s.Account;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmailService
    {
        //Task ConfirmEmail(string userId, string token);
        public void Register(RegisterDto registerDto, string link);
        public void ForgotPassword(AppUser user, string link, ForgotPasswordDto forgotPasswordDto);
    }
}
