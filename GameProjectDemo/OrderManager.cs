using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.Price - (game.Price * (campaign.Discount / 100));
            Console.WriteLine(game.Name+ " oyun "+ gamer.FirstName +" kişine satıldı.");
            Console.WriteLine("Oyunun indirimli fiyatı : "+newPrice+ "TL");
            Console.WriteLine("Uygulanan İndirim: " +game.Price*(campaign.Discount/100)+ "TL");
        
        
        }
    }
}
