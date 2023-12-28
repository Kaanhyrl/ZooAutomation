using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    public static class Zoo
    {
        public static List<Animal> Hayvanlar = new List<Animal>();
        public static List<Worker> Calisanlar = new List<Worker>();

        public static void HayvanEkle(Animal hayvan)
        {
            Hayvanlar.Add(hayvan);
        }

        public static void CalisanEkle(Worker calisan)
        {
            Calisanlar.Add(calisan);
        }
    }
}

