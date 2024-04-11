namespace Tutorial4.Models;


public class Visit
{
    public Visit(string dataWizyty, int idZwierzę, string opisWizyty, double cenaWizyty)
    {
        this.dataWizyty = dataWizyty;
        this.idZwierzę = idZwierzę;
        this.opisWizyty = opisWizyty;
        this.cenaWizyty = cenaWizyty;
    }

    public string dataWizyty { get; set; }
    public int idZwierzę { get; set; }
    public string opisWizyty { get; set; }
    public double cenaWizyty { get; set; }
}