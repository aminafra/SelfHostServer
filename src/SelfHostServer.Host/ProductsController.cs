using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "product 1", },
            new Product { Id = 2, Name = "product 2", },
            new Product { Id = 3, Name = "product 3", },
        };
        
        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}