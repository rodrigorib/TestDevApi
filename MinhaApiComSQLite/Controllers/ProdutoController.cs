using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaApiComSQLite.DTO;
using MinhaApiComSQLite.Service.Contract;

namespace MinhaApiComSQLite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProdutoDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetProdutos(int pageNumber, int pageSize)
        {
            try
            {
                List<ProdutoDTO> produtoDTO = await _produtoService.GetAllAsync(pageNumber, pageSize);

                return Ok(produtoDTO);
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
        [ProducesResponseType(typeof(ProdutoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetProdutoPorId(int id)
        {
            try
            {
                ProdutoDTO produtoDTO = await _produtoService.GetByIdAsync(id);

                return Ok(produtoDTO);
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
        public async Task<ActionResult> Insert([FromBody]ProdutoDTO produto)
        {
            try
            {
                await _produtoService.InsertAsync(produto);

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
        public async Task<ActionResult> Update([FromBody] ProdutoDTO produto)
        {
            try
            {
                await _produtoService.UpdateAsync(produto);

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
                await _produtoService.DeleteAsync(id);

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
