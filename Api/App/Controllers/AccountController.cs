using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Validations.Account;

namespace App.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailService _emailService;

        public AccountController(IAccountService accountService,
            UserManager<AppUser> userManager,
            IEmailService emailService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterDto registerDto)
        {
            try
            {
                RegisterDtoValidator validator = new();

                var validationResult = validator.Validate(registerDto);

                if (!validationResult.IsValid)
                {
                    var response = new ApiResponse
                    {
                        Errors = validationResult.Errors.Select(m => m.ErrorMessage).ToList(),
                        StatusMessage = "Failed"
                    };
                    return BadRequest(response);
                }

                await _accountService.RegisterAsync(registerDto);

                var appUser = await _userManager.FindByEmailAsync(registerDto.Email);

                var token = _userManager.GenerateEmailConfirmationTokenAsync(appUser);

                var link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = appUser.Id, token }, Request.Scheme, Request.Host.ToString());

                if (link == null) throw new NullReferenceException(nameof(link));

                //burda qaldi

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse { Errors = new List<string> { ex.Message } });
            }
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            await _accountService.ConfirmEmailAsync(userId, token);

            return Redirect("http://localhost:3000/");
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginDto loginDto)
        {
            try
            {
                return Ok(await _accountService.LoginAsync(loginDto));
            }
            catch (Exception)
            {
                return BadRequest("UserName or Password wrong.");
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleDto role)
        {
            try
            {
                await _accountService.CreateRoleAsync(role);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }

        }
    }
}
