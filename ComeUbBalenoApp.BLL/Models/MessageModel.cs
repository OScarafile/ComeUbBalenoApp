using ComeUbBalenoApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComeUbBalenoApp.BLL.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string ConversationId { get; set; } = string.Empty;
        public int SenderId { get; set; }
        public User Sender { get; set; } = null!;
        public string Text { get; set; } = string.Empty;
        public string? AttachmentsMetadata { get; set; }
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public int? CustomizationRequestId { get; set; }
        public CustomizationRequest? CustomizationRequest { get; set; }
    }
}
