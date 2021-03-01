
namespace Winform_SaleDB
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbRs = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(113, 55);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(98, 17);
            this.text.TabIndex = 0;
            this.text.Text = "Product Name";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(238, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(243, 22);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(277, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbRs
            // 
            this.lbRs.AutoSize = true;
            this.lbRs.Location = new System.Drawing.Point(313, 144);
            this.lbRs.Name = "lbRs";
            this.lbRs.Size = new System.Drawing.Size(64, 17);
            this.lbRs.TabIndex = 4;
            this.lbRs.Text = "Result: 0";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(316, 338);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(189, 22);
            this.txtQuantity.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(316, 284);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(189, 22);
            this.txtPrice.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(316, 229);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(316, 181);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "UnitPrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ProductName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ProductID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(316, 392);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(189, 22);
            this.txtSubTotal.TabIndex = 17;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbRs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.text);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbRs;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}