Namespace ProcessDuplicatesTarget
	Partial Public Class ProductReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductReport))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupCaption2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupData2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.SupplierCategory = New DevExpress.XtraReports.UI.CalculatedField()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 47F
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.label1})
			Me.ReportHeader.HeightF = 45.50001F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' groupHeaderBand1
			' 
			Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2, Me.xrLabel1})
			Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("SupplierID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.groupHeaderBand1.HeightF = 66.45832F
			Me.groupHeaderBand1.Name = "groupHeaderBand1"
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.9999593F, 43.41668F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(734.7917F, 2.083332F)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold)
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(5.999979F, 6.00001F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(732.9999F, 29.41666F)
			Me.label1.StyleName = "Title"
			Me.label1.StylePriority.UseFont = False
			Me.label1.Text = "Products"
			' 
			' xrTable1
			' 
			Me.xrTable1.Font = New System.Drawing.Font("Arial", 9F)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(738.9999F, 25F)
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UsePadding = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.BackColor = System.Drawing.Color.Transparent
			Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.xrTableCell2.Multiline = True
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
			Me.xrTableCell2.StylePriority.UseBackColor = False
			Me.xrTableCell2.StylePriority.UsePadding = False
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell2.Weight = 0.36534009739786377R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.xrTableCell3.Multiline = True
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
			Me.xrTableCell3.StylePriority.UsePadding = False
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell3.Weight = 0.913928918415011R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.xrTableCell4.Multiline = True
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
			Me.xrTableCell4.StylePriority.UsePadding = False
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell4.TextFormatString = "{0:$0.00}"
			Me.xrTableCell4.Weight = 0.32560342289226796R
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.Gainsboro
			Me.xrTable2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 41.45832F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(739F, 25F)
			Me.xrTable2.StylePriority.UseBackColor = False
			Me.xrTable2.StylePriority.UseFont = False
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Transparent
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.ForeColor = System.Drawing.Color.DimGray
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 13.95833F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(738.9999F, 27.49999F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrLabel1.TextFormatString = "Company  ""{0}"""
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
			Me.xrTableRow2.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold)
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.StylePriority.UseFont = False
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Multiline = True
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "  Category Name"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell6.Weight = 0.58764711444440976R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Multiline = True
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "  Product Name"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell7.Weight = 1.4700490489218223R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Multiline = True
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "  Unit Price"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell8.Weight = 0.52373158972915079R
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "localhost_Northwind_Connection"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductID"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""285"" />"
			table1.Name = "Products"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "SupplierID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "CategoryID"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "QuantityPerUnit"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "UnitPrice"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "UnitsInStock"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "UnitsOnOrder"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ReorderLevel"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Discontinued"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "CompanyName"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""305"" />"
			table2.Name = "Suppliers"
			columnExpression11.Table = table2
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "CategoryName"
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""125"" />"
			table3.Name = "Categories"
			columnExpression12.Table = table3
			column12.Expression = columnExpression12
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Name = "Products"
			relationColumnInfo1.NestedKeyColumn = "SupplierID"
			relationColumnInfo1.ParentKeyColumn = "SupplierID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "CategoryID"
			relationColumnInfo2.ParentKeyColumn = "CategoryID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			' 
			' GroupCaption2
			' 
			Me.GroupCaption2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
			Me.GroupCaption2.BorderColor = System.Drawing.Color.White
			Me.GroupCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupCaption2.BorderWidth = 2F
			Me.GroupCaption2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupCaption2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupCaption2.Name = "GroupCaption2"
			Me.GroupCaption2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupData2
			' 
			Me.GroupData2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(162)))), (CInt((CByte(162)))), (CInt((CByte(162)))))
			Me.GroupData2.BorderColor = System.Drawing.Color.White
			Me.GroupData2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupData2.BorderWidth = 2F
			Me.GroupData2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupData2.ForeColor = System.Drawing.Color.White
			Me.GroupData2.Name = "GroupData2"
			Me.GroupData2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaption2
			' 
			Me.DetailCaption2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(111)))), (CInt((CByte(111)))), (CInt((CByte(111)))))
			Me.DetailCaption2.BorderColor = System.Drawing.Color.White
			Me.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption2.BorderWidth = 2F
			Me.DetailCaption2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption2.ForeColor = System.Drawing.Color.White
			Me.DetailCaption2.Name = "DetailCaption2"
			Me.DetailCaption2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData2
			' 
			Me.DetailData2.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData2.BorderWidth = 2F
			Me.DetailData2.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData2.ForeColor = System.Drawing.Color.Black
			Me.DetailData2.Name = "DetailData2"
			Me.DetailData2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupFooterBackground3
			' 
			Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(137)))), (CInt((CByte(137)))))
			Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
			Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupFooterBackground3.BorderWidth = 2F
			Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
			Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' SupplierCategory
			' 
			Me.SupplierCategory.DataMember = "Products"
			Me.SupplierCategory.Expression = "ToStr([SupplierID]) + '_' + ToStr([CategoryID])"
			Me.SupplierCategory.FieldType = DevExpress.XtraReports.UI.FieldType.String
			Me.SupplierCategory.Name = "SupplierCategory"
			' 
			' ProductReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.Detail, Me.groupHeaderBand1})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.SupplierCategory})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Products"
			Me.DataSource = Me.sqlDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Margins = New System.Drawing.Printing.Margins(49, 52, 47, 100)
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption2, Me.GroupData2, Me.DetailCaption2, Me.DetailData2, Me.GroupFooterBackground3, Me.DetailData3_Odd, Me.PageInfo})
			Me.Version = "20.1"
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupCaption2 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupData2 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption2 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData2 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private SupplierCategory As DevExpress.XtraReports.UI.CalculatedField
	End Class
End Namespace
