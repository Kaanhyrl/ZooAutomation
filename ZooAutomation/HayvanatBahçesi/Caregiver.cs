using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Bakıcı sınıfı
    public  class Caregiver : Worker
    {
        public Caregiver(int id, string ad, string soyad, int yas, decimal maas): base(id, ad, soyad, yas, "Bakıcı", maas) { }

        public override void Calis()
        {
            Console.WriteLine(Ad + " " + Soyad + " hayvanları besliyor.");
        }
        public override void RaporVer()
        {
            Console.WriteLine(Ad + " " + Soyad + " bakım raporunu veriyor.");
        }
        public void AlanTemizle(Animal hayvan)
        {
            Console.WriteLine(hayvan.Ad + " adlı hayvanın alanı temizlendi.");
        }
    }
}
