Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ProcessDuplicatesTarget

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As ProductsReport = New ProductsReport()
            report.NoMerge()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As ProductsReport = New ProductsReport()
            report.MergeByTag()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As ProductsReport = New ProductsReport()
            report.MergeByValue()
        End Sub
    End Class
End Namespace
