using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" kampanyası eklendi.");
            Console.WriteLine("Kampanya indirimi: % "+ campaign.Discount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası kaldırıldı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası güncellendi.");

            Console.WriteLine("Kampanya indirimi: % " + campaign.Discount);
        }
    }
}
