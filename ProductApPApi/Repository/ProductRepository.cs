using ProductApPApi.Model;

namespace ProductApPApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        //create a list
        List<Product> products;
        //constructor
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product(){Id=1,Name="Product1",Price=1560.65M},
                 new Product(){Id=2,Name="Product2",Price=1460.65M},
                  new Product(){Id=3,Name="Product3",Price=1360.65M}
            };
        }

        public bool AddProduct(Product product)
        {
            products.Add(product);
            return true;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
