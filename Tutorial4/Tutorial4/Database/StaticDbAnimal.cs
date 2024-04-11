using Microsoft.AspNetCore.Http.HttpResults;
using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticDbAnimal
{

    public static List<Animal> Animals { get; set; } = new List<Animal>()
    {
        new Animal(1,"Lucky","Pies", 10, "Czarny"),
        new Animal(2,"Jhony","Kot", 7, "Brązowy") ,
        new Animal(3,"Nela","Pies", 15, "Szary") ,
        new Animal(4,"Leo","Kot", 9, "Biały") ,
        new Animal(5,"Garfild","Kot", 6, "Czarny") 
    };

    public Animal GetAnimals(int id)
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            if (Animals[i].id == id)
            {
                return Animals[i];
            }
        }

        return null;
    }
}