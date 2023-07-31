namespace ServiceLayer.DTO_s.Account
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<string>? RoleNames { get; set; }
        public bool? SoftDeleted { get; set; }
    }
}
