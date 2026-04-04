using ComeUbBalenoApp.DAL.Entities;

namespace ComeUbBalenoApp.BLL.Interfaces;

public interface IMessagingService
{
    Task<Message> SendMessageAsync(Message message, CancellationToken cancellationToken = default);
    Task<IEnumerable<Message>> GetConversationAsync(string conversationId, CancellationToken cancellationToken = default);
}
