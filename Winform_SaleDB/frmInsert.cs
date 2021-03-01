using ProductLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SaleDB
{
    public partial class frmInsert : Form
    {
        private ProductDB db = new ProductDB();
        public frmInsert()
        {
            InitializeComponent();
        }

        private string validData()
        {
            string mes = "";
            //ID                  
            try
            {
                int Id = int.Parse(txtID.Text);
                db.GetProductList().ForEach(delegate (Product tp)
                {
                    if (tp.ProductID == Id)
                    {
                        mes += "ID is existed!\n";
                    }
                });
            }
            catch (Exception e)
            {
                mes += "ID must be a integer number!\n";
            }            
            //Name
            if (txtName.Text.Trim().Length == 0)
            {
                mes += "Name cannot be empty!\n";
            }
            //UnitPrice
            try
            {
                float price = float.Parse(txtPrice.Text);
                if (price < 0)
                {
                    mes += "UnitPrice must be greater or equal than 0!\n";
                }
            }
            catch (Exception e)
            {
                mes += "UnitPrice must be a number!\n";
            }
            //Quantity
            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                if (quantity < 0)
                {
                    mes += "Quantity must be greater or equal than 0!\n";
                }
            }
            catch (Exception e)
            {
                mes += "Quantity must be a integer number!\n";
            }
            return mes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mes = validData();
            if (mes.Length != 0)
            {
                MessageBox.Show(mes);
                return;
            }
            Product p = new Product()
            {
                ProductID = int.Parse(txtID.Text),
                ProductName = txtName.Text,
                UnitPrice = float.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text)
            };
            if (db.AddNewProduct(p))
            {
                MessageBox.Show("Insert succeed");
            }
            else
            {
                MessageBox.Show("Insert fail");
            }
            this.Close();
        }
    }
}
