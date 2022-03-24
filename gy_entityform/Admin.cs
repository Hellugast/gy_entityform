using gy_entityform.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gy_entityform
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        DbContextShop dbContextShop = new DbContextShop();

        private void Admin_Load(object sender, EventArgs e)
        {


            var AllContext = dbContextShop.Products.Include(p => p.Supplier)
                                                   .Include(p => p.Carts)
                                                   .ThenInclude(pc => pc.Cart);


            var data = AllContext.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Supplier = p.Supplier.Name,
                Stock = p.StockAmount


            }) ;

               
        

            var list = data.ToList();
            dataGridView1.DataSource = list;
            // dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierAdmin supplierAdmin = new SupplierAdmin();
            supplierAdmin.Show();
        }
    }
}
