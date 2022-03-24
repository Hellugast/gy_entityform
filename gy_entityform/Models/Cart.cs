using gy_entityform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gy_entityform.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? TotalPrice { get; set; }


        public List<ProductsCarts> Products { get; set; }



    }
}
