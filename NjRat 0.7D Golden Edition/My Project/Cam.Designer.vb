Namespace NJRAT
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Cam
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000115 RID: 277 RVA: 0x0000A0F0 File Offset: 0x000082F0
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

		' Token: 0x06000116 RID: 278 RVA: 0x0000A134 File Offset: 0x00008334
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.vmethod_6 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.ComboBox2)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.CheckBox3)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 230)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(497, 23)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox2.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.Aqua
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "%100", "%90", "%80", "%70", "%60", "%50" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox2
			location = New Global.System.Drawing.Point(410, 0)
			comboBox.Location = location
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox2
			size = New Global.System.Drawing.Size(87, 21)
			comboBox2.Size = size
			Me.ComboBox2.TabIndex = 3
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(1, 1)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(95, 21)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.Aqua
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox3
			location = New Global.System.Drawing.Point(97, 3)
			checkBox.Location = location
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox3
			size = New Global.System.Drawing.Size(73, 17)
			checkBox2.Size = size
			Me.CheckBox3.TabIndex = 1
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.Aqua
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(173, 0)
			comboBox3.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox4 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(231, 21)
			comboBox4.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(497, 218)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			location = New Global.System.Drawing.Point(0, 220)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(497, 10)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 2
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(497, 253)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Panel1)
			Me.ForeColor = Global.System.Drawing.Color.SlateBlue
			Me.Name = "Cam"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cam"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400007A RID: 122
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
