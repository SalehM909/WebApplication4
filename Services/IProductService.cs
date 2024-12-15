using WebApplication4.Controllers;

namespace WebApplication4.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }
}