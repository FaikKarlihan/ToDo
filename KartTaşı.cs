class KartTasiCLS:Metodlar
{
    public void karttasi()
    {
        string secim = null;
        string alinanbaslik = null;
        string tasinacak;

        do
        {
            
            Console.Clear();
            bool bulundu = false;

            Console.WriteLine("Mevcut başlıklar;");
            foreach (var kart in Kartlar.kartlar)
            {
                Console.WriteLine(kart.baslik);
            }

            Console.WriteLine("\nLütfen taşımak istediğiniz kartın başlığını yazınız.");
            alinanbaslik = nullkontrol(alinanbaslik);

            foreach (var kart in Kartlar.kartlar)
            {
                if (kart.baslik.Equals(alinanbaslik, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    
                    Console.WriteLine("Bulunan kart bilgileri\n");
                    Console.WriteLine($"Kart başlığı: {kart.baslik}");
                    Console.WriteLine($"Kart içeriği: {kart.icerik}");
                    Console.WriteLine($"Atanan kişi: {kart.atananKisi}");
                    Console.WriteLine($"Büyüklük: {kart.büyüklük}");
                    Console.WriteLine($"Line: {kart.Line}");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("ToDo(1) In Progress(2) Done(3)");  
                    tasinacak = Console.ReadLine();

                    while (!yanitkontrol(tasinacak,"1","2","3"))
                    {
                        Console.WriteLine("Lütfen sunulan seçeneklerden birini seçin.");
                        tasinacak = Console.ReadLine();
                    }

                    switch (tasinacak)
                    {
                        case "1":
                        kart.Line="ToDo";
                        break;
                        case "2":
                        kart.Line="In Progress";
                        break;
                        case "3":
                        kart.Line="Done";
                        break;
                        
                    }

                    Console.Clear();
                    Console.WriteLine($"{kart.baslik} başlıklı kart başarıyla taşındı");
                    secim = devamyaniti();
                    bulundu=true;
                    break;
                }
            }
            
            if (!bulundu)
            {
                secim = cikisyaniti();
            }
            
        } while (secim=="1");

    }
}