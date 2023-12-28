using HayvanatBahçesi;
using System;
using System.Collections.Generic;

namespace HayvanatBahcesi
{
    class Program
    {
        static List<Animal> hayvanlar = new List<Animal>();
        static List<Worker> calisanlar = new List<Worker>();
        static void Main(string[] args)
        {
            

            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:\n1. Hayvan Ekle\n2. Çalışan Ekle\n3. Hayvan Çıkar\n4. Çalışan Çıkar\n5. Hayvanları ve Çalışanları Listele\n6. Görev Yap\n7. Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        HayvanEkle(hayvanlar);
                        break;
                    case 2:
                        CalisanEkle(calisanlar);
                        break;
                    case 3:
                        HayvanCikar(hayvanlar);
                        break;
                    case 4:
                        CalisanCikar(calisanlar);
                        break;
                    case 5:
                        Listele(hayvanlar, calisanlar);
                        break;
                    case 6:
                        GorevYap();
                        break;
                    case 7:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static void HayvanEkle(List<Animal> hayvanlar)
        {
            Console.WriteLine("Hayvan adını giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Hayvan yaşını giriniz:");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Hayvan türünü giriniz (Memeli, Sürüngen, Kuş):");
            string tür = Console.ReadLine();

            Animal hayvan;
            switch (tür.ToLower())
            {
                case "memeli":
                    hayvan = new Mammal(0, ad, yas, "Sağlıklı");
                    break;
                case "sürüngen":
                    hayvan = new Reptile(0, ad, yas, "Sağlıklı");
                    break;
                case "kuş":
                    hayvan = new Bird(0, ad, yas, "Sağlıklı");
                    break;
                default:
                    Console.WriteLine("Geçersiz tür.");
                    return;
            }

            hayvanlar.Add(hayvan);
            Console.WriteLine(ad + " adlı hayvan eklendi.");
        }

        static void CalisanEkle(List<Worker> calisanlar)
        {
            Console.WriteLine("Çalışanın adını giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Çalışanın yaşını giriniz:");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Çalışanın pozisyonunu giriniz (Bakıcı, Veteriner, Yönetici):");
            string pozisyon = Console.ReadLine();

            Worker calisan;
            switch (pozisyon.ToLower())
            {
                case "bakıcı":
                    calisan = new Caregiver(0, ad, "", yas, 0);
                    break;
                case "veteriner":
                    calisan = new Vet(0, ad, "", yas, 0);
                    break;
                case "yönetici":
                    calisan = new Manager(0, ad, "", yas, 0);
                    break;
                default:
                    Console.WriteLine("Geçersiz pozisyon.");
                    return;
            }

            calisanlar.Add(calisan);
            Console.WriteLine(ad + " adlı çalışan eklendi.");
        }
        static void Listele(List<Animal> hayvanlar, List<Worker> calisanlar)
        {
            Console.WriteLine("Hayvanat Bahçesindeki Hayvanlar:");
            foreach (var hayvan in hayvanlar)
            {
                Console.WriteLine("Ad: " + hayvan.Ad + ", Yaş: " + hayvan.Yas + ", Tür: " + hayvan.Tür);
            }

            Console.WriteLine("\nHayvanat Bahçesindeki Çalışanlar:");
            foreach (var calisan in calisanlar)
            {
                Console.WriteLine("Ad: " + calisan.Ad + ", Yaş: " + calisan.Yas + ", Pozisyon: " + calisan.Pozisyon);
            }
        }
        static void HayvanCikar(List<Animal> hayvanlar)
        {
            Console.WriteLine("Çıkarmak istediğiniz hayvanın adını giriniz:");
            string ad = Console.ReadLine();

            Animal silinecekHayvan = hayvanlar.Find(h => h.Ad == ad);
            if (silinecekHayvan != null)
            {
                Console.WriteLine("Bulunan Hayvan: " + silinecekHayvan.Ad);
                hayvanlar.Remove(silinecekHayvan);
                Console.WriteLine(ad + " adlı hayvan çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Hayvan bulunamadı.");
            }
        }


        static void CalisanCikar(List<Worker> calisanlar)
        {
            Console.WriteLine("Çıkarmak istediğiniz çalışanın adını giriniz:");
            string ad = Console.ReadLine();

            Worker silinecekCalisan = calisanlar.Find(c => c.Ad == ad);
            if (silinecekCalisan != null)
            {
                calisanlar.Remove(silinecekCalisan);
                Console.WriteLine(ad + " adlı çalışan çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Çalışan bulunamadı.");
            }
        }
        static void GorevYap()
        {
            if (calisanlar.Count == 0)
            {
                Console.WriteLine("Önce çalışan eklemeniz gerekmektedir.");
                return;
            }
            Console.WriteLine("Çalışanın pozisyonunu seçiniz (Bakıcı, Veteriner, Yönetici):");
            string pozisyon = Console.ReadLine();

            switch (pozisyon.ToLower())
            {
                case "bakıcı":
                    Caregiver bakici = new Caregiver(1, "Bakıcı Adı", "Bakıcı Soyadı", 30, 3000.00m);
                    Console.WriteLine("Bakıcı için hangi hayvanın alanı temizlenecek?");
                    string hayvanAdi = Console.ReadLine();
                    Animal temizlenecekHayvan = hayvanlar.FirstOrDefault(h => h.Ad == hayvanAdi);
                    if (temizlenecekHayvan != null)
                    {
                        bakici.AlanTemizle(temizlenecekHayvan);
                    }
                    else
                    {
                        Console.WriteLine("Hayvan bulunamadı.");
                    }
                    break;
                case "veteriner":
                    Vet veteriner = new Vet(1, "Veteriner Adı", "Veteriner Soyadı", 35, 4000.00m);
                    Console.WriteLine("Veterinerin kontrol edeceği hayvanın adı nedir?");
                    string kontrolEdilecekHayvanAdi = Console.ReadLine();
                    Animal kontrolEdilecekHayvan = hayvanlar.FirstOrDefault(h => h.Ad == kontrolEdilecekHayvanAdi);
                    if (kontrolEdilecekHayvan != null)
                    {
                        veteriner.HayvanıIyilestir(kontrolEdilecekHayvan);
                    }
                    else
                    {
                        Console.WriteLine("Hayvan bulunamadı.");
                    }
                    break;
                case "yönetici":
                    Manager yonetici = new Manager(3, "Yönetici Adı", "Yönetici Soyadı", 40, 5000.00m);
                    yonetici.RaporVer();
                    break;
                default:
                    Console.WriteLine("Geçersiz pozisyon.");
                    break;
            }
        }
    }
}
    

    

