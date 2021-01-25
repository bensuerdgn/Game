using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            gamerManager.Name = "Bensu";
            gamerManager.Surname = "Erdogan";
            gamerManager.TCNo = "12345678910";
            gamerManager.Birthdate = "00/00/000";

            SalesManager salesManager = new SalesManager();

            salesManager.Sale(gamerManager);



        }
    }
}
