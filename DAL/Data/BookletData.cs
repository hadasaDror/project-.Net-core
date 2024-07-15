using DAL.Dtos;
using DAL.Interface;
using MODELS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class BookletData : IBooklet
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
        public List<BookletDTO> GetAllBooklets()
        {
            var mybooklets = _context.Booklets.ToList();
            var mybookletsDto = _mapper.Map<List<BookletDTO>>(mybooklets);
            return mybookletsDto;
        }

        public async Task<BookletDTO> GetBookletByName(string name)
        {
            var myBooklet = _context.Booklets.FirstOrDefault(book => book.Name == name);
            var mybookletDto = _mapper.Map<BookletDTO>(myBooklet);
            return mybookletDto;
        }
        public void UpdatePrice(double price, int id)
        {
            var Booklet = _context.Booklets.Find(id);

            if (Booklet == null)
            {
                throw new NotImplementedException();
            }

            Booklet.Price = price;

            _context.Update(Booklet);
            _context.SaveChangesAsync();
        }
        public void DeleteBooklet(int id)
        {
            var booklet = _context.Booklets.Where(b => b.Id == id).FirstOrDefault();

            if (booklet != null)
            {
                _context.Booklets.Remove(booklet);
                _context.SaveChanges();
            }
        }
    }


}
