Imports Microsoft.VisualBasic
Imports System
Namespace SuppressBlankLines
	Partial Public Class XtraReport1
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.nwindDataSet1 = New SuppressBlankLines.nwindDataSet()
			Me.customersTableAdapter = New SuppressBlankLines.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 113
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Lavender
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName", "")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel1.KeepTogether = True
			Me.xrLabel1.Location = New System.Drawing.Point(167, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(225, 33)
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Lavender
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel2.KeepTogether = True
			Me.xrLabel2.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(150, 33)
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "Contact Name"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel5
			' 
			Me.xrLabel5.BackColor = System.Drawing.Color.GreenYellow
			Me.xrLabel5.CanShrink = True
			Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel5.KeepTogether = True
			Me.xrLabel5.Location = New System.Drawing.Point(8, 42)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.Size = New System.Drawing.Size(150, 34)
			Me.xrLabel5.StylePriority.UseTextAlignment = False
			Me.xrLabel5.Text = "Fax"
			Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
'			Me.xrLabel5.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel5_BeforePrint);
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.GreenYellow
			Me.xrLabel6.CanShrink = True
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Fax", "")})
			Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel6.KeepTogether = True
			Me.xrLabel6.Location = New System.Drawing.Point(167, 42)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.Size = New System.Drawing.Size(225, 34)
			Me.xrLabel6.StylePriority.UseTextAlignment = False
			Me.xrLabel6.Text = "xrLabel1"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
'			Me.xrLabel6.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel6_BeforePrint);
			' 
			' xrLabel7
			' 
			Me.xrLabel7.BackColor = System.Drawing.Color.AliceBlue
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Phone", "")})
			Me.xrLabel7.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel7.KeepTogether = True
			Me.xrLabel7.Location = New System.Drawing.Point(167, 77)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.Size = New System.Drawing.Size(225, 26)
			Me.xrLabel7.StylePriority.UseTextAlignment = False
			Me.xrLabel7.Text = "xrLabel7"
			Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel8
			' 
			Me.xrLabel8.BackColor = System.Drawing.Color.AliceBlue
			Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.xrLabel8.KeepTogether = True
			Me.xrLabel8.Location = New System.Drawing.Point(8, 77)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.Size = New System.Drawing.Size(150, 25)
			Me.xrLabel8.StylePriority.UseTextAlignment = False
			Me.xrLabel8.Text = "Phone"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLine1
			' 
			Me.xrLine1.Location = New System.Drawing.Point(8, 104)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrLine1.Size = New System.Drawing.Size(384, 9)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.DataAdapter = Me.customersTableAdapter
			Me.DataMember = "Customers"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private nwindDataSet1 As nwindDataSet
		Private customersTableAdapter As SuppressBlankLines.nwindDataSetTableAdapters.CustomersTableAdapter
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
