using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
               DateTime dt = DateTime.Now;
               Console.WriteLine(dt);

               object o1 = "x";
               object o2 ="y";
               object o3 = 4;
               object o4 = 4.3;
 
 // string ifadeler

               string str1 = string.Empty;
               str1 = "Jeena Khurram";
               string ad = "Jeena";
               string soyad = "Khurram" ;
               string tamIsim = ad + " " + soyad;

               // integer tanimlama isimleri

               int integer1 = 5;
               int integer2 = 3;
               int integer3 = integer1 + integer2        ;

               //// degisken donusumleri

               string str20 = "20" ;
               int int20 = 20;

               string yenideger = str20 + int20.ToString() ;
               Console.WriteLine(yenideger);  //2020

               int int21 = int20 + Convert.ToInt32(str20);
               Console.WriteLine(int21); //40

               int int22 = int20 + int.Parse(str20); // ciktisi 40

               //datetime

               string datetime = DateTime.Now.ToString("dd.MM.yyyy");
               Console.WriteLine(datetime);

//saat

               string Hour = DateTime.Now.ToString("HH:mm");
               Console.WriteLine(Hour);

        }
    }
}