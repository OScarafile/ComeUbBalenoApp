namespace ComeUbBalenoApp.DAL.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal PricePlaceholder { get; set; }
    public string? Category { get; set; }
    public bool IsBuyable { get; set; }
    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
    public ICollection<CustomizationRequest> CustomizationRequests { get; set; } = new List<CustomizationRequest>();
    public ICollection<BillOfMaterials> BillOfMaterials { get; set; } = new List<BillOfMaterials>();
}
