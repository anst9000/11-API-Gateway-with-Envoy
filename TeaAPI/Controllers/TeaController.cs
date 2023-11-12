using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile",
            "Green", "White", "Oolong", "Pu-erh", "Purple",
            "Matcha", "Mate", "Herbal", "Rooibos", "Jasmine", "Masala"
        };


        [HttpGet]
        public ActionResult Get()
        {
            var random = new Random();

            return Ok(Teas[random.Next(Teas.Length)]);
        }
    }
}