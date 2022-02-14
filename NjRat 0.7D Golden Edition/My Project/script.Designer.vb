Namespace NJRAT
	' Token: 0x02000021 RID: 33
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class script
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600046D RID: 1133 RVA: 0x000253E0 File Offset: 0x000235E0
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

		' Token: 0x0600046E RID: 1134 RVA: 0x00025424 File Offset: 0x00023624
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 271)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(514, 25)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(0, 0)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(429, 25)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Execute"
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.Aqua
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "vbs", "bat", "cmd", "txt", "html", "hta" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(429, 0)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(85, 21)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(0, 0)
			textBox.Location = location
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(514, 271)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(514, 296)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Panel1)
			Me.Name = "script"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "script"
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000219 RID: 537
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
