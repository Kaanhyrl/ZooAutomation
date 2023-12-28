using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    // Yönetici Sınıfı
    public  class Manager : Worker
    {
        public Manager(int id, string ad, string soyad, int yas, decimal maas): base(id, ad, soyad, yas, "Yönetici", maas) { }

        public override void Calis()
        {
            Console.WriteLine(Ad + " " + Soyad + " hayvanat bahçesinin genel işleyişini yönetiyor ve personeli koordine ediyor.");
        }

        public override void RaporVer()
        {
            Console.WriteLine(Ad + " " + Soyad + " finansal durum, ziyaretçi sayıları ve genel operasyonlar hakkında rapor veriyor.");
        }
    }
}