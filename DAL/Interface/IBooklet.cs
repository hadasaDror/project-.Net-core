using DAL.Dtos;
using MODELS.Models;
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
        List<BookletDTO> GetAllBooklets();
        Task<BookletDTO> GetBookletByName(string name);
        void UpdatePrice(double price, int id);
        public void DeleteBooklet(int id);

    }
}
