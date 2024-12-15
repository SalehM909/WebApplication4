using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [AllowAnonymous]
        [HttpPost]
        public void AddProduct([FromBody] Product product) 
        {
           _productService.AddProduct(product); 
        }


        [HttpGet]
        public IActionResult GetAllProducts() 
        {
            List<Product> products = new List<Product>();
            try
            {
                 products = _productService.GetProducts();
            }
            
            catch (Exception ex) 
            {
              return BadRequest(ex.Message);    
            }

            return Ok(products);    
        
        }


    }
}
