using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Memeli Sınıfı
    public class Mammal : Animal
    {
        public Mammal(int id, string ad, int yas, string saglikDurumu) : base(id, ad, "Memeli", yas, saglikDurumu) { }

        public override void Beslenme()
        {
            Console.WriteLine(Ad + " süt içiyor, otla besleniyor.");
        }

        public override void HareketEtme()
        {
            Console.WriteLine(Ad + " koşuyor.");
        }

        public override void SesCikar()
        {
            Console.WriteLine(Ad + " memeli sesi çıkarıyor.");
        }
    }
}
