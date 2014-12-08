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
using CafeteriaAndRestaurant.Models;

namespace CafeteriaAndRestaurant
{
    public partial class CRRestaurant : Form
    {
        private int TypeId;
        public CRRestaurant(int id)
        {
            TypeId = id;
            InitializeComponent();
        }

        private void LoadCboCategories()
        {
            BLLCategory categoryBLL = new BLLCategory();
            cboCategories.DisplayMember = "CategoryName";
            cboCategories.ValueMember = "CategoryId";
            cboCategories.DataSource = categoryBLL.GetCategoriesByTypeId(TypeId);
        }

        private void CRRestaurant_Load(object sender, EventArgs e)
        {
            gvProducts.AutoGenerateColumns = false;
            gvProductsToBills.AutoGenerateColumns = false;
            LoadCboCategories();
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLProduct productBLL = new BLLProduct();
            gvProducts.DataSource = productBLL.GetProductByCategoryId(int.Parse(cboCategories.SelectedValue.ToString()));
        }

        private void gvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int productId = int.Parse(gvProducts.Rows[e.RowIndex].Cells["colProductId"].Value.ToString());
                Product product = new Product();
                BLLProduct productBLL = new BLLProduct();
                product = productBLL.GetProductById(productId);

                lbName.Text = product.ProductName;
                lbPrice.Text = product.OriginalPrice.ToString();
                lbUnit.Text = product.ProductUnit;
                lbDescription.Text = product.Description;
            }
        }

        private Boolean TestExistsProductInBills(DataGridView gv, int productId, ref int rowIndex)
        {
            if (gv.Rows.Count != 0)
            {
                for (int i = 0; i < gv.Rows.Count; i++)
                {
                    if (int.Parse(gv.Rows[i].Cells["colID"].Value.ToString()) == productId)
                    {
                        rowIndex = i;
                        return true;
                    }
                }
            }
            return false;
        }

        private void gvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int productId = int.Parse(gvProducts.Rows[e.RowIndex].Cells["colProductId"].Value.ToString());
                int rowIndex = -1;

                Product product = new Product();
                BLLProduct productBLL = new BLLProduct();
                product = productBLL.GetProductById(productId);

                if (TestExistsProductInBills(gvProductsToBills, productId, ref rowIndex))
                {
                    gvProductsToBills.Rows[rowIndex].Cells["colAmounts"].Value = int.Parse(gvProductsToBills.Rows[rowIndex].Cells["colAmounts"].Value.ToString()) + 1;
                    gvProductsToBills.Rows[rowIndex].Cells["colTotal"].Value = float.Parse(gvProductsToBills.Rows[rowIndex].Cells["colTotal"].Value.ToString()) + product.OriginalPrice;
                }
                else
                {
                    gvProductsToBills.Rows.Add(product.ProductId, product.ProductName, product.OriginalPrice, 1, product.OriginalPrice, "Delete");
                }

                lbTotal.Text = SumTotal().ToString();
            }  
        }

        private void gvProductsToBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && gvProductsToBills.Columns[e.ColumnIndex].Name == "colDeleted")
            {
                if (MessageBox.Show("Are you sure to delete: " + gvProductsToBills.Rows[e.RowIndex].Cells["colProductName"].Value.ToString(), "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    gvProductsToBills.Rows.RemoveAt(e.RowIndex);

                lbTotal.Text = SumTotal().ToString();
            }
        }

        private void gvProductsToBills_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gvProductsToBills.Rows.Count != 0)
            {
                int tempAmounts;
                float tempRealPrice;
                if (!int.TryParse(gvProductsToBills.Rows[e.RowIndex].Cells["colAmounts"].Value.ToString(), out tempAmounts))
                {
                    MessageBox.Show("Amounts is number", "Message");
                    gvProductsToBills.Rows[e.RowIndex].Cells["colAmounts"].Value = amountsCurrent;
                    return;
                }
                if (!float.TryParse(gvProductsToBills.Rows[e.RowIndex].Cells["colRealPrice"].Value.ToString(), out tempRealPrice))
                {
                    MessageBox.Show("Amounts is number", "Message");
                    gvProductsToBills.Rows[e.RowIndex].Cells["colRealPrice"].Value = realPriceCurrent;
                    return;
                }

                int amounts = int.Parse(gvProductsToBills.Rows[e.RowIndex].Cells["colAmounts"].Value.ToString());
                float realPrice = float.Parse(gvProductsToBills.Rows[e.RowIndex].Cells["colRealPrice"].Value.ToString());
                float total = amounts * realPrice;
                gvProductsToBills.Rows[e.RowIndex].Cells["colTotal"].Value = total;

                lbTotal.Text = SumTotal().ToString();
            }
        }

        private void gvProductsToBills_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (int.TryParse(gvProductsToBills.CurrentRow.Cells["colAmounts"].Value.ToString(), out amountsCurrent)) { }
            if (float.TryParse(gvProductsToBills.CurrentRow.Cells["colRealPrice"].Value.ToString(), out realPriceCurrent)) { }
        }

        private static int amountsCurrent;
        private static float realPriceCurrent;
        private float SumTotal()
        {
            float total = 0;
            for (int i = 0; i < gvProductsToBills.Rows.Count; i++)
            {
                total += float.Parse(gvProductsToBills.Rows[i].Cells["colTotal"].Value.ToString());
            }
            return total;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            List<BillDetail> lstBillDetail = new List<BillDetail>();
            for (int i = 0; i < gvProductsToBills.Rows.Count; i++)
            {
                BillDetail billDetail = new BillDetail()
                {
                    ProductId = int.Parse(gvProductsToBills.Rows[i].Cells["colID"].Value.ToString()),
                    Amounts = int.Parse(gvProductsToBills.Rows[i].Cells["colAmounts"].Value.ToString()),
                    RealPrice = float.Parse(gvProductsToBills.Rows[i].Cells["colRealPrice"].Value.ToString()),
                    Sum = float.Parse(gvProductsToBills.Rows[i].Cells["colTotal"].Value.ToString()),
                    BillDetailDescription = string.Empty
                };
                lstBillDetail.Add(billDetail);
            }

            Bill bills = new Bill()
            {
                CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                BillDescription = "",
                Total = double.Parse(lbTotal.Text),
                BillDetails = lstBillDetail
            };

            BLLBills billsBLL = new BLLBills();
            if (billsBLL.Inserted(bills))
            {
                MessageBox.Show("Created bills successful", "Message");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gvProductsToBills.Rows.Count == 0)
            {
                MessageBox.Show("Choose product, Please!", "Message");
                return;
            }
            List<PrintDto> lstProductForPrint = new List<PrintDto>();
            for (int i = 0; i < gvProductsToBills.Rows.Count; i++)
            {
                PrintDto printDto = new PrintDto()
                {
                    ProductName = gvProductsToBills.Rows[i].Cells["colProductName"].Value.ToString(),
                    Price = float.Parse(gvProductsToBills.Rows[i].Cells["colRealPrice"].Value.ToString()),
                    Amounts = int.Parse(gvProductsToBills.Rows[i].Cells["colAmounts"].Value.ToString()),
                    Sum = float.Parse(gvProductsToBills.Rows[i].Cells["colTotal"].Value.ToString()),
                    Total = SumTotal()
                };
                lstProductForPrint.Add(printDto);
            }
            CRReport frm = new CRReport(lstProductForPrint);
            frm.ShowDialog();
        }
    }
}
