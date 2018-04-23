Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace SuppressBlankLines
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel5.BeforePrint
			' Get the current value of the "Fax" data column
			Dim faxName As String = GetCurrentColumnValue("Fax").ToString()

			' Check if the value is null, then cancel the printing
			'if (faxName == "") e.Cancel = true;
			If faxName = "" Then
				CType(sender, XRLabel).Text = String.Empty
			Else
				CType(sender, XRLabel).Text = "Fax"
			End If
		End Sub

		Private Sub xrLabel6_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel6.BeforePrint
			' Get the current value of the "Fax" data column
			Dim faxName As String = GetCurrentColumnValue("Fax").ToString()

			' Check if the value is null, then cancel the printing
			'if (faxName == "") e.Cancel = true;
			If faxName = "" Then
				CType(sender, XRLabel).Text = String.Empty
			End If
		End Sub

	End Class
End Namespace
