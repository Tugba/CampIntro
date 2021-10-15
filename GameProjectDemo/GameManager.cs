using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(
                game.Name + " adlı oyun eklendi.\n" + "Fiyatı: " + 
                game.Price + "\nKategori: " +
                game.Category);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun kaldırıldı.");
        }

        public void UPdate(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi.");
        }
    }
}
