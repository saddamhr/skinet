using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "This'll be list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "It'll be a product";
        }
    }
}