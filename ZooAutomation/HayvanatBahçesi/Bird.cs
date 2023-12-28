using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    public class Bird : Animal
    {
        public Bird(int id, string ad, int yas, string saglikDurumu) : base(id, ad, "Kuş", yas, saglikDurumu) { }

        public override void Beslenme()
        {
            Console.WriteLine(Ad + " meyve, tohum ve yeşil yapraklı bitkilerle besleniyor.");
        }

        public override void HareketEtme()
        {
            Console.WriteLine(Ad + " uçuyor.");
        }

        public override void SesCikar()
        {
            Console.WriteLine(Ad + " kuş sesi çıkarıyor.");
        }
    }
}
