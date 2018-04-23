Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication45
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Items.AddRange(New Object() { "one", "two", "three"})
			Me.listBoxControl1.Location = New System.Drawing.Point(75, 80)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(120, 95)
			Me.listBoxControl1.TabIndex = 0
'			Me.listBoxControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.listBoxControl1_MouseMove);
'			Me.listBoxControl1.MouseLeave += New System.EventHandler(Me.listBoxControl1_MouseLeave);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(402, 348)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

