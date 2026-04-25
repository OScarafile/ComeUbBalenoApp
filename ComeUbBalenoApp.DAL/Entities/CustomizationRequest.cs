using ComeUbBalenoApp.DAL.Enums;

namespace ComeUbBalenoApp.DAL.Entities;

public class CustomizationRequest
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public CustomizationStatus Status { get; set; } = CustomizationStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Message> Messages { get; set; } = new List<Message>();
}
