namespace Tutorial4.Models;

public class Animal
{
    public Animal(int id, string imie, string kategoria, double masa, string kolorSierci)
    {
        this.id = id;
        this.imie = imie;
        this.kategoria = kategoria;
        this.masa = masa;
        this.kolorSiersci = kolorSierci;
    }

    public int id { get; set; }
    public string imie { get; set; }
    public string kategoria { get; set; }
    public double masa { get; set; }
    public string kolorSiersci { get; set; }    
}