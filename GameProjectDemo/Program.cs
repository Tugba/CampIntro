using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************
            Game game1 = new Game
            {
                Id = 1,
                Name = "UBISOFT Tom Clancy's The Division 2",
                Category="Savaş",
                Price=347.0

            };
            Game game2 = new Game
            {
                Id = 2,
                Name = "EA The Sims 4 Discover University",
                Category="Simülasyon",
                Price=279.99
            };
            //****************

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Fenomen İndirimi";
            campaign1.Discount = 40;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = "Ekinoks İndirimi";
            campaign2.Discount = 23;


            //**************
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 1234578
            };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                BirthYear = 1990,
                FirstName = "TUĞBA",
                LastName = "ÜSTÜNDAĞ",
                IdentityNumber = 1234576
            };

            //*********************
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            //gamerManager.Add(new Gamer
            //{
            //    Id = 1,
            //    BirthYear = 1990,
            //    FirstName = "TUĞBA",
            //    LastName = "ÜSTÜNDAĞ",
            //    IdentityNumber = 12345
            //});

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);
            Console.WriteLine("****************************");

            //*****************
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            Console.WriteLine("***********************");


            //********************
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);

            Console.WriteLine("*****************************");

            //*********************

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer1, game1, campaign2);
            Console.WriteLine("---------------");
            orderManager.Order(gamer2, game2, campaign1);



            Console.ReadLine();
        }
    }
}
