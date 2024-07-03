using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IBooklet
    {
        Task<bool> CreateBooklet(BookletDTO booklet);
        Task<List<BookletDTO>> GetAllBooklet();
        Task<BookletDTO> GetBookletByName(string name);

    }
}
