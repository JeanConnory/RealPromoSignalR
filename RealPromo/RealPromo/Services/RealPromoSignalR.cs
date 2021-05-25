using Microsoft.AspNetCore.SignalR.Client;
using RealPromo.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RealPromo.Services
{
    public class RealPromoSignalR
    {
        public RealPromoSignalR(ObservableCollection<Promocao> lista)
        {
            Task.Run(async () => { await ConfigurarSignalR(lista); });
        }

        private async Task ConfigurarSignalR(ObservableCollection<Promocao> lista)
        {
            var connection = new HubConnectionBuilder().WithUrl("https://realpromotest.azurewebsites.net/PromoHub").Build();

            connection.On<Promocao>("ReceberPromocao", (promocao) =>
            {
                Device.InvokeOnMainThreadAsync(() => {
                    lista.Add(promocao);
                });
            });

            connection.Closed += async (error) => {
                await Task.Delay(5000);
                await connection.StartAsync();
            };

            await connection.StartAsync();
        }
    }
}
