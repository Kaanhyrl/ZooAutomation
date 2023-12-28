using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Veteriner Sınıfı
    public  class Vet : Worker
    {
        public Vet(int id, string ad, string soyad, int yas, decimal maas): base(id, ad, soyad, yas, "Veteriner", maas) { }

        public override void Calis()
        {
            Console.WriteLine(Ad + " " + Soyad + " hayvanların sağlık kontrolünü yapıyor.");
        }

        public override void RaporVer()
        {
            Console.WriteLine(Ad + " " + Soyad + " sağlık raporunu veriyor.");
        }
        public void HayvanıIyilestir(Animal hayvan)
        {
            hayvan.SetSaglikDurumu("Sağlıklı");
            Console.WriteLine(hayvan.Ad + " adlı hayvan iyileştirildi.");
        }
    }

}

