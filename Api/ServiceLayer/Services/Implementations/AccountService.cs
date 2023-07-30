using AutoMapper;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager,
                              RoleManager<IdentityRole> roleManager,
                              ITokenService tokenService,
                              IEmailService emailService,
                              IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _emailService = emailService;
            _mapper = mapper;
        }


        public async Task<ApiResponse> RegisterAsync(RegisterDto registerDto)
        {
            var user = _mapper.Map<AppUser>(registerDto);

            if (user == null) throw new NullReferenceException();

            IdentityResult result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                return new ApiResponse
                {
                    Errors = result.Errors.Select(m => m.Description).ToList(),
                    StatusMessage = "Failed"
                };
            }

            await _userManager.AddToRoleAsync(user, "Admin");

            return new ApiResponse { Errors = null, StatusMessage = "Success" };
        }


        public async Task ConfirmEmailAsync(string userId, string token)
        {
            if (userId == null && token == null) throw new ArgumentNullException();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user == null) throw new NullReferenceException();

            await _userManager.ConfirmEmailAsync(user, token);
        }


        public async Task<string?> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password)) return null;

            var roles = await _userManager.GetRolesAsync(user);

            string token = _tokenService.GenerateJwtToken(user.Email, user.UserName, (List<string>)roles);

            return token;
        }


        public async Task CreateRoleAsync(RoleDto roleDto)
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = roleDto.RoleName });
        }


        public async Task<ApiResponse> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
        {
            var existUser = await _userManager.FindByEmailAsync(resetPasswordDto.Email);

            if (existUser == null) throw new NullReferenceException();

            if (await _userManager.CheckPasswordAsync(existUser, resetPasswordDto.NewPassword))
            {
                return new ApiResponse
                {
                    Errors = new List<string> { "Your password already exists!" },
                    StatusMessage = "Failed"
                };
            }

            await _userManager.ResetPasswordAsync(existUser, resetPasswordDto.Token, resetPasswordDto.NewPassword);

            return new ApiResponse { Errors = null, StatusMessage = "Success" };
        }
    }
}

