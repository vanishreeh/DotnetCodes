using ProductApPApi.Model;

namespace ProductApPApi.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        List<Product> GetProducts();
    }
}
