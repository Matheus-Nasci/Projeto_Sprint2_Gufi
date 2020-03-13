using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using Senai.Gufi.WebApi.DatabaseFirst.Interfaces;
using Senai.Gufi.WebApi.DatabaseFirst.Repositories;

namespace Senai.Gufi.WebApi.DatabaseFirst.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class PresencaController : ControllerBase
    {
        private IPresencaRepository _presencaRepository;

        public PresencaController()
        {
            _presencaRepository = new PresencaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_presencaRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_presencaRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Presenca novaPresenca)
        {
            _presencaRepository.Cadastrar(novaPresenca);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Presenca presencaAtualizada)
        {
            Presenca presencaBuscada = _presencaRepository.BuscarPorId(id);

            if (presencaBuscada != null)
            {
                try
                {
                    _presencaRepository.Atualizar(id, presencaAtualizada);

                    return StatusCode(200);
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return StatusCode(404);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Presenca presencaBuscada = _presencaRepository.BuscarPorId(id);

            if (presencaBuscada == null)
            {
                return NotFound();
            }

            _presencaRepository.Deletar(id);

            return StatusCode(202);
        }
    }
}