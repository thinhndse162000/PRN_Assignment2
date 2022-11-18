using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.repo.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();

        IEnumerable<Order> GetOrdersByMemberId(int memberId);

        Order GetOrderById(int id);

        void Delete(int orderId);

        void Create(Order order);
        
        void Update(Order order);
    }
}
