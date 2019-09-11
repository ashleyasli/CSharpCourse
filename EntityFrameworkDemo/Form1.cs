using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                ////StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!");
        }
        private void DgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void SearchProducts(string key)
        {
           // var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void LblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
