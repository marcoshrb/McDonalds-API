using System.Collections.Generic;
using System.Threading.Tasks;
using McDonalds_API.Model;

namespace McDonalds_API;
  

public interface IOrderRepository
{
    Task<int> CreateOrder(int storeId);
    Task CancelOrder(int orderId);
    Task<List<Product>> GetMenu(int orderId);
    Task<List<Product>> GetOrderItems(int orderId);
    Task AddItem(int orderId, int productId);
    Task RemoveItem(int orderId, int productId);
    Task FinishOrder(int orderId);
    Task DeliveryOrder(int orderId);
}