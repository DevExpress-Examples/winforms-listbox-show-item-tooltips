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
            listBoxControl1.ToolTipController = toolTipController1
            AddHandler toolTipController1.GetActiveObjectInfo, AddressOf toolTipController1_GetActiveObjectInfo
        End Sub

        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs)
            Dim listBoxControl As ListBoxControl = TryCast(e.SelectedControl, ListBoxControl)
            If listBoxControl Is Nothing Then Return

            Dim index As Integer = listBoxControl.IndexFromPoint(e.ControlMousePosition)
            If index <> -1 Then
                Dim item As String = TryCast(listBoxControl.GetItem(index), String)
                Dim obj As Object = index.ToString() & item
                e.Info = New DevExpress.Utils.ToolTipControlInfo(obj, item)
            End If
        End Sub
	End Class
End Namespace