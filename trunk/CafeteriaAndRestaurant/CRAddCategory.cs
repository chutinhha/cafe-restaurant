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
    public partial class CRAddCategory : Form
    {
        BLLCategory CategoyBLL = new BLLCategory();
        BLLProductFrom BllProductType = new BLLProductFrom();
        int categoryId = int.MinValue;
        public CRAddCategory()
        {
            InitializeComponent();
        }
        private void CRAddCategory_Load(object sender, EventArgs e)
        {
            LoadProductType();
            LoadCategory();
        }
        private void LoadProductType()
        {           
            cboCategoryFrom.DisplayMember = "ProductFromName";
            cboCategoryFrom.ValueMember = "ProductFromId";
            cboCategoryFrom.DataSource = BllProductType.GetProductFrom();
        }
        private void LoadCategory()
        {
            gvCategory.Rows.Clear();
            var list = CategoyBLL.GetcategoryList();
            if (list != null)
            {
                foreach (var l in list)
                {
                    ProductFrom producttypename = BllProductType.GetProductTypeById(l.ProductFromId);
                    gvCategory.Rows.Add(l.CategoryId, l.CategoryName, producttypename.ProductFromName, l.CategoryDescription, "Delete");
                }
                gvCategory.Refresh();
                this.Refresh();
            }            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(cboCategoryFrom.Text))
            {
                MessageBox.Show("Information is required", "Warning");
                txtCategoryname.Focus();
            }
            else
            {               
                    try
                    {
                        Category category = new Category
                        {
                            CategoryId = categoryId,
                            CategoryName = txtCategoryname.Text,
                            CategoryDescription = txtDescription.Text,
                            ProductFromId = int.Parse(cboCategoryFrom.SelectedValue.ToString())
                        };
                        CategoyBLL.InsertCategory(category);
                        MessageBox.Show("Process Successfull", "Warning");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Process Error", "Warning");
                    }                
                LoadCategory();
            }               
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = gvCategory.CurrentCell.RowIndex;                
                if(rowindex !=-1)
                {
                    categoryId = int.Parse(gvCategory.Rows[rowindex].Cells["colCategoryId"].Value.ToString());
                    txtCategoryname.Text = gvCategory.Rows[rowindex].Cells["colCategoryName"].Value.ToString();
                    cboCategoryFrom.Text = gvCategory.Rows[rowindex].Cells["colProductType"].Value.ToString();
                    if (gvCategory.Rows[rowindex].Cells["colCategoryDescription"].Value==null)
                    {
                        txtDescription.Text = string.Empty;
                    }
                    else
                    {
                        txtDescription.Text = gvCategory.Rows[rowindex].Cells["colCategoryDescription"].Value.ToString().Trim();
                    }                                       
                }
            }
            catch { }  
        }
        private void gvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int rowindex = gvCategory.CurrentCell.RowIndex;
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
                {
                     DialogResult result = MessageBox.Show("Do you want to delete ?", "Warning", MessageBoxButtons.YesNo);
                     if (result == DialogResult.Yes)
                     {
                         try
                         {
                             Category category = new Category
                             {
                                 CategoryId = categoryId,
                                 CategoryName = txtCategoryname.Text,
                                 CategoryDescription = txtDescription.Text,
                                 ProductFromId = int.Parse(cboCategoryFrom.SelectedValue.ToString())
                             };
                             CategoyBLL.DeleteCategory(category);
                             MessageBox.Show("Process Successfull", "Warning");
                             txtCategoryname.Text = "";
                             txtCategoryname.Focus();
                         }
                         catch { MessageBox.Show("Process Error", "Warning"); }
                     }
                     LoadCategory();
                  
                }                   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(cboCategoryFrom.Text))
            {
                MessageBox.Show("Information is required", "Warning");
                txtCategoryname.Focus();
            }
            else
            {                
                    try
                    {
                        Category category = new Category
                        {
                            CategoryId = categoryId,
                            CategoryName = txtCategoryname.Text,
                            CategoryDescription = txtDescription.Text,
                            ProductFromId = int.Parse(cboCategoryFrom.SelectedValue.ToString())
                        };
                        CategoyBLL.UpdateCategory(category);
                        MessageBox.Show("Process Successfull", "Warning");
                        txtCategoryname.Text = "";
                        txtCategoryname.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Process Error", "Warning");
                    }                
                LoadCategory();
                
            }                
        }
    }
}
