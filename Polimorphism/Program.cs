using System;

namespace Program
{
    class Prog
    {
        static void Main(string[] args)
        {
            Console.Write("Yasiniz : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 65)
            {
                Console.Write("Biniş sayısı : ");
                int binis_sayisi = Convert.ToInt32(Console.ReadLine());
                Yasli yasli= new Yasli();
                Console.WriteLine("Toplam ücret : "+yasli.FiyatBul(binis_sayisi,true)+" tl");
            }
            else
            {
                Console.Write("Kart Türü (Ücretsiz, Öğrenci, Öğretmen, Mavi Kart) : ");
                string kart = Console.ReadLine();
                Console.Write("Biniş sayısı : ");
                int binis_sayisi = Convert.ToInt32(Console.ReadLine());
                if (kart == "Ücretsiz")
                {
                    Ucretsiz ucretsiz = new Ucretsiz();
                    Console.WriteLine("Toplam ücret : " + ucretsiz.FiyatBul(binis_sayisi, true) + " tl");
                }
                else if (kart == "Öğrenci")
                {
                    Console.Write("Abonman mı (Evet, Hayır) : ");
                    string abonman = Console.ReadLine();
                    Ogrenci ogrenci = new Ogrenci();
                    if (abonman == "Evet")
                    {
                        Console.WriteLine("Toplam ücret : " + ogrenci.FiyatBul(binis_sayisi, true) + " tl");
                    }
                    else
                    {
                        Console.WriteLine("Toplam ücret : " + ogrenci.FiyatBul(binis_sayisi, false) + " tl");
                    }
                }
                else if (kart == "Öğretmen")
                {
                    Console.Write("Abonman mı (Evet, Hayır) : ");
                    string abonman = Console.ReadLine();
                    Ogretmen ogretmen = new Ogretmen();
                    if (abonman == "Evet")
                    {
                        Console.WriteLine("Toplam ücret : " + ogretmen.FiyatBul(binis_sayisi, true) + " tl");
                    }
                    else
                    {
                        Console.WriteLine("Toplam ücret : " + ogretmen.FiyatBul(binis_sayisi, false) + " tl");
                    }
                }
                else if (kart == "Mavi Kart")
                {
                    Console.Write("Abonman mı (Evet, Hayır) : ");
                    string abonman = Console.ReadLine();
                    MaviKart mavi = new MaviKart();
                    if (abonman == "Evet")
                    {
                        Console.WriteLine("Toplam ücret : " + mavi.FiyatBul(binis_sayisi, true) + " tl");
                    }
                    else
                    {
                        Console.WriteLine("Toplam ücret : " + mavi.FiyatBul(binis_sayisi, false) + " tl");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş!");
                }
                
            }
        }
    }

    class MaviKart
    {
        public virtual double FiyatBul(int binis_sayisi, bool abonman)
        {
            double price = 0;
            if (abonman)
            {
                if (binis_sayisi <= 160)
                {
                    price = 400;
                }
                else
                {
                    price = (binis_sayisi - 160) * 7.5 + 400;
                }
            }
            else
            {
                price = 7.5 * binis_sayisi;
            }
            return price;
        }
    }

    class Ogretmen : MaviKart
    {
        public override double FiyatBul(int binis_sayisi, bool abonman)
        {
            double price = 0;
            if (abonman)
            {
                if (binis_sayisi <= 160)
                {
                    price=400;
                }
                else
                {
                    price = (binis_sayisi - 160) * 7 + 400;
                }
            }
            else
            {
                price = 7 * binis_sayisi;
            }
            return price;
        }
    }

    class Ogrenci : Ogretmen
    {
        public override double FiyatBul(int binis_sayisi, bool abonman)
        {
            double price = 0;
            if (abonman)
            {
                if (binis_sayisi <= 160)
                {
                    price = 90;
                }
                else
                {
                    price = (binis_sayisi - 160) * 3.75 + 90;
                }
            }
            else
            {
                price = 3.75 * binis_sayisi;
            }
            return price;
        }
    }

    class Yasli : Ogrenci
    {
        public override double FiyatBul(int binis_sayisi, bool abonman)
        {
            double price = 0;
            if (binis_sayisi <= 160)
            {
                price = 0;
            }
            else
            {
                price = (binis_sayisi - 160) * 7.5;
            }
            return price;
        }
    }

    class Ucretsiz : Yasli
    {
        public override double FiyatBul(int binis_sayisi, bool abonman=true)
        {
            double price = 0;
            if (binis_sayisi <= 160)
            {
                price = 0;
            }
            else
            {
                price = (binis_sayisi - 160) * 5;
            }
            return price;
        }
    }
}