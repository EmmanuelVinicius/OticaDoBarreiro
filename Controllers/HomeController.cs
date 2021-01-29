using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using otica_do_barreiro.Models;

namespace otica_do_barreiro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Client> Get(String filtros)
        {
            var _client = new List<Client>();
            _client.Add(
                new Client{
                    CodigoCompra = 312,
                    CPF = "123",
                    id = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    isActive = true,
                    ModeloOculos = "Rayban",
                    Nome = "Vag",
                    ProximoContato = new DateTime().AddYears(1)
                }
            );

            return _client.ToList();

        }
    }
}
