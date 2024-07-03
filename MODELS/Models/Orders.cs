using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Models
{
    public class Orders
    {
        public int id { get; set; }
        public string OrderingName { get; set; }
        public Dictionary<string,int> myAllBooklet { get; set; }
        public DateTime dateOrder { get; set; }
    }
}
