using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Çalışan sınıfı
    public abstract class Worker
    {
        public int ID { get; private set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Pozisyon { get; private set; }
        public decimal Maas { get; private set; }

        protected Worker(int id, string ad, string soyad, int yas, string pozisyon, decimal maas)
        {
            ID = id;
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Pozisyon = pozisyon;
            Maas = maas;
        }

        

        public abstract void Calis();
        public abstract void RaporVer();

    }
}
