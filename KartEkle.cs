// GİRİŞ KONTROLLERİNİ EKLE

using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;

public class KartEkleCLS:Metodlar
{
    public void kartEkle()
    {
        Console.Clear();
        string Newbaslik = null;
        string Newicerik;
        string alinanBuyukluk;
        string strID;
        int kisiID;
        string line = null;
        string lineSayi;
        string yanit;

        do
        {
        
        Console.Clear();
        Console.Write("Başlık giriniz                                     : ");
        Newbaslik=nullkontrol(Newbaslik);
        Console.Write("İçerik giriniz                                     : "); Newicerik=Console.ReadLine();
        Console.Write("Büyüklük seçiniz -> XS(1), S(2), M(3), L(4), XL(5) : ");
        alinanBuyukluk=Console.ReadLine();

        while (!yanitkontrol(alinanBuyukluk,"1","2","3","4","5"))
        {
            Console.Write("Lütfen sunulan seçeneklerden birini seçin      : ");
            alinanBuyukluk=Console.ReadLine();
        }

        int alinanSayi=Convert.ToInt32(alinanBuyukluk);
        Büyüklükler secilenbuyukluk = (Büyüklükler)alinanSayi;

        Console.WriteLine("-----------------------------------------------");

        TakimCLS newtakim = new TakimCLS();
        foreach (var item in newtakim.takimUyeleri)
        {
            Console.WriteLine(item);
        }
        Console.Write("Atanacak kişinin ID'sini giriniz                   : ");

        bool gecersizID = true;
        bool basarili = false;
        bool bulundu = false;
        string kisi=null;

    while (gecersizID)
    {

        do
        {
            strID=Console.ReadLine();
            basarili = int.TryParse(strID, out kisiID); // dönüşüm sağlanırsa basarili true olur
            if (!basarili)
            {
                Console.WriteLine("Lütfen bir sayı giriniz!");
            }
        } while (!basarili);

        foreach (int item in newtakim.takimUyeleri.Keys)
        {
            if (kisiID == item)
            {
                kisi=newtakim.takimUyeleri[kisiID];
                gecersizID=false;
                bulundu=true;
                break;
            }
        }

        if (!bulundu)
        {
            Console.WriteLine("Lütfen takımda var olan bir ID giriniz!");
        }
            
    }

        Console.WriteLine("ToDo(1)--In Progress(2)--Done(3)");
        Console.WriteLine("Line seçiniz                                   :");    
        lineSayi = Console.ReadLine();
        while (!yanitkontrol(lineSayi,"1","2","3"))
        {
            Console.WriteLine("Lütfen sunulan seçeneklerden birini giriniz!");
            lineSayi=Console.ReadLine();
        }
        switch (lineSayi)
        {
            case "1":
            line ="ToDo";
            break;
            case "2":
            line ="In Progress";
            break;
            case "3":
            line ="Done";
            break;
        }

        Kartlar.kartlar.Add(new kart{baslik=Newbaslik, icerik=Newicerik, büyüklük=secilenbuyukluk.ToString(), atananKisi=kisi, Line=line});
        Console.Clear();
        Console.WriteLine("Kişi başarıyla eklendi!");
        yanit = devamyaniti();

        } while (yanit=="1");

    }

}