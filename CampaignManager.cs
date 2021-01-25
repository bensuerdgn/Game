using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaignManager : IManager
    {
        public void Add()
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
