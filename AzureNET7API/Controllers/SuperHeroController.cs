using AzureNET7API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureNET7API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public SuperHeroController()
        {
            
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get() 
        {
            List<SuperHero> list = new List<SuperHero>();
            list.Add(new SuperHero { Id = 1, Name = "SpiderMan", FirstName = "Peter", LastName = "Parkar", City = "New York" });
            list.Add(new SuperHero { Id = 2, Name = "ShaktiMan", FirstName = "Mukesh", LastName = "Khanna", City = "Mumbai" });

            return Ok(list);

        }
    }
}
