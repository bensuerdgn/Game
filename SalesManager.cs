using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class SalesManager
    {
        public void Sale(GamerManager manager)
        {
            manager.Add();

        }

        public void Campaign(CampaignManager campaignManager)
        {
            campaignManager.Add();

        }
    }
}
