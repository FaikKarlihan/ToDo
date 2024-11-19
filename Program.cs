do
{

Console.Clear();
Console.WriteLine("----------ToDo uygulamasına hoşgeldiniz----------");
Console.WriteLine("-----Lütfen yapmak istediğiniz işlemi seçin-----\n");
Console.WriteLine("Board Listelemek (1)\nKart Eklemek (2)\nKart Silmek (3)\nKart Taşımak (4)\nKart Güncellemek (5)\nÇıkış (0)");
string secim=Console.ReadLine();

while (!yanitkontrol(secim,"1","2","3","4","5","0"))
{
    Console.WriteLine("Lütfen sunulan seçeneklerden birini seçin.");
    secim=Console.ReadLine();
}

if (secim=="1")
{
    Listele obj = new Listele();
    obj.listele();
}
if (secim=="2")
{
    KartEkleCLS obj = new KartEkleCLS();
    obj.kartEkle();
}
if (secim=="3")
{
    KartSilCLS obj = new KartSilCLS();
    obj.kartSil();
}
if (secim=="4")
{
    KartTasiCLS obj = new KartTasiCLS();
    obj.karttasi();
}
if (secim=="5")
{
    KartGuncelleCLS obj = new KartGuncelleCLS();
    obj.guncelle();
}
if (secim=="0")
{
    Environment.Exit(0);
}

} while (true);


static bool yanitkontrol (string girdi, params string[] args)
{
    foreach (var item in args)
    {
        if (girdi.Equals(item, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
    }
    return false;
}