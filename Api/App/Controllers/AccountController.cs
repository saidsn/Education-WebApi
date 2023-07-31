using DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Validations.Account;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Web;

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

                var user = await _userManager.FindByEmailAsync(registerDto.Email);

                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token },
                    Request.Scheme, Request.Host.ToString());

                if (link == null) throw new NullReferenceException(nameof(link));

                _emailService.Register(registerDto, link);

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

            return Redirect("http://localhost:3000/Login");
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
        public async Task<IActionResult> ForgotPassword([FromForm] ForgotPasswordDto forgotPasswordDto)
        {
            try
            {
                var exsistUser = await _userManager.FindByEmailAsync(forgotPasswordDto.Email);

                if (exsistUser == null) return NotFound("User not found");

                var token = await _userManager.GeneratePasswordResetTokenAsync(exsistUser);


                var link = $"http://localhost:3000/ResetPassword?email={exsistUser.Email}&token={HttpUtility.UrlEncode(token)}";

                if (link == null) throw new NullReferenceException(nameof(link));

                _emailService.ForgotPassword(exsistUser, link, forgotPasswordDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordDto resetPasswordDto)
        {
            try
            {
                ResetPasswordValidator validator = new();

                var validationResult = validator.Validate(resetPasswordDto);

                if (!validationResult.IsValid)
                {
                    var response = new ApiResponse
                    {
                        Errors = validationResult.Errors.Select(m => m.ErrorMessage).ToList(),
                        StatusMessage = "Failed"
                    };
                    return BadRequest(response);
                }

                await _accountService.ResetPasswordAsync(resetPasswordDto);

                return Redirect("http://localhost:3000/Login");
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse { Errors = new List<string> { ex.Message } });
            }
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync();

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetUserById([Required] string id)
        {
            try
            {
                return Ok(await _accountService.GetUserByIdAsync(id));
            }
            catch (Exception)
            {
                return NotFound("User not Found");
            }
        }


        [Authorize(Roles = "Admin")]
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
