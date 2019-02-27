using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ProcessDuplicatesTarget
{
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductsReport()
        {
            InitializeComponent();
        }
        // Display duplicate values.
        public void NoMerge() {
            this.ShowPreviewDialog();
        }
        // Merge duplicate the XRControl.Tag property's values.
        public void MergeByTag() {
            ExpressionBinding expressionBinding = new ExpressionBinding("BeforePrint", "Tag", "ToStr([SupplierID]) + '_' + ToStr([CategoryID])");
            this.xrTableCell2.ExpressionBindings.Add(expressionBinding);
            this.xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge;
            this.xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Tag;
            this.ShowPreviewDialog();
        }
        // Merge duplicate values of a report control's data.
        public void MergeByValue() {
            ExpressionBinding expressionBinding = new ExpressionBinding("BeforePrint", "Text", "[CategoryName]");
            this.xrTableCell2.ExpressionBindings.Add(expressionBinding);
            this.xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge;
            this.xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Value;
            this.ShowPreviewDialog();
        }
    }
}
