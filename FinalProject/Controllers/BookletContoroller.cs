using DAL.Data;
using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookletContoroller : ControllerBase
    {
        private readonly IBooklet _bookStore;
        public BookletContoroller(IBooklet bookStore)
        {
            _bookStore=bookStore;
        }

        [HttpPost]
        public ActionResult Post([FromBody] BookletDTO newBook)
        {
            var res = _bookStore.CreateBooklet(newBook);
            if (res != null)
                return Ok(res);
            return BadRequest();
        }
        [HttpGet]
        public List<BookletDTO> Get()
        {
            List<BookletDTO> result = _bookStore.GetAllBooklets();
            return result;

        }
        //[HttpGet("{name}")]
        //public Task<Booklet> Get(string name)
        //{
        //    return _bookStore.GetBookletByName(name);
        //}
        [HttpGet("{name}")]
        public async Task<BookletDTO> Get([FromBody] string name)
        {
            BookletDTO result = await _bookStore.GetBookletByName(name);
            return result;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] double price)
        {
            _bookStore.UpdatePrice(price, id);
            return Ok();

        }
        [HttpDelete("{id}")]
        public void Delete([FromBody] int id)
        {
            _bookStore.DeleteBooklet(id);
        }


    }
}
