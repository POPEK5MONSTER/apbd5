using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
public class AnimalsController : ControllerBase
{   

    [HttpGet]
    [Route("/api/Animals")]
    public IActionResult GetAnimals()
    {
        var animals = StaticDbAnimal.Animals;
        return Ok(animals);
    }
    [HttpGet]
    [Route("/api/Animals/{id:int}")]
    public IActionResult GetAnimalId(int id)
    {
        var animals = StaticDbAnimal.Animals;
        for (int i = 0; i <animals.Count; i++)
        {
            if (animals[i].id == id)
            {
                return Ok(animals[i]);
            }   
        }
        return NotFound("Brak zwierzaka o tym id: " + id);
    }

    [HttpPost]
    [Route("/api/Animals/{idNew:int}/{imieNew}/{kategorianew}/{masaNew:double}/{kolorSierciNew}")]
    public IActionResult AddAnimal(int idNew, string imieNew, string kategorianew, double masaNew, string kolorSierciNew)
    {
        var animals = StaticDbAnimal.Animals;
        for (int i = 0; i <animals.Count; i++)
        {
            if (animals[i].id == idNew)
            {
                return NotFound("istnieje dany zwierzak o tym id: " + idNew);
            }   
        }

        animals.Add(new Animal(idNew, imieNew, kategorianew, masaNew, kolorSierciNew));
        return Ok("Dodano zwierzaka");

    }
    [HttpPut]
    [Route("/api/Animals/{idNew:int}/{imieNew}/{kategorianew}/{masaNew:double}/{kolorSierciNew}")]
    public IActionResult ChangeAnimal(int idNew, string imieNew, string kategorianew, double masaNew, string kolorSierciNew)
    {
        var animals = StaticDbAnimal.Animals;
        for (int i = 0; i <animals.Count; i++)
        {
            if (animals[i].id == idNew)
            {
                animals[i] = new Animal(idNew, imieNew, kategorianew, masaNew, kolorSierciNew);
                return NotFound("Dane zwierzaka zostały zmodyfikowane");
            }   
        }

        return Ok("Zwierzak nie istnieje o takim id: " + idNew);

    }
    
    [HttpDelete]
    [Route("/api/Animals/{idNew:int}")]
    public IActionResult DeleteAnimal(int idNew)
    {
        var animals = StaticDbAnimal.Animals;
        for (int i = 0; i <animals.Count; i++)
        {
            if (animals[i].id == idNew)
            {
                animals.Remove(animals[i]);
                return NotFound("Dane tego zmierzaka zostały usuniete");
            }   
        }

        return Ok("Zwierzak nie istnieje o takim id: " + idNew);

    }
}