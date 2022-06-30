using System.Threading.Tasks;
using ChatServer.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatServer.Hubs
{
  public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}