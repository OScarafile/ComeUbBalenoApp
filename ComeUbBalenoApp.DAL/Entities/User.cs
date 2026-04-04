namespace ComeUbBalenoApp.DAL.Entities;

public enum UserRole
{
    Client = 0,
    Staff = 1,
    Admin = 2
}

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Client;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<CustomizationRequest> CustomizationRequests { get; set; } = new List<CustomizationRequest>();
}
