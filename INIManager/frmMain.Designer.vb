﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnTest = New System.Windows.Forms.Button()
		Me.tvwMain = New System.Windows.Forms.TreeView()
		Me.SuspendLayout()
		'
		'btnTest
		'
		Me.btnTest.Location = New System.Drawing.Point(713, 415)
		Me.btnTest.Name = "btnTest"
		Me.btnTest.Size = New System.Drawing.Size(75, 23)
		Me.btnTest.TabIndex = 0
		Me.btnTest.Text = "Test"
		Me.btnTest.UseVisualStyleBackColor = True
		'
		'tvwMain
		'
		Me.tvwMain.Location = New System.Drawing.Point(12, 12)
		Me.tvwMain.Name = "tvwMain"
		Me.tvwMain.Size = New System.Drawing.Size(412, 426)
		Me.tvwMain.TabIndex = 1
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.tvwMain)
		Me.Controls.Add(Me.btnTest)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "INI Manager"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnTest As Button
	Friend WithEvents tvwMain As TreeView
End Class
