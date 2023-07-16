namespace ServiceLayer.DTO_s.Account
{
    public class ResetPasswordDto
    {
        public string? newPassword { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
