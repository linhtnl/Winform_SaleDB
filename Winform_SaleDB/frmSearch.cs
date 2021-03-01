using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductLibrary;
namespace Winform_SaleDB
{
    public partial class frmSearch : Form
    {
        private ProductDB db = new ProductDB();
        public string SearchProductName { get; set; }
        public frmSearch()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            txtProductName.Text = SearchProductName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product p=db.FindProduct(int.Parse(txtProductName.Text));
            if (p != null)
            {
                lbRs.Text = "Result: 1";
                txtID.Text = p.ProductID.ToString();
                txtName.Text = p.ProductName;
                txtPrice.Text = p.UnitPrice.ToString();
                txtQuantity.Text = p.Quantity.ToString();
                txtSubTotal.Text = p.SubTotal.ToString();
            }
            else
            {
                lbRs.Text = "Result: 0";
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtSubTotal.Text = "";
            }
        }
    }
}
