using Microsoft.AspNetCore.SignalR;

namespace RealTime_Chat.Hubs
{
    public class SignalRConnectionHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
