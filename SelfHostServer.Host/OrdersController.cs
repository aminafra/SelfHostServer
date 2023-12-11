using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "order 1", Category = "test category1", Price = 1 },
            new Order { Id = 2, Name = "order 2", Category = "test category2", Price = 20 },
            new Order { Id = 3, Name = "order 3", Category = "test category3", Price = 300 },
            new Order { Id = 4, Name = "order 4", Category = "test category4", Price = 4000 },
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}
