using DAL.Dtos;
using DAL.Interface;
using MODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DAL.Data
{
    public class BookletData:IBooklet
    {
        private readonly BookletContext _context;
        private readonly IMapper _mapper;
        public BookletData(BookletContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateBooklet(BookletDTO newBooklet)
        {
            //mapper
            var myBook = _mapper.Map<Booklet>(newBooklet);
            _context.Booklets.Add(myBook);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;

        }
        public async Task<List<BookletDTO>> GetAllBooklet()
        {
            return null;
        }
        public async Task<BookletDTO> GetBookletByName(string name)
        {
            return null;
        }
    }

 
}
