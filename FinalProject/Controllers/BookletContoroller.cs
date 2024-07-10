using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
