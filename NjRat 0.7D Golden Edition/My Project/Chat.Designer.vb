Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Chat
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000135 RID: 309 RVA: 0x0000B050 File Offset: 0x00009250
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000136 RID: 310 RVA: 0x0000B094 File Offset: 0x00009294
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.vmethod_8 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.T2)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 191)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(405, 29)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.Cyan
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(324, 0)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(81, 29)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Send"
			Me.Button1.UseVisualStyleBackColor = True
			Me.T2.BackColor = Global.System.Drawing.Color.Black
			Me.T2.ForeColor = Global.System.Drawing.Color.Lime
			Dim t As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(0, 0)
			t.Location = location
			Me.T2.Multiline = True
			Me.T2.Name = "T2"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(324, 29)
			t2.Size = size
			Me.T2.TabIndex = 0
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.T1.ForeColor = Global.System.Drawing.Color.Lime
			Dim t3 As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(0, 0)
			t3.Location = location
			Me.T1.Name = "T1"
			Dim t4 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(405, 191)
			t4.Size = size
			Me.T1.TabIndex = 1
			Me.T1.Text = ""
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(405, 220)
			Me.ClientSize = size
			Me.Controls.Add(Me.T1)
			Me.Controls.Add(Me.Panel1)
			Me.Name = "Chat"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chat"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400008C RID: 140
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
