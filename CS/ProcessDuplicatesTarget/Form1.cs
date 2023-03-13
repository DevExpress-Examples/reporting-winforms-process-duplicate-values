using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessDuplicatesTarget
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductReport report = new ProductReport();
            report.NoMerge();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductReport report = new ProductReport();
            report.MergeByTag();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductReport report = new ProductReport();
            report.MergeByValue();
        }
    }
}
