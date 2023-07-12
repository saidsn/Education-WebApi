using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Validations.Account;

namespace App.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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

                return Ok(await _accountService.RegisterAsync(registerDto));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse { Errors = new List<string> { ex.Message } });
            }
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
