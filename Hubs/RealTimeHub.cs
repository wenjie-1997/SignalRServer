using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class RealTimeHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}