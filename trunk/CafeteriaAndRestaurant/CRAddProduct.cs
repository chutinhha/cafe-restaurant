using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaAndRestaurant.DAL;
using CafeteriaAndRestaurant.BLL;
using System.Threading;
using System.Globalization;
namespace CafeteriaAndRestaurant
{
    public partial class CRAddProduct : Form
    {
        BLLProduct ProductBLL = new BLLProduct();
        BLLCategory CategogyBLL = new BLLCategory();
        BLLProductFrom ProductTypeBLL = new BLLProductFrom();     
        
        int productId = int.MinValue;
        public CRAddProduct()
        {
            InitializeComponent();
        }     

        private void CRAddProduct_Load(object sender, EventArgs e)
        {
            LoadProductType();
            //LoadProductList();
            LoadProductList();
        }
        private void Cleartextbox()
        {
            txtdescription.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtproductname.Text = string.Empty;
            txtunit.Text = string.Empty;
        }
        private void LoadProductType()
        {
            cboproducttype.DisplayMember = "ProductFromName";
            cboproducttype.ValueMember = "ProductFromId";
            cboproducttype.DataSource = ProductTypeBLL.GetProductFrom();
        }
        private void LoadProductList()
        {
            gvproductlist.Rows.Clear();
            CafeteriaAndRestaurantEntities contextDB = new CafeteriaAndRestaurantEntities();
            var list = from product in contextDB.Products
                       from producttype in contextDB.ProductFroms
                       from category in contextDB.Categories
                       where category.ProductFromId== producttype.ProductFromId && product.CategoryId == category.CategoryId
                       orderby product.ProductId descending
                       select new
                       {
                           productId=product.ProductId,
                           categoryId=category.CategoryId,    
                           categoryName=category.CategoryName,
                           productTypeId=producttype.ProductFromId,
                           productTypeName=producttype.ProductFromName,
                           productName=product.ProductName,
                           productUnit=product.ProductUnit,
                           productPrice=product.OriginalPrice,
                           productDes=product.Description
                       };
            if(list !=null)
            {
                foreach (var l in list.ToList())
                {
                    gvproductlist.Rows.Add(l.productId, l.productName,l.productUnit, l.productPrice, l.categoryName, l.productDes,Properties.Resources.DeleteRed ,l.categoryId,l.productTypeId);
                }
            }
           
        }
        private void cboproducttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocategory.DisplayMember = "CategoryName";
            cbocategory.ValueMember = "CategoryId";
            cbocategory.DataSource=CategogyBLL.GetCategoriesByTypeId(int.Parse(cboproducttype.SelectedValue.ToString()));
        }
        //private void LoadProductList()
        //{
        //    gvproductlist.Rows.Clear();
        //    var list = ProductBLL.GetProductList();
        //    if(list!=null)
        //    {
        //        foreach (var l in list)
        //        {
        //            gvproductlist.Rows.Add(l.ProductId, l.ProductName, l.ProductUnit, l.OriginalPrice, l.Category.CategoryName, l.Description, "Delete");
        //        }
        //        gvproductlist.Refresh();
        //        this.Refresh();
        //    }  
        //}
        private bool IsNumber(string pText)
        {
            foreach (Char c in pText)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtproductname.Text) || string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtunit.Text))
            {
                MessageBox.Show("Information Required", "Warning");
            }
            else
            {
                try
                {
                    Product product = new Product
                    {
                        ProductId=productId,
                        ProductName=txtproductname.Text,
                        ProductUnit=txtunit.Text,
                        OriginalPrice = double.Parse(txtprice.Text, CultureInfo.InvariantCulture),
                        CategoryId=int.Parse(cbocategory.SelectedValue.ToString()),
                        Description=txtdescription.Text
                    };
                    ProductBLL.InserProduct(product);
                    MessageBox.Show("Insert Successful", "Warning");
                    Cleartextbox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Insert Fail", "Warning");
                }
            }
            LoadProductList();            
        }

        private void gvproductlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = gvproductlist.CurrentCell.RowIndex;
            if(rowindex!=-1)
            {
                productId = int.Parse(gvproductlist.Rows[rowindex].Cells["colProductId"].Value.ToString());                
                txtproductname.Text = gvproductlist.Rows[rowindex].Cells["colProductName"].Value.ToString();
                txtprice.Text = gvproductlist.Rows[rowindex].Cells["colOriginalPrice"].Value.ToString();
                cboproducttype.SelectedValue = gvproductlist.Rows[rowindex].Cells["colProductType"].Value;
                cbocategory.SelectedValue = gvproductlist.Rows[rowindex].Cells["colCategoryId"].Value;
                if(gvproductlist.Rows[rowindex].Cells["colProductDescription"].Value==null || gvproductlist.Rows[rowindex].Cells["colProductUnit"].Value == null)
                {
                    txtdescription.Text = string.Empty;
                    txtunit.Text = string.Empty;
                }
                else 
                {
                    txtdescription.Text = gvproductlist.Rows[rowindex].Cells["colProductDescription"].Value.ToString().Trim();
                    txtunit.Text = gvproductlist.Rows[rowindex].Cells["colProductUnit"].Value.ToString().Trim();
                }                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtproductname.Text)|| string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Information Required", "Warning");
            }
            else
            {
                    try
                    {
                        Product product = new Product
                        {
                            ProductId = productId,
                            ProductName = txtproductname.Text,
                            OriginalPrice = double.Parse(txtprice.Text),
                            ProductUnit = txtunit.Text,
                            CategoryId = int.Parse(cbocategory.SelectedValue.ToString()),
                            Description = txtdescription.Text
                        };
                        ProductBLL.UpdateProduct(product);
                        MessageBox.Show("Update Successful", "Warning");
                        Cleartextbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Fail", "Warning");
                    }
                }
                LoadProductList();                
        }

        private void gvproductlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete ?","Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Product product = new Product
                        {
                            ProductId = productId,
                            ProductName = txtproductname.Text,
                            OriginalPrice = double.Parse(txtprice.Text),
                            ProductUnit = txtunit.Text,
                            CategoryId = int.Parse(cbocategory.SelectedValue.ToString()),
                            Description = txtdescription.Text
                        };
                        ProductBLL.DeleteProduct(product);
                        MessageBox.Show("Delete Successful", "Warning");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Fail", "Warning");
                    }
                }
                LoadProductList();
                Cleartextbox();
            }                
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

    }
}
