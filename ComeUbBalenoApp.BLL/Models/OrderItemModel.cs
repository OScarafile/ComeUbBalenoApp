using ComeUbBalenoApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComeUbBalenoApp.BLL.Models
{
    public class OrderItemModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
