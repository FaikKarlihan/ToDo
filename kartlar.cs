public class kart
{
    public string Line {get; set;}
    public string baslik {get; set;}
    public string icerik {get; set;}
    public string atananKisi {get; set;}
    public string büyüklük {get; set;}

}

public class Kartlar
{
    public static List<kart> kartlar {get; set;} = new List<kart>()
    {
        new kart {Line="ToDo", baslik="Analiz",icerik="Son olayları analiz et",atananKisi="Faik",büyüklük=Büyüklükler.L.ToString()},
        new kart {Line="In Progress", baslik="Yemek",icerik="Akşam Yemeği Yap",atananKisi="Miray",büyüklük=Büyüklükler.XL.ToString()},
        new kart {Line="Done", baslik="Duş",icerik="Duş Al",atananKisi="Uğur",büyüklük=Büyüklükler.M.ToString()}
    };
}