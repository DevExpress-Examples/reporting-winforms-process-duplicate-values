Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace ProcessDuplicatesTarget
	Partial Public Class ProductReport
		Inherits DevExpress.XtraReports.UI.XtraReport

			Public Sub New()
				InitializeComponent()
			End Sub
			' Display duplicate values.
			Public Sub NoMerge()
				Me.ShowPreviewDialog()
			End Sub
			' Merge duplicate values of the XRControl.Tag property.
			Public Sub MergeByTag()
				Dim expressionBinding As New ExpressionBinding("BeforePrint", "Tag", "ToStr([SupplierID]) + '_' + ToStr([CategoryID])")
				Me.xrTableCell2.ExpressionBindings.Add(expressionBinding)
				Me.xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge
				Me.xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Tag
				Me.ShowPreviewDialog()
			End Sub
			' Merge duplicate values of a report control's data.
			Public Sub MergeByValue()
				Dim expressionBinding As New ExpressionBinding("BeforePrint", "Text", "[CategoryName]")
				Me.xrTableCell2.ExpressionBindings.Add(expressionBinding)
				Me.xrTableCell2.ProcessDuplicatesMode = ProcessDuplicatesMode.Merge
				Me.xrTableCell2.ProcessDuplicatesTarget = DevExpress.XtraReports.UI.ProcessDuplicatesTarget.Value
				Me.ShowPreviewDialog()
			End Sub
	End Class
End Namespace
