using System.Security.Claims;
using System.Threading.Tasks;
using mc2_SignalR_AngularJs.Models;
using Microsoft.AspNetCore.SignalR;

namespace mc2_SignalR_AngularJs.Hubs
{
    
    public class ChatHub:Hub
    {
        public async Task SendMessage(Message message)
        {
            string uniqueId = Context.ConnectionId;
            string nameIdentifier = Context.UserIdentifier;
            ClaimsPrincipal userClaimsPrincipal = Context.User;
            var items = Context.Items;
            
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task GetActiveUsers()
        {
          
            await Clients.Caller.SendAsync("ReceiveUsers", Clients.Others);
        }
    }
}