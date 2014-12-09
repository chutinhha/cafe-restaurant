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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CRAddProduct_Load(object sender, EventArgs e)
        {
            LoadProductType();
            LoadProductList();
        }
        private void LoadProductType()
        {
            cboproducttype.DisplayMember = "ProductFromName";
            cboproducttype.ValueMember = "ProductFromId";
            cboproducttype.DataSource = ProductTypeBLL.GetProductFrom();
        }

        private void cboproducttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocategory.DisplayMember = "CategoryName";
            cbocategory.ValueMember = "CategoryId";
            cbocategory.DataSource=CategogyBLL.GetCategoriesByTypeId(int.Parse(cboproducttype.SelectedValue.ToString()));
        }
        private void LoadProductList()
        {
            gvproductlist.Rows.Clear();
            var list = ProductBLL.GetProductList();
            if(list.ToList()!=null)
            {
                foreach (var l in list)
                {
                    gvproductlist.Rows.Add(l.ProductId, l.ProductName, l.ProductUnit, l.OriginalPrice, l.Category.CategoryName, l.Description, "Delete");
                }
                gvproductlist.Refresh();
            }  
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtproductname.Text) || string.IsNullOrEmpty(txtprice.Text))
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
                cbocategory.Text = gvproductlist.Rows[rowindex].Cells["colCategory"].Value.ToString();
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
                //DialogResult result = MessageBox.Show("Do you want to delete ?","Warning", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
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
                //}                
        }

    }
}
