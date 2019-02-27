using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessDuplicatesTarget
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            ProductsReport report = new ProductsReport();
            report.NoMerge();
        }

        private void button2_Click(object sender, EventArgs e) {
            ProductsReport report = new ProductsReport();
            report.MergeByTag();
        }

        private void button3_Click(object sender, EventArgs e) {
            ProductsReport report = new ProductsReport();
            report.MergeByValue();
        }
    }
}
