using WebApplication1.Model;

namespace WebApplication1.Service;

public interface IOrderService
{
    IEnumerable<Product> GetOrder(int id);
}