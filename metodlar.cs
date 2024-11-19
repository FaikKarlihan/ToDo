public class Metodlar
{
    public virtual bool yanitkontrol (string girdi, params string[] args)
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

    public string cikisyaniti()
    {
            string girdi;
            Console.WriteLine("Aradığınız başlıkta kart bulunamadı");
            Console.WriteLine("Tekrar denemek için (1) Ana menüye dönmek için (2)");
            girdi = Console.ReadLine();
            while (!yanitkontrol(girdi,"1","2"))
            {
                Console.WriteLine("Lütfen verilen seçeneklerden birini seçin.");
                girdi = Console.ReadLine();
            }
            return girdi;
    }

    public string devamyaniti()
    {
        string girdi;
        Console.WriteLine("Tekrar denemek için(1) Ana menüye dönmek için(2)");
        girdi=Console.ReadLine();
        while (!yanitkontrol(girdi,"1","2"))
        {
            Console.WriteLine("Lütfen sunulan seçeneklerden birini seçin!");
            girdi=Console.ReadLine();
        }
        return girdi;
    }

    public string nullkontrol (string girdi)
    {
        do
        {
            girdi = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(girdi))
            {
                Console.WriteLine("Lütfen bir giriş yapın!");
            }

        } while (string.IsNullOrWhiteSpace(girdi));

        return girdi;
    }

}

