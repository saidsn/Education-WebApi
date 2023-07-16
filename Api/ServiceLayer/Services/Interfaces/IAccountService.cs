using ServiceLayer.DTO_s.Account;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task<ApiResponse> RegisterAsync(RegisterDto registerDto);
        Task ConfirmEmailAsync(string userId, string token);
        Task<string?> LoginAsync(LoginDto loginDto);
        Task ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
        Task CreateRoleAsync(RoleDto roleDto);
    }
}
