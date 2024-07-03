using DAL.Dtos;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class BookletData:IBooklet
    {
        public async Task<bool> CreateBooklet(BookletDTO booklet)
        {
            return true;
        }
        //public async Task<List<BookletDTO>> GetAllBooklet()
        //{

        //}
        //public async Task<BookletDTO> GetBookletByName(string name)
        //{

        //}
    }
}
