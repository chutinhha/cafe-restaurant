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
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace CafeteriaAndRestaurant
{
    public partial class CRAddCategory : Form
    {
        BLLCategory CategoyBLL = new BLLCategory();
        BLLProductFrom BllProductType = new BLLProductFrom();
        int categoryId = int.MinValue;
        ReadXML message = new ReadXML();
        public CRAddCategory()
        {
            InitializeComponent();
        }       
        private void CRAddCategory_Load(object sender, EventArgs e)
        {
            LoadProductType();
            LoadCategory();
            gvCategory.Columns["colDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                var result = list.OrderByDescending(a => a.CategoryId);
                foreach (var l in result)
                {
                    ProductFrom producttypename = BllProductType.GetProductTypeById(l.ProductFromId);
                    gvCategory.Rows.Add(l.CategoryId, l.CategoryName, producttypename.ProductFromName, l.CategoryDescription,Properties.Resources.DeleteRed);
                }
                gvCategory.Refresh();
                this.Refresh();
            }            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if(string.IsNullOrEmpty(txtCategoryname.Text) || string.IsNullOrEmpty(cboCategoryFrom.Text))
            {
                MessageBox.Show(message.ReadXml(7), "Warning");
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
                        MessageBox.Show(message.ReadXml(1), "Warning");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(message.ReadXml(2), "Warning");
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
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
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
                             MessageBox.Show(message.ReadXml(5), "Warning");
                             txtCategoryname.Text = "";
                             txtCategoryname.Focus();
                         }
                         catch { MessageBox.Show(message.ReadXml(6), "Warning"); }
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
                        MessageBox.Show(message.ReadXml(3), "Warning");
                        txtCategoryname.Text = "";
                        txtCategoryname.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(message.ReadXml(4), "Warning");
                    }                
                LoadCategory();
                
            }                
        }
    }
}
