using System.Threading.Tasks;
using ChatServer.Models;

namespace ChatServer
{
  public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}