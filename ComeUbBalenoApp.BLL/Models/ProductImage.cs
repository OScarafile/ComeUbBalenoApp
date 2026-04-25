using ComeUbBalenoApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComeUbBalenoApp.BLL.Models
{
    public class ProductImageModel
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
}
