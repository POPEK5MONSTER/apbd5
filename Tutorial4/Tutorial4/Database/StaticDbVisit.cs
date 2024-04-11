using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticDbVisit
{
    public static  List<Visit> Visits { get; set; } = new List<Visit>()
    {
        new Visit("01-01-2024", 2, "Kontrola", 50),
        new Visit("01-02-2024", 2, "Szepienie", 100),
        new Visit("01-03-2024", 4, "Badanie kardiologiczne", 80),
        new Visit("03-02-2024", 1, "Badanie moczu", 60),
        new Visit("07-01-2024", 1, "Kontrola", 50)
    };
    
    

}