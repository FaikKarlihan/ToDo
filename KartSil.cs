using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

class KartSilCLS:Metodlar
{
    string secim;
    string silBaslik;
    public void kartSil()
    {
        
        do
        {
            Console.Clear();
            bool bulundu = false;
    
            Console.WriteLine("Mevcut başlıklar;");
            foreach (var kart in Kartlar.kartlar)
            {
                Console.WriteLine(kart.baslik);
            }
            Console.WriteLine("\nLütfen Silmek İstediğiniz Kartın Başlığını Yazınız:");
            silBaslik = nullkontrol(silBaslik);


            foreach (var kart in Kartlar.kartlar)
            {
                if (kart.baslik.Equals(silBaslik, StringComparison.OrdinalIgnoreCase))
                {
                    Kartlar.kartlar.Remove(kart);
                    Console.Clear();
                    Console.WriteLine($"{kart.baslik} başlıklı kart başarıyla silindi");
                    secim = devamyaniti();
                    bulundu=true;
                    break;
                }
                
            }
                if(!bulundu)
                {
                    secim = cikisyaniti();
                }

        } while (secim == "1");


    }
}