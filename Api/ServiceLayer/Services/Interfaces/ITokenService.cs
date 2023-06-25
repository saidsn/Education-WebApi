namespace ServiceLayer.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(string username, string email, List<string> roles);
    }
}
