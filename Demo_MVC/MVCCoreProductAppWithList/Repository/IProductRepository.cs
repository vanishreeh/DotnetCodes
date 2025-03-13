using MVCCoreProductAppWithList.Models;

namespace MVCCoreProductAppWithList.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        bool AddProduct(Product product);
        Product GetProductById(int id);
        bool Delete(int id);
        void UpdateProduct(Product product);
    }
}
