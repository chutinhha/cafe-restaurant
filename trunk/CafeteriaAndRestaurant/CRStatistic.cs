using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaAndRestaurant.BLL;
using CafeteriaAndRestaurant.DAL;
namespace CafeteriaAndRestaurant
{
    public partial class CRStatistic : Form
    {
        BLLProduct ProductBLL = new BLLProduct();
        BLLCategory CategogyBLL = new BLLCategory();
        BLLProductFrom ProductTypeBLL = new BLLProductFrom();
        CafeteriaAndRestaurantEntities contextDB = new CafeteriaAndRestaurantEntities();
        public CRStatistic()
        {
            InitializeComponent();
        }

        private void CRStatistic_Load(object sender, EventArgs e)
        {
            LoadProductFrom();            
        }
        private void LoadProductFrom()
        {
            cboSalesFrom.DisplayMember = "ProductFromName";
            cboSalesFrom.ValueMember = "ProductFromId";
            cboSalesFrom.DataSource = ProductTypeBLL.GetProductFrom();
        }
        private void LoadListProduct(int Salefrom,DateTime timefrom, DateTime timeto)
        {
            if(timefrom>timeto || timefrom>DateTime.Now || timeto>DateTime.Now)
            {
                MessageBox.Show("Process Error, Check again!!!","Warning");
            }
            else
                try
                {
                    var sql = from billdetail in contextDB.BillDetails
                              from bills in contextDB.Bills
                              from category in contextDB.Categories
                              from product in contextDB.Products
                              from producttype in contextDB.ProductFroms
                              where bills.BillId == billdetail.BillId
                              && billdetail.ProductId == product.ProductId
                              && category.CategoryId == product.CategoryId
                              && producttype.ProductFromId == category.ProductFromId
                              && producttype.ProductFromId == Salefrom
                              && bills.CreatedDate >= timefrom
                              && bills.CreatedDate <= timeto
                              //group product by product.ProductId into objgroup
                              //let name = objgroup.FirstOrDefault().ProductName
                              //let quantity=objgroup.FirstOrDefault().BillDetails.Select(c=>c.Amounts).Sum()
                              //let total = objgroup.FirstOrDefault().BillDetails.Select(c => c.Sum).Sum()
                              select new
                              {
                                  ProductId = product.ProductId,
                                  ProductName = product.ProductName,
                                  Quantity = billdetail.Amounts,
                                  Total = billdetail.Sum
                              };
                    if (sql.ToList().Count > 0)
                    {
                        gvstatistic.Rows.Clear();
                        foreach (var item in sql.ToList())
                        {
                            gvstatistic.Rows.Add(item.ProductId, item.ProductName, item.Quantity, item.Total);
                        }
                    }
                }
                catch { throw; }         
        }

        private void cboSalesFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LoadListProduct(int.Parse(cboSalesFrom.SelectedValue.ToString()));
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            float total=0;
            DateTime timefrom = DateTime.Parse(dateTimePickerFrom.Text);
            DateTime timeto = DateTime.Parse(dateTimePickerTo.Text);
            int SalefromId = int.Parse(cboSalesFrom.SelectedValue.ToString());           
            LoadListProduct(SalefromId, timefrom, timeto);
            for(int i=0;i<gvstatistic.Rows.Count;i++)
            {
                 total+= float.Parse(gvstatistic.Rows[i].Cells["colSum"].Value.ToString());
            }
            lbltotal.Text = "Total: "+total.ToString() +" usd";
        }
    }
}
