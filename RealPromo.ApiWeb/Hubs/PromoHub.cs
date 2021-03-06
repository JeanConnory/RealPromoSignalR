using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Hubs
{
    public class PromoHub : Hub
    {
        public async Task CadastrarPromocao(Promocao promocao)
        {
            await Clients.Caller.SendAsync("CadastradoSucesso");
            await Clients.Others.SendAsync("ReceberPromocao", promocao);
        }
    }
}
