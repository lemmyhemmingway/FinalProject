using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("getall")]
    public IActionResult Get()
    {
        var result = _productService.GetAll();
        if (result.Success)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Message);
    }

    [HttpPost("add")]
    public IActionResult Post(Product product)
    {
        var result = _productService.Add(product);
        if (result.Success)
        {
            return Ok();
        }

        return BadRequest(result.Message);
    }
    
    [HttpGet("getbyid")]
    public IActionResult Get(int id)
    {
        var result = _productService.GetById(id);
        if (result.Success)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Message);
    }
}