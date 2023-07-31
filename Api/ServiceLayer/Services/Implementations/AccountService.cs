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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager,
                              SignInManager<AppUser> signInManager,
                              RoleManager<IdentityRole> roleManager,
                              ITokenService tokenService,
                              IMapper mapper)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _mapper = mapper;
            _signInManager = signInManager;
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

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<UserDto> GetUserByIdAsync(string id)
        {
            if (id == null) throw new ArgumentNullException("id");

            var exsistUser = await _userManager.FindByIdAsync(id);

            if (exsistUser == null) throw new NullReferenceException();

            IList<string> userRoles = await _userManager.GetRolesAsync(exsistUser);

            var mappedData = _mapper.Map<UserDto>(exsistUser);

            List<string> roleNames = new();

            foreach (var role in userRoles)
            {
                roleNames.Add(role);
            }

            mappedData.RoleNames = roleNames;

            return mappedData;
        }
    }
}

