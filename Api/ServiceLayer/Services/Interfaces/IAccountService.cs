using ServiceLayer.DTO_s.Account;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task<ApiResponse> RegisterAsync(RegisterDto registerDto);
        Task<string?> LoginAsync(LoginDto loginDto);
        Task CreateRoleAsync(RoleDto roleDto);
    }
}
