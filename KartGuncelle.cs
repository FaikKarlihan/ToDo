class KartGuncelleCLS:Metodlar
{
    public void guncelle()
    {
        string devamYanit="1";
        string alinanbaslik = null;

        string guncelbaslik;
        string guncelicerik;
        string guncelatanankisi=null;
        string guncelbuyukluk;
        bool kartbulundu=false;
        string alinanEnum;

        do
        {
            TakimCLS newtakim = new TakimCLS();
            Console.Clear();

            Console.WriteLine("Mevcut başlıklar;");
            foreach (var kart in Kartlar.kartlar)
            {
                Console.WriteLine(kart.baslik);
            }

            Console.WriteLine("\nLütfen güncellemek istediğiniz kartın başlığını giriniz.");
            alinanbaslik = nullkontrol(alinanbaslik);

            foreach (var kart in Kartlar.kartlar)
            {
                if (kart.baslik.Equals(alinanbaslik, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Lütfen güncel başlığı giriniz: "); guncelbaslik = Console.ReadLine();
                    kart.baslik=guncelbaslik;
                    Console.Write("Lütfen güncel içeriği giriniz: "); guncelicerik = Console.ReadLine();
                    kart.icerik=guncelicerik;

                    foreach (var kisiler in newtakim.takimUyeleri)
                    {
                        Console.WriteLine(kisiler);
                    }
                    Console.Write("Lütfen atanacak kişinin ID'sini giriniz: ");

                    bool gecersizID = true;
                    bool basarili = false;
                    bool bulundu = false;
                    string strID;
                    int kisiID;

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
                                guncelatanankisi=newtakim.takimUyeleri[kisiID];
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
                    kart.atananKisi=guncelatanankisi;


                    Console.Write("Lütfen güncel büyüklüğü -> XS(1), S(2), M(3), L(4), XL(5) : ");
                    alinanEnum=Console.ReadLine();

                    while (!yanitkontrol(alinanEnum,"1","2","3","4","5"))
                    {
                        Console.Write("Lütfen sunulan seçeneklerden birini seçin      : ");
                        alinanEnum=Console.ReadLine();
                    }
                    int enumm = Convert.ToInt32(alinanEnum);
                    Büyüklükler secilenEnum = (Büyüklükler)enumm;

                    kart.büyüklük=secilenEnum.ToString();

                    Console.WriteLine("Kart başarıyla güncellendi!\n");
                    devamYanit = devamyaniti();
                    kartbulundu = true;
                    break;
                }
            }

        if(!kartbulundu)
        {
            devamYanit = cikisyaniti();
        }
            
        } while (devamYanit=="1");
    } 
}