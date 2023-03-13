Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace ProcessDuplicatesTarget

    Public Partial Class ProductsReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        ' Display duplicate values.
        Public Sub NoMerge()
            ShowPreviewDialog()
        End Sub

        ' Merge duplicate values of the XRControl.Tag property.
        Public Sub MergeByTag()
            Dim expressionBinding As ExpressionBinding = New ExpressionBinding("BeforePrint", "Tag", "ToStr([SupplierID]) + '_' + ToStr([CategoryID])")
            xrTableCell2.ExpressionBindings.Add(expressionBinding)
            xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge
            xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Tag
            ShowPreviewDialog()
        End Sub

        ' Merge duplicate values of a report control's data.
        Public Sub MergeByValue()
            Dim expressionBinding As ExpressionBinding = New ExpressionBinding("BeforePrint", "Text", "[CategoryName]")
            xrTableCell2.ExpressionBindings.Add(expressionBinding)
            xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge
            xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Value
            ShowPreviewDialog()
        End Sub
    End Class
End Namespace
