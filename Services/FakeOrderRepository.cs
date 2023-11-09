using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using McDonalds_API.Model;

namespace McDonalds_API;

public class FakeOrderRepository : IOrderRepository
{
    int orderId = 42;

    public Task AddItem(int orderId, int productId)
    {
        throw new NotImplementedException();
    }

    public async Task CancelOrder(int orderId)
    {
        this.orderId = Random.Shared.Next();
    }

    public async Task<int> CreateOrder(int storeId)
    {
        return orderId;
    }

    public Task DeliveryOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task FinishOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetMenu(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetOrderItems(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveItem(int orderId, int productId)
    {
        throw new NotImplementedException();
    }
}