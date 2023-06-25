namespace ServiceLayer.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(string email, string username, List<string> roles);
    }
}
