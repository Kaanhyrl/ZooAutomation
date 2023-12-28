using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Sürüngen Sınıfı
    public  class Reptile : Animal
    {
        public Reptile(int id, string ad, int yas, string saglikDurumu) : base(id, ad, "Sürüngen", yas, saglikDurumu) { }

        public override void Beslenme()
        {
            Console.WriteLine(Ad + " solucan ve sümüklü böceklerle besleniyor.");
        }

        public override void HareketEtme()
        {
            Console.WriteLine(Ad + " sürünüyor.");
        }

        public override void SesCikar()
        {
            Console.WriteLine(Ad + " sürüngen sesi çıkarıyor.");
        }
    }
}
