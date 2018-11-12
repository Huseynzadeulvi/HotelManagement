using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    class Program
    {
        static TurAgent tr = new TurAgent();
        static string loginad = "ulvi";
        static string loginparol = "111";
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Ana Menyu : \n Emr Sec: \n 1. Tur Agent \n 2. Musteri \n 3. Admin");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: login();
                        break;
                    case 2: Musteri();
                        break;
                    case 3: Console.WriteLine("3 secildi");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        break;
                }
            }

        }
        public static  void TurAgent()
        {
            
            Console.WriteLine("a. Musteri qeydiyyata al \n b. Bos otaqlari goster \n c. Musterileri bron et");
            string qeydiyyat = Console.ReadLine();
            if (qeydiyyat == "a")
            {
                if (tr.Otaq > 0)
                {
                    Console.WriteLine("Musterinin adini ve soyadini qeyd edin: ");
                    string ad = Console.ReadLine();
                    string soyad = Console.ReadLine();
                    tr.Otaq=tr.Otaq-1;
                    tr.musteriQeydiyyati(ad, soyad,loginad);
                }
                else
                {
                    Console.WriteLine("Bos otaq yoxdur");
                }

            }else if(qeydiyyat=="b")
            {
                Console.WriteLine("Bos otaqlarin sayi : "+tr.Otaq);
            }else if (qeydiyyat == "c")
            {
                Console.WriteLine("Bron edilen musteriler....." );
                for(int i = 0; i < tr.index; i++)
                {
                    Console.WriteLine("Ad: "+tr.adlar[i]);
                    Console.WriteLine("Soyad: "+tr.soyadlar[i]);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Admin: "+tr.adminler[i]);
                    Console.WriteLine("*************************");
                }
            }
            else
            {
                Console.WriteLine("Duzgun secim edin!");
            }
        }
        
        public static void Musteri()
        {
            Console.WriteLine("a.Tur agent siyahisini gor \n b. Bos otaqlari goster ");
            string secim = Console.ReadLine();
            if (secim == "a")
            {
                Console.WriteLine("Musteri sayi="+tr.index);
            }
            else if (secim == "b")
            {
                Console.WriteLine("Bos otaq sayi=" + tr.Otaq);
            }
            else
            {
                Console.WriteLine("Duzgun secim edin...");
            }

        }
        public static void login()
        {
            
            Console.WriteLine("Login: ");
            string lgad = Console.ReadLine();
            Console.WriteLine("Password: ");
            string lgparol = Console.ReadLine();
            if (lgad == loginad && lgparol == loginparol) 
            {
                TurAgent();
            }
            else
            {
                Console.WriteLine("Adiniz veya Sifreniz yalnisdir");
            }
        }
    }
}
