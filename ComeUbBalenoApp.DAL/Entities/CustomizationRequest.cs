namespace ComeUbBalenoApp.DAL.Entities;

public enum CustomizationStatus
{
    Pending = 0,
    InReview = 1,
    Approved = 2,
    Rejected = 3,
    Completed = 4
}

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
