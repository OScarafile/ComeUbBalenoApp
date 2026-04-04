namespace ComeUbBalenoApp.DAL.Entities;

public class Material
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Type { get; set; }
    public string? Color { get; set; }
    public decimal QuantityInStock { get; set; }
    public ICollection<BillOfMaterials> BillOfMaterials { get; set; } = new List<BillOfMaterials>();
}
