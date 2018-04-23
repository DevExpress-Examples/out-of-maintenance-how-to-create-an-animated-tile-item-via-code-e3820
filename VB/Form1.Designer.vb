Imports Microsoft.VisualBasic
Imports System
Namespace WinTileItemCodeCreating
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
            Me.tileControl1 = New DevExpress.XtraEditors.TileControl()
            Me.contentGenerate = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'tileControl1
            '
            Me.tileControl1.Location = New System.Drawing.Point(0, 0)
            Me.tileControl1.Name = "tileControl1"
            Me.tileControl1.Size = New System.Drawing.Size(286, 225)
            Me.tileControl1.TabIndex = 0
            Me.tileControl1.Text = "tileControl1"
            '
            'contentGenerate
            '

            Me.contentGenerate.Location = New System.Drawing.Point(61, 231)
            Me.contentGenerate.Name = "contentGenerate"
            Me.contentGenerate.Size = New System.Drawing.Size(139, 23)
            Me.contentGenerate.TabIndex = 1
            Me.contentGenerate.Text = "Create an Item"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.contentGenerate)
            Me.Controls.Add(Me.tileControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private tileControl1 As DevExpress.XtraEditors.TileControl
		Private WithEvents contentGenerate As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

