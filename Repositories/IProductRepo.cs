using WebApplication4.Controllers;

namespace WebApplication4.Repositories
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
    }
}