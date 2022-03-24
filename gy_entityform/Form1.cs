using gy_entityform.Data;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbContextShop dbContextShop = new DbContextShop();

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContextShop.Database.EnsureCreated();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Form1 form = new Form1();
            admin.Show();
            form.Hide();
        }
    }
}
