using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gy_entityform.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }


        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }


        public List<ProductsCarts> Carts { get; set; }


        // public ICollection<ProductsCarts> Players { get; set; } = new HashSet<ProductsCarts>();



    }
}
