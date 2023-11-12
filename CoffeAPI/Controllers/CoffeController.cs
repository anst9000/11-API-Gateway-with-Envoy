using System;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Flat white", "Long black", "Latte", "Americano", "Cappuccino",
            "Red eye", "Cortado", "Doppio", "Espresso", "Black",
            "Galao", "Lungo", "Macchiato", "Mocha", "Ristretto",
            "Affogato", "Café au lait", "Irish"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var random = new Random();

            return Ok(Coffees[random.Next(Coffees.Length)]);
        }
    }
}