namespace ComeUbBalenoApp.DAL.Entities;

public class ProductImage
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int? UserId { get; set; }
    public User? User { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsUgc { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
}
