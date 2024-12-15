using WebApplication4.Controllers;
using WebApplication4.Repositories;

namespace WebApplication4.Services
{
    public class ProductService : IProductService
    {


        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }


        public void AddProduct(Product product)
        {
            _productRepo.AddProduct(product);
        }

        public List<Product> GetProducts()
        {
            return _productRepo.GetAllProducts();
        }
    }
}
