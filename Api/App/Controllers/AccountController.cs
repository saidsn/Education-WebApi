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
        public async Task<ApiResponse> Register([FromForm] RegisterDto registerDto)
        {
            try
            {
                RegisterDtoValidator validator = new();

                var validationResult = validator.Validate(registerDto);

                if (!validationResult.IsValid)
                {
                    return new ApiResponse
                    {
                        Errors = validationResult.Errors.Select(m => m.ErrorMessage).ToList(),
                        StatusMessage = "Faild"
                    };
                }

                return await _accountService.RegisterAsync(registerDto);
            }
            catch (Exception ex)
            {
                return new ApiResponse { Errors = new List<string> { ex.Message } };
            }
        }
    }
}
