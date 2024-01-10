using Microsoft.AspNetCore.Mvc;
using ViagensAgencia.Models;
using ViagensAgencia.Repositorios.Interfaces;

namespace ViagensAgencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagemController : ControllerBase
    {
        private readonly IViagemRepositorio _viagemRepositorio;
        public ViagemController(IViagemRepositorio viagemRepositorio)
        {
            _viagemRepositorio = viagemRepositorio;
        }

        [HttpGet]
        [Route("/GetAllViagens")]
        public async Task<ActionResult<List<ViagemModel>>> ListarTodas()
        {
            List<ViagemModel> viagens = await _viagemRepositorio.BuscarTodasViagens();
            return Ok(viagens);
        }

        [HttpGet("{id}")]
        
        public async Task<ActionResult<ViagemModel>> BuscarPorId(int id)
        {
            ViagemModel viagem = await _viagemRepositorio.BuscarPorId(id);
            return Ok(viagem);
        }

        [HttpPost]
        public async Task<ActionResult<ViagemModel>> Cadastrar(ViagemModel viagemModel)
        {
            ViagemModel viagem = await _viagemRepositorio.Adicionar(viagemModel);
            return Ok(viagem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ViagemModel>> Atualizar(int id, ViagemModel viagemModel)
        {
            viagemModel.Id = id;
            ViagemModel viagem = await _viagemRepositorio.Atualizar(viagemModel, id);
            return Ok(viagem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Apagar(int id)
        {
            bool apagado = await _viagemRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}

