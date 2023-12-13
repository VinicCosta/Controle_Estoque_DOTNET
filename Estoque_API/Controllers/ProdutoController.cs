using Estoque_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Estoque_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    /// <summary>
    /// Busca todos os produtos
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> BuscarTodosOsProdutos()
    {
        return Ok(new Produto { });
    }

    /// <summary>
    /// Busca o produto por id unico
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}", Name = "Get")]
    public string BuscarProdutorPorId(int id)
    {
        return "value";
    }

    /// <summary>
    /// Cadastra um novo produto
    /// </summary>
    /// <param name="produto"></param>
    [HttpPost]
    public void CadastrarProduto([FromBody] Produto produto)
    {
    }

    /// <summary>
    /// Atualiza as informações do produto.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="produto"></param>
    [HttpPut("{id}")]
    public void AlterarProduto(int id, [FromBody] Produto produto)
    {
    }

    /// <summary>
    /// Retira o produto do estoque em caso de venda.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="produto"></param>
    [HttpPut("RetirarProduto/{id}")]
    public void RetirarProduto(int id, [FromBody] Produto produto)
    {
    }
}