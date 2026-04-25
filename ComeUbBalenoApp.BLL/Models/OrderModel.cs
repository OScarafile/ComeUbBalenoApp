using ComeUbBalenoApp.DAL.Entities;
using ComeUbBalenoApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComeUbBalenoApp.BLL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
