Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication45
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub listBoxControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl1.MouseMove
			Dim listBoxControl As ListBoxControl = TryCast(sender, ListBoxControl)
			Dim index As Integer = listBoxControl.IndexFromPoint(New Point(e.X, e.Y))
			If index <> -1 Then
				Dim item As String = TryCast(listBoxControl.GetItem(index), String)
				toolTipController1.ShowHint(item, listBoxControl.PointToScreen(New Point(e.X, e.Y)))
			Else
				toolTipController1.HideHint()
			End If

		End Sub

		Private Sub listBoxControl1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.MouseLeave
			toolTipController1.HideHint()
		End Sub
	End Class
End Namespace