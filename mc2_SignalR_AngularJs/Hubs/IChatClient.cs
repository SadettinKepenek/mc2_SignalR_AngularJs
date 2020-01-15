using System.Threading.Tasks;

namespace mc2_SignalR_AngularJs.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
        Task ReceiveMessage(string message);
    }
}