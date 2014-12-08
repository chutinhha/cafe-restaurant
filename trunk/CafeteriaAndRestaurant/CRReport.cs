using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CafeteriaAndRestaurant.Models;

namespace CafeteriaAndRestaurant
{
    public partial class CRReport : Form
    {
        private List<PrintDto> ProductForPrintList;
        public CRReport(List<PrintDto> lstProductForPrint)
        {            
            InitializeComponent();
            ProductForPrintList = lstProductForPrint;
        }

        private void CRReport_Load(object sender, EventArgs e)
        {
            CRpCafe.SetDataSource(ProductForPrintList);
            crystalReportViewer1.RefreshReport();
        }
    }
}
