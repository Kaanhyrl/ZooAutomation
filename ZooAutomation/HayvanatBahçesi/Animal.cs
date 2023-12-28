using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahçesi
{
    //Hayvan Sınıfı
    public abstract class Animal
    {
        public int ID { get; private set; }
        public string Ad { get; set; }
        public string Tür { get; set; }
        public int Yas { get; set; }
        public string SaglikDurumu { get; private set; }

        protected Animal(int id, string ad, string tür, int yas, string saglikDurumu)
        {
            ID = id;
            Ad = ad;
            Tür = tür;
            Yas = yas;
            SaglikDurumu = saglikDurumu;
        }

        public abstract void Beslenme();
        public abstract void HareketEtme();
        public abstract void SesCikar();
        public void SetSaglikDurumu(string saglikDurumu)
        {
            this.SaglikDurumu = saglikDurumu;
        }
    }
}