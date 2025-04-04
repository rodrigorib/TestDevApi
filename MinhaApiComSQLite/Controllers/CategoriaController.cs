using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaApiComSQLite.DTO;
using MinhaApiComSQLite.Repository.Contract;
using MinhaApiComSQLite.Service.Contract;

namespace MinhaApiComSQLite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CategoriaDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetCategorias()
        {
            try
            {
                List<CategoriaDTO> categoriaDTO = await _categoriaService.GetAllAsync();

                return Ok(categoriaDTO);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: Erro inesperado.");
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(CategoriaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetProdutosPorId(int id)
        {
            try
            {
                CategoriaDTO categoriaDTO = await _categoriaService.GetByIdAsync(id);

                return Ok(categoriaDTO);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: Erro inesperado.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Insert([FromBody]CategoriaDTO categoria)
        {
            try
            {
                await _categoriaService.InsertAsync(categoria);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: Erro inesperado.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update([FromBody] CategoriaDTO categoria)
        {
            try
            {
                await _categoriaService.UpdateAsync(categoria);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: Erro inesperado.");
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _categoriaService.DeleteAsync(id);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: Erro inesperado.");
            }
        }
    }
}
