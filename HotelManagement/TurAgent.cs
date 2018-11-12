using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    class TurAgent
    {
        public int Otaq = 10;
        public string[] adlar= new string[9]; 
        public string[] soyadlar=new string[9];
        public string[] adminler = new string[9];
        public int index = 0;
        public void  musteriQeydiyyati(string ad, string soyad,string admin)
        {
            
            Console.WriteLine(""+ad+" "+soyad+" adli musteri qeydiyyata alindi");
            Console.WriteLine("Bos otaq sayi="+Otaq);

            adlar[index] = ad;
            soyadlar[index] = soyad;
            adminler[index] = admin;
            index++;        
        }

    }
}
