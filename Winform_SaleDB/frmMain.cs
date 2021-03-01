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
    public partial class frmMain : Form
    {
        private ProductDB db = new ProductDB();
        private List<Product> products;

        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadProduct()
        {
            //Fill data
            products = db.GetProductList();
            dgvListProduct.DataSource = products;
            //Clear
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            //Set value
            txtID.DataBindings.Add("Text",products,"ProductID");
            txtName.DataBindings.Add("Text", products, "ProductName");
            txtPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtQuantity.DataBindings.Add("Text", products, "Quantity");
        }
     
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadProduct();  
        }
        private void dgvListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private string validData(bool isAdd)
        {
            string mes="";
            //ID
            if (isAdd)
            {
                try
                {
                    int Id = int.Parse(txtID.Text);
                    products.ForEach(delegate (Product tp)
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
                if(price < 0)
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
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert frm = new frmInsert();         
            frm.ShowDialog();
            LoadProduct();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            string mes = validData(false);
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
            if (db.UpdateProduct(p))
            {
                MessageBox.Show("Update succeed!");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
            Product p = new Product() { ProductID = int.Parse(txtID.Text) };
            if (db.RemoveProduct(p))
            {
                MessageBox.Show("Delete succeed!");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Delete fail!");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }
       
    }
}
