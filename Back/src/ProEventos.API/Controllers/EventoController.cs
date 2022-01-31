using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
        }

        [HttpGet]
        public Evento Get()
        {
            return new Evento(){
                EventoId = 1,
                DataEvento = DateTime.Today.ToString(),
                ImagemURL = "Teste",
                Local = "12",
                Lote = "Lote",
                QtdPessoas = 7,
                Tema = "Folia"
            };
        }
    }
}
