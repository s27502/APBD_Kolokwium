using WebApplication1.Model;

namespace WebApplication1.Repository;

public interface IOrderRepository
{
    IEnumerable<Product> GetOrder(int id);
}