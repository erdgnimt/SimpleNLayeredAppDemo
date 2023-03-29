
namespace Norhwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxSearchCategory = new System.Windows.Forms.GroupBox();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxSearchProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitPcsAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxStockAdd = new System.Windows.Forms.TextBox();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPcsUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPcsUpdate = new System.Windows.Forms.Label();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.lblStokUpdate = new System.Windows.Forms.Label();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxSearchCategory.SuspendLayout();
            this.gbxSearchProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 364);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1165, 242);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxSearchCategory
            // 
            this.gbxSearchCategory.Controls.Add(this.cbxCategory);
            this.gbxSearchCategory.Controls.Add(this.lblSearchCategory);
            this.gbxSearchCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchCategory.Location = new System.Drawing.Point(810, 12);
            this.gbxSearchCategory.Name = "gbxSearchCategory";
            this.gbxSearchCategory.Size = new System.Drawing.Size(348, 79);
            this.gbxSearchCategory.TabIndex = 1;
            this.gbxSearchCategory.TabStop = false;
            this.gbxSearchCategory.Text = "Search by Category";
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchCategory.Location = new System.Drawing.Point(49, 35);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(81, 17);
            this.lblSearchCategory.TabIndex = 3;
            this.lblSearchCategory.Text = "Category :";
            // 
            // gbxSearchProduct
            // 
            this.gbxSearchProduct.Controls.Add(this.tbxProductName);
            this.gbxSearchProduct.Controls.Add(this.lblProductName);
            this.gbxSearchProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchProduct.Location = new System.Drawing.Point(810, 107);
            this.gbxSearchProduct.Name = "gbxSearchProduct";
            this.gbxSearchProduct.Size = new System.Drawing.Size(348, 79);
            this.gbxSearchProduct.TabIndex = 2;
            this.gbxSearchProduct.TabStop = false;
            this.gbxSearchProduct.Text = "Search by Product";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.Location = new System.Drawing.Point(143, 29);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 23);
            this.tbxProductName.TabIndex = 5;
            this.tbxProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(14, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 17);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name :";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPcsAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 12);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(776, 174);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Product Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(583, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitPcsAdd
            // 
            this.tbxUnitPcsAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPcsAdd.Location = new System.Drawing.Point(558, 69);
            this.tbxUnitPcsAdd.Name = "tbxUnitPcsAdd";
            this.tbxUnitPcsAdd.Size = new System.Drawing.Size(164, 23);
            this.tbxUnitPcsAdd.TabIndex = 13;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(424, 75);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(76, 17);
            this.lblQuantityPerUnit.TabIndex = 12;
            this.lblQuantityPerUnit.Text = "Unit Pcs  :";
            // 
            // tbxStockAdd
            // 
            this.tbxStockAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAdd.Location = new System.Drawing.Point(558, 29);
            this.tbxStockAdd.Name = "tbxStockAdd";
            this.tbxStockAdd.Size = new System.Drawing.Size(164, 23);
            this.tbxStockAdd.TabIndex = 11;
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.AutoSize = true;
            this.lblStockAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockAdd.Location = new System.Drawing.Point(444, 32);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(56, 17);
            this.lblStockAdd.TabIndex = 10;
            this.lblStockAdd.Text = "Stock :";
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPriceAdd.Location = new System.Drawing.Point(143, 109);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(164, 23);
            this.tbxPriceAdd.TabIndex = 9;
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceAdd.Location = new System.Drawing.Point(80, 115);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(50, 17);
            this.lblPriceAdd.TabIndex = 8;
            this.lblPriceAdd.Text = "Price :";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryAdd.Location = new System.Drawing.Point(49, 75);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(81, 17);
            this.lblCategoryAdd.TabIndex = 6;
            this.lblCategoryAdd.Text = "Category :";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductNameAdd.Location = new System.Drawing.Point(143, 29);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(164, 23);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductNameAdd.Location = new System.Drawing.Point(14, 35);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(116, 17);
            this.lblProductNameAdd.TabIndex = 3;
            this.lblProductNameAdd.Text = "Product Name :";
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPcsUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPcsUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblStokUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxProductUpdate.Location = new System.Drawing.Point(12, 192);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(776, 166);
            this.gbxProductUpdate.TabIndex = 4;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Product Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(583, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPcsUpdate
            // 
            this.tbxUnitPcsUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPcsUpdate.Location = new System.Drawing.Point(558, 69);
            this.tbxUnitPcsUpdate.Name = "tbxUnitPcsUpdate";
            this.tbxUnitPcsUpdate.Size = new System.Drawing.Size(164, 23);
            this.tbxUnitPcsUpdate.TabIndex = 13;
            // 
            // lblUnitPcsUpdate
            // 
            this.lblUnitPcsUpdate.AutoSize = true;
            this.lblUnitPcsUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPcsUpdate.Location = new System.Drawing.Point(424, 75);
            this.lblUnitPcsUpdate.Name = "lblUnitPcsUpdate";
            this.lblUnitPcsUpdate.Size = new System.Drawing.Size(76, 17);
            this.lblUnitPcsUpdate.TabIndex = 12;
            this.lblUnitPcsUpdate.Text = "Unit Pcs  :";
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockUpdate.Location = new System.Drawing.Point(558, 29);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(164, 23);
            this.tbxStockUpdate.TabIndex = 11;
            // 
            // lblStokUpdate
            // 
            this.lblStokUpdate.AutoSize = true;
            this.lblStokUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokUpdate.Location = new System.Drawing.Point(444, 32);
            this.lblStokUpdate.Name = "lblStokUpdate";
            this.lblStokUpdate.Size = new System.Drawing.Size(56, 17);
            this.lblStokUpdate.TabIndex = 10;
            this.lblStokUpdate.Text = "Stock :";
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPriceUpdate.Location = new System.Drawing.Point(143, 109);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(164, 23);
            this.tbxPriceUpdate.TabIndex = 9;
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceUpdate.Location = new System.Drawing.Point(80, 115);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(50, 17);
            this.lblPriceUpdate.TabIndex = 8;
            this.lblPriceUpdate.Text = "Price :";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryUpdate.Location = new System.Drawing.Point(49, 75);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(81, 17);
            this.lblCategoryUpdate.TabIndex = 6;
            this.lblCategoryUpdate.Text = "Category :";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(143, 29);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(164, 23);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductNameUpdate.Location = new System.Drawing.Point(14, 35);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(116, 17);
            this.lblProductNameUpdate.TabIndex = 3;
            this.lblProductNameUpdate.Text = "Product Name :";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(143, 30);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 22);
            this.cbxCategory.TabIndex = 14;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged_1);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(143, 68);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(164, 22);
            this.cbxCategoryAdd.TabIndex = 15;
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(143, 68);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(164, 22);
            this.cbxCategoryUpdate.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(998, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1189, 618);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxSearchProduct);
            this.Controls.Add(this.gbxSearchCategory);
            this.Controls.Add(this.dgwProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxSearchCategory.ResumeLayout(false);
            this.gbxSearchCategory.PerformLayout();
            this.gbxSearchProduct.ResumeLayout(false);
            this.gbxSearchProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxSearchCategory;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxSearchProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitPcsAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStockAdd;
        private System.Windows.Forms.Label lblStockAdd;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPcsUpdate;
        private System.Windows.Forms.Label lblUnitPcsUpdate;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.Label lblStokUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

