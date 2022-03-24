﻿using gy_entityform.Data;
using gy_entityform.Models;
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
    public partial class SupplierAdmin : Form
    {
        public SupplierAdmin()
        {
            InitializeComponent();
        }

        DbContextShop dbContextShop = new DbContextShop();

        private void loadGridView()
        {
            dataGridView1.DataSource = dbContextShop.Suppliers.ToList();
        }

        private void cleanUp()
        {
            textbox_name.Text = string.Empty;
            textbox_info.Text = string.Empty;
        }

        private void SupplierAdmin_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                Name = textbox_name.Text,
                Info = textbox_info.Text
            };

            dbContextShop.Suppliers.Add(supplier);
            dbContextShop.SaveChanges();
            cleanUp();
            loadGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            //var id = row.Cells["Id"].Value;
            //var item = _context.Set<Supplier>().Where(i => i.Id == 3);
            //_context.Remove(item);

            //var deletedItem = _context.Entry(item);
            //deletedItem.State = EntityState.Deleted;
            //dbContextShop.SaveChanges();
        }
    }
}
