using ComeUbBalenoApp.DAL.Entities;
using ComeUbBalenoApp.DAL.Enums;

namespace ComeUbBalenoApp.BLL.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Client;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<CustomizationRequest> CustomizationRequests { get; set; } = new List<CustomizationRequest>();
    }
}
