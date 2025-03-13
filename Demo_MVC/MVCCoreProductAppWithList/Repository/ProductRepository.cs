using MVCCoreProductAppWithList.Models;

namespace MVCCoreProductAppWithList.Repository
{
    public class ProductRepository : IProductRepository
    {
        //create List 
        List<Product> products;
        //constructor
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product(){Id=1,Name="TV"}
            };
        }

        public bool AddProduct(Product product)
        {
            products.Add(product);
            return true;
        }

        public bool Delete(int id)
        {
            Product product=GetProductById(id);
           return products.Remove(product);
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var productExists = GetProductById(product.Id);
            if (productExists != null)
            {
                productExists.Id = product.Id;
                productExists.Name = product.Name;
            }
        }
    }
}
