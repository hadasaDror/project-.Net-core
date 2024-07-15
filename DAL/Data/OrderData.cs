using AutoMapper;
using DAL.Dtos;
using DAL.Interface;
using MODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class OrderData:IOrder
    {
        private readonly BookletContext _context;
        private readonly IMapper _mapper;
        public OrderData(BookletContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateOrder(OrderDTO order)
        {
            var myOrder = _mapper.Map<Orders>(order);
            _context.Orders.Add(myOrder);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }
        public async Task<List<OrderDTO>> GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            var myordersDto = _mapper.Map<List<OrderDTO>>(orders);
            return myordersDto;
        }
        public async void DeleteOrder(int id)
        {
            var order = _context.Booklets.Where(b => b.Id == id).FirstOrDefault();

            if (order != null)
            {
                _context.Booklets.Remove(order);
                _context.SaveChanges();
            }
        }
        public async Task<OrderDTO> GetOrderByName(string name)
        {
            var myOrder = _context.Orders.FirstOrDefault(book => book.OrderingName == name);
            var myorderDto = _mapper.Map<OrderDTO>(myOrder);
            return myorderDto;
        }




    }
}
