using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Service;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    
    public IEnumerable<Product> GetOrder(int id)
    {
        return _orderRepository.GetOrder(id);
    }
}
