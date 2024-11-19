using System.Collections.Generic;


public class TakimCLS
{
    public Dictionary<int, string> takimUyeleri{get; set;}

    public TakimCLS()
    {
        takimUyeleri = new Dictionary<int, string>();
        
        takimUyeleri[1] = "Faik";
        takimUyeleri[2] = "Uğur";
        takimUyeleri[3] = "Miray";
        takimUyeleri[4] = "Tuncay";
        takimUyeleri[5] = "Gamze";
    }
}
