using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IManager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TCNo { get; set; }
        public string Birthdate { get; set; }

        public void Add()
        {
            Console.WriteLine("Oyuncu eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
