using DomainLayer.Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IFileService _fileService;

        public EmailService(UserManager<AppUser> userManager,
            IConfiguration config,
            IFileService fileService)
        {
            _userManager = userManager;
            _configuration = config;
            _fileService = fileService;
        }


        public async Task ConfirmEmail(string userId, string token)
        {
            if (userId == null && token == null) throw new ArgumentNullException();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user == null) throw new NullReferenceException();

            await _userManager.ConfirmEmailAsync(user, token);
        }


        public void Register(RegisterDto registerDto, string link)
        {
            // create message
            var message = new MimeMessage();

            message.From.Add(MailboxAddress.Parse(_configuration.GetSection("Smtp:FromAddress").Value));

            message.To.Add(MailboxAddress.Parse(registerDto.Email));

            message.Subject = "Verify Email";

            string emailBody = string.Empty;
            string path = "wwwroot/templates/verify.html";

            emailBody = _fileService.ReadFile(path, emailBody);

            emailBody = emailBody.Replace("{{link}}", link).Replace("{{FullName}}", registerDto.FullName);

            message.Body = new TextPart(TextFormat.Html) { Text = emailBody };


            // send email
            using var smtp = new SmtpClient();

            smtp.Connect(_configuration.GetSection("Smtp:Server").Value, int.Parse(_configuration.GetSection("Smtp:Port").Value), SecureSocketOptions.StartTls);

            smtp.Authenticate(_configuration.GetSection("Smtp:FromAddress").Value, _configuration.GetSection("Smtp:Password").Value);

            smtp.Send(message);

            smtp.Disconnect(true);
        }
    }
}
