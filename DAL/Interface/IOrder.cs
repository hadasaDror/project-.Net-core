using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IOrder
    {
        Task<bool> CreateOrder(OrderDTO order);
        Task<List<OrderDTO>> GetAllOrders();
        public void DeleteOrder(int id);
        Task<OrderDTO> GetOrderByName(string name);
    }
}
