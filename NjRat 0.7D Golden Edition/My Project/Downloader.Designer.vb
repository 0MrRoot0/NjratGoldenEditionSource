Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Downloader
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600014B RID: 331 RVA: 0x0000BB9C File Offset: 0x00009D9C
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

		' Token: 0x0600014C RID: 332 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.TextBox1)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 5)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(535, 50)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Normal"
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(421, 16)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(108, 23)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Build"
			Me.Button1.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(76, 19)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(339, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(6, 22)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(64, 13)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Direct Link :"
			Me.GroupBox2.Controls.Add(Me.Label4)
			Me.GroupBox2.Controls.Add(Me.Button2)
			Me.GroupBox2.Controls.Add(Me.TextBox2)
			Me.GroupBox2.Controls.Add(Me.Label2)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(12, 61)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(535, 55)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Entrypoint"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(421, 17)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(108, 23)
			button4.Size = size
			Me.Button2.TabIndex = 3
			Me.Button2.Text = "Build"
			Me.Button2.UseVisualStyleBackColor = True
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.FromArgb(255, 128, 0)
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(76, 19)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(339, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 2
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Global.System.Drawing.Color.Yellow
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(6, 22)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(64, 13)
			label4.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "Direct Link :"
			Me.Label3.AutoSize = True
			Me.Label3.ForeColor = Global.System.Drawing.Color.Lime
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(6, 0)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(40, 13)
			label6.Size = size
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Normal"
			Me.Label4.AutoSize = True
			Me.Label4.ForeColor = Global.System.Drawing.Color.Lime
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(8, -1)
			label7.Location = location
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(54, 13)
			label8.Size = size
			Me.Label4.TabIndex = 4
			Me.Label4.Text = "Entrypoint"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(559, 123)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.ForeColor = Global.System.Drawing.Color.White
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "Downloader"
			Me.Text = "Server Downloader"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000096 RID: 150
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
