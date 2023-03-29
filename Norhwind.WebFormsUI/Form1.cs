using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Norhwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        IProductService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadCategoriesforcbxAdd();
            LoadCategoriesforcbxUpdate();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";     
        }
        private void LoadCategoriesforcbxAdd()
        {
            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
        }
        private void LoadCategoriesforcbxUpdate()
        {
            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductNameAdd.Text,
                    CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAdd.Text),
                    QuantityPerUnit = tbxUnitPcsAdd.Text

                });
                MessageBox.Show("Product Added!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),//id değerine göre güncelleme işlemi yapılacaktır. id değer datagrid de seçilen satırdan gelecektir.
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                    QuantityPerUnit = tbxUnitPcsUpdate.Text

                });
                MessageBox.Show("Product Updated!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxCategoryUpdate.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();            
            tbxPriceUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPcsUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxStockUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)//id işlemine göre silme işlemi yapılacaktır. id değeri datagrid de seçilen satırdan gelen değer olacaktır.
                    });
                    MessageBox.Show("Product Deleted!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Product could not be deleted!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
             
            }          
         
        }

       
    }
}
