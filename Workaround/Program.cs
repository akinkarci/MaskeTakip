﻿//using Entities.Concrete; (Person classı için kullanıldı)








using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {

        
        //Degiskenler();

        

        SelamVer(" Akın");
        SelamVer(" Fatih");
        SelamVer(" Mehmet");

        
        SelamVer();

        int sonuc = Topla();


        /*
        

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";
        */

        /*
        
        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);    

        */


        
        String[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        


       



       

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }


        string[] sehirler1 = new[] { "Ankara","İstanbul","İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        
        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Console.WriteLine(sehirler2[0]);

        /*
        //şimdide dağer ataması örneği verelim
        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);

        //INT,DOUBLE,FLOAT,BOOL (0 VE 1 DEMEKTİR BOOL) BUNLAR DEĞER TİPLERDİR. YANİ SADECE STACK DE ÇALIŞIRLAR. HEAPTE İŞLERİ YOKTUR.

        */
        
        Person person1 = new Person();
        person1.FirstName = "ENGİN";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;


        /*
        
        
        
        Person person1 = new Person
        {
            FirstName = "Engin"
        };

        */

        Person person2 = new Person();
        person2.FirstName = "Murat";


        

        foreach (var sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }


        
        List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
        
        
        yeniSehirler1.Add("Adana1");

        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }









        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


    }















    
    static void SelamVer(string isim = " isimsiz")
    {
        Console.WriteLine("Merhaba" + isim);
    }


    
    static int Topla(int sayi1=5, int sayi2=10) 
    {

        int sonuc = sayi1 + sayi2;

        
        Console.WriteLine("Toplam" +" "+ sonuc);

        return sonuc;
    }


    static void Degiskenler()
    {
        string mesaj = "selam dünyalı";

        double tutar = 100000;

        int sayi = 1;

        bool girisYapmisMi = false;


        

        string ad = "Akın";
        string soyad = "Karcı";
        int dogumYili = 1982;
        long tcNo = 12345678910;

        //Person person = new Person();

        Console.WriteLine(mesaj);

        Console.WriteLine(mesaj);

        Console.WriteLine(tutar * 1.18);

        Console.WriteLine(tutar * 1.18);
    }



    
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get; set;}  
        public long TcNo { get; set;}
    }







}