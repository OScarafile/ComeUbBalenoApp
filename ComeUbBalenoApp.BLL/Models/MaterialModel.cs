using ComeUbBalenoApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComeUbBalenoApp.BLL.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Type { get; set; }
        public string? Color { get; set; }
        public decimal QuantityInStock { get; set; }
        public ICollection<BillOfMaterials> BillOfMaterials { get; set; } = new List<BillOfMaterials>();
    }
}
