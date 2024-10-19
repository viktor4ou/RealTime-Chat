using Microsoft.AspNetCore.SignalR;

namespace RealTime_Chat.Hubs
{
    public class SignalRConnectionHub : Hub
    {
        public override Task OnConnectedAsync()    
        { 
            return Clients.All.SendAsync("ReceiveMessage", "Server", $"{Context.ConnectionId} joined the chat");
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
