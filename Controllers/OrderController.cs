using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Models;
using UnitOfShop.Repositories;

namespace UnitOfShop.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController: ControllerBase
    {
        public Order Post(
            [FromServices]ICustomerRepository customerRepository,
            [FromServices]IOrderRepository orderRepository
        ) {
            try
            {
                var customer = new Customer{ Name="Daniel"};
                var order = new Order{ Number="123", Customer = customer};

                customerRepository.Save(customer);
                orderRepository.Save(order);

                return order;
            }
            catch
            {
                return null;
            }
        }
    }
}