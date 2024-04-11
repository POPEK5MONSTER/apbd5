using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
public class VisitsController : ControllerBase
{
    [HttpGet]
    [Route("/api/Visits/{id:int}")]
    public IActionResult GetAnimals(int id)
    { 
        var visits = StaticDbVisit.Visits;
        var visitsList = new List<Visit>();
        for (int i = 0; i < visits.Count; i++)
        {
            if (visits[i].idZwierzę == id)
            {
                visitsList.Add(visits[i]);
            }
        }
        if (visitsList.Count == 0)
        {
            return NotFound("Brak wizyt o tym id zwierzaka: " + id);
        }
        
        return Ok(visitsList);
    }
    
    [HttpPost]
    [Route("/api/Visits/{dataWizytyNew}/{idZwierzeNew:int}/{opisWizytyNew}/{cenaWizytyNew:double}")]
    public IActionResult AddAnimal(string dataWizytyNew, int idZwierzeNew, string opisWizytyNew, double cenaWizytyNew)
    {
        var visits = StaticDbVisit.Visits;
        var maxWizyt = 4;
        var count = 0;
        for (int i = 0; i <visits.Count; i++)
        {
            
            if (visits[i].dataWizyty == dataWizytyNew)
            {
                if (count < maxWizyt)
                {
                    count++;
                }
            }   
        }

        if (count > maxWizyt)
        {
            return NotFound("nie ma miejsc w tym dniu: " + dataWizytyNew);
        }
        visits.Add(new Visit(dataWizytyNew, idZwierzeNew, opisWizytyNew, cenaWizytyNew));
        return Ok("Dodano Wizyte");

    }
    
}