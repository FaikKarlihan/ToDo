class Listele
{
    public void listele()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("ToDo");
        Console.ResetColor();
        Console.WriteLine("********************");
        foreach (var item in Kartlar.kartlar)
        {
            if (item.Line=="ToDo")
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Başlık: " +item.baslik);
                Console.WriteLine("İçerik: "+ item.icerik);
                Console.WriteLine("Atanan Kişi: "+item.atananKisi);
                Console.WriteLine("Büyüklük: " +item.büyüklük);
                Console.WriteLine("--------------------");
            }
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("               In Progress");
        Console.ResetColor();
        Console.WriteLine("               ********************");
        foreach (var item in Kartlar.kartlar)
        {
            if (item.Line=="In Progress")
            {
                Console.WriteLine("               --------------------");
                Console.WriteLine("               Başlık: " +item.baslik);
                Console.WriteLine("               İçerik: "+ item.icerik);
                Console.WriteLine("               Atanan Kişi: "+item.atananKisi);
                Console.WriteLine("               Büyüklük: " +item.büyüklük);
                Console.WriteLine("               --------------------");
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                              Done");
        Console.ResetColor();
        Console.WriteLine("                              ********************");
        foreach (var item in Kartlar.kartlar)
        {
            if (item.Line=="Done")
            {
                Console.WriteLine("                              --------------------");
                Console.WriteLine("                              Başlık: " +item.baslik);
                Console.WriteLine("                              İçerik: "+ item.icerik);
                Console.WriteLine("                              Atanan Kişi: "+item.atananKisi);
                Console.WriteLine("                              Büyüklük: " +item.büyüklük);
                Console.WriteLine("                              --------------------");
            }
        }

        Console.WriteLine("Ana menüye dönmek için bir tuşa basın.");
        Console.ReadLine();
    }
   
}