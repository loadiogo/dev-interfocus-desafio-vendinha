using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateApi.Models;

namespace TemplateApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DividaController : ControllerBase
    {
        public static List<Divida> ListaDividas = new List<Divida>();

        public IActionResult Get()
        {
            throw new NotImplementedException("Escrever a implementação do GET");
        }


        public IActionResult Post([FromBody] Divida divida)
        {
            throw new NotImplementedException("Escrever a implementação do POST");
        }


        public IActionResult Put([FromBody] Divida divida)
        {
            throw new NotImplementedException("Escrever a implementação do PUT");
        }


        public IActionResult Delete(int id)
        {
            throw new NotImplementedException("Escrever a implementação do DELETE");
        }
    }
}
