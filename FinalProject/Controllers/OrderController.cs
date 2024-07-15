using DAL.Data;
using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _orderStore;
        public OrderController(IOrder orderStore)
        {
            _orderStore=orderStore;
        }
        [HttpPost]
        public ActionResult Post([FromBody] OrderDTO neworder)
        {
            var res = _orderStore.CreateOrder(neworder);
            if (res != null)
                return Ok(res);
            return BadRequest();
        }
        [HttpGet]
        public async Task<List<OrderDTO>> Get()
        {
            List<OrderDTO> result = await _orderStore.GetAllOrders();
            return result;

        }
        [HttpDelete("{id}")]
        public void Delete([FromBody] int id)
        {
            _orderStore.DeleteOrder(id);
        }
        [HttpGet("{name}")]
        public async Task<OrderDTO> Get([FromBody] string name)
        {
            OrderDTO result = await _orderStore.GetOrderByName(name);
            return result;
        }


    }
}
