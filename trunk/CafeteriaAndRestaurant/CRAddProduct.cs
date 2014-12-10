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
            CafeteriaAndRestaurantEntities contextDB = new CafeteriaAndRestaurantEntities();
            var list = from product in contextDB.Products
                       from producttype in contextDB.ProductFroms
                       from category in contextDB.Categories
                       where category.ProductFromId== producttype.ProductFromId && product.CategoryId == category.CategoryId
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
            if(list.ToList() !=null)
            {
                foreach (var l in list.ToList())
                {
                    gvproductlist.Rows.Add(l.productId, l.productName,l.productUnit, l.productPrice, l.categoryName, l.productDes, "Delete",l.categoryId,l.productTypeId);
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
            if(string.IsNullOrEmpty(txtproductname.Text) || string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtunit.Text) || IsNumber(txtprice.Text)==false)
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
                        OriginalPrice=float.Parse(txtprice.Text),
                        CategoryId=int.Parse(cbocategory.SelectedValue.ToString()),
                        Description=txtdescription.Text
                    };
                    ProductBLL.InserProduct(product);
                    MessageBox.Show("Process Successful", "Warning");
                    Cleartextbox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Process Successful", "Warning");
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
                            OriginalPrice = float.Parse(txtprice.Text),
                            ProductUnit = txtunit.Text,
                            CategoryId = int.Parse(cbocategory.SelectedValue.ToString()),
                            Description = txtdescription.Text
                        };
                        ProductBLL.UpdateProduct(product);
                        MessageBox.Show("Process Successful", "Warning");
                        Cleartextbox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Process Successful", "Warning");
                    }
                }
                LoadProductList();
                
        }

        private void gvproductlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
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
                            OriginalPrice = float.Parse(txtprice.Text),
                            ProductUnit = txtunit.Text,
                            CategoryId = int.Parse(cbocategory.SelectedValue.ToString()),
                            Description = txtdescription.Text
                        };
                        ProductBLL.DeleteProduct(product);
                        MessageBox.Show("Process Successful", "Warning");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Process Successful", "Warning");
                    }
                }
                LoadProductList();
                Cleartextbox();
            }                
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar == decimalChar && txtprice.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

    }
}
