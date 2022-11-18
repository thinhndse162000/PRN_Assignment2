using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.repo.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private SaleManagementContext _db;

        public OrderRepository()
        {
            _db = new SaleManagementContext();
        }

        public void Create(Order order)
        {
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public void Delete(int orderId)
        {
            var order = _db.Orders.SingleOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                _db.Orders.Remove(order);
                _db.SaveChanges();
            }
        }

        public Order GetOrderById(int id)
        {
            return _db.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _db.Orders.ToArray();
        }

        public IEnumerable<Order> GetOrdersByMemberId(int memberId)
        {
            return _db.Orders.Where(o => o.MemberId == memberId).ToArray();
        }

        public void Update(Order order)
        {
            if (order != null)
            {
                Order selectedOrder = _db.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
                if (selectedOrder != null)
                {
                    selectedOrder.ShippedDate = order.ShippedDate;
                    selectedOrder.RequiredDate = order.RequiredDate;
                    selectedOrder.Freight = order.Freight;
                    _db.SaveChanges();
                }
            }
        }
    }
}
