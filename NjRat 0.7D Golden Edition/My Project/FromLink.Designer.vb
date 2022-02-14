Namespace NJRAT
	' Token: 0x02000010 RID: 16
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600020A RID: 522 RVA: 0x000135D4 File Offset: 0x000117D4
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

		' Token: 0x0600020B RID: 523 RVA: 0x00013618 File Offset: 0x00011818
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(156, 60)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(82, 23)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "OK"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(244, 60)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(82, 23)
			button4.Size = size
			Me.Button2.TabIndex = 1
			Me.Button2.Text = "Cancel"
			Me.Button2.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(5, 23)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(321, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 2
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.Yellow
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(5, 62)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(140, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 3
			Me.TextBox2.Text = "File.txt"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(2, 46)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(52, 13)
			label2.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Save As"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.Aqua
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(3, 8)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(30, 13)
			label4.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Link"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(331, 91)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.Name = "FromLink"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "FromLink"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000EA RID: 234
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
