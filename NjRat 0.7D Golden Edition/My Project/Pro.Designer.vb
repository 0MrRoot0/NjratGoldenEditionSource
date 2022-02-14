Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Pro
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000420 RID: 1056 RVA: 0x00022D0C File Offset: 0x00020F0C
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

		' Token: 0x06000421 RID: 1057 RVA: 0x00022D50 File Offset: 0x00020F50
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(411, 17)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(106, 29)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Open"
			Me.Button1.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(12, 26)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(393, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(13, 9)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(35, 13)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "URL :"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(523, 54)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button1)
			Me.ForeColor = Global.System.Drawing.Color.Aqua
			Me.Name = "Pro"
			Me.Text = "Open Page From Hide"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040001EC RID: 492
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
