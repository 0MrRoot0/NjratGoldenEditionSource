Namespace NJRAT
	' Token: 0x02000023 RID: 35
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class STNG
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600050B RID: 1291 RVA: 0x000293A4 File Offset: 0x000275A4
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

		' Token: 0x0600050C RID: 1292 RVA: 0x000293E8 File Offset: 0x000275E8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.ShowAlert = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.LOGLOGIN = New Global.System.Windows.Forms.CheckBox()
			Me.LOGCONNECTIONS = New Global.System.Windows.Forms.CheckBox()
			Me.LOGLERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGRERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGMSGS = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SCI = New Global.System.Windows.Forms.ComboBox()
			Me.SCAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.CAMI = New Global.System.Windows.Forms.ComboBox()
			Me.CAMAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.MICI = New Global.System.Windows.Forms.ComboBox()
			Me.MICAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.scrI = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox6.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.ShowAlert)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(124, 104)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(117, 31)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "OnLogin"
			Me.ShowAlert.AutoSize = True
			Me.ShowAlert.ForeColor = Global.System.Drawing.Color.Aqua
			Dim showAlert As Global.System.Windows.Forms.Control = Me.ShowAlert
			location = New Global.System.Drawing.Point(6, 11)
			showAlert.Location = location
			Me.ShowAlert.Name = "ShowAlert"
			Me.ShowAlert.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim showAlert2 As Global.System.Windows.Forms.Control = Me.ShowAlert
			size = New Global.System.Drawing.Size(77, 17)
			showAlert2.Size = size
			Me.ShowAlert.TabIndex = 0
			Me.ShowAlert.Text = "Show Alert"
			Me.ShowAlert.UseVisualStyleBackColor = True
			Me.GroupBox2.Controls.Add(Me.LOGLOGIN)
			Me.GroupBox2.Controls.Add(Me.LOGCONNECTIONS)
			Me.GroupBox2.Controls.Add(Me.LOGLERR)
			Me.GroupBox2.Controls.Add(Me.LOGRERR)
			Me.GroupBox2.Controls.Add(Me.LOGMSGS)
			Me.GroupBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(124, 1)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(117, 101)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Logs"
			Me.LOGLOGIN.AutoSize = True
			Me.LOGLOGIN.ForeColor = Global.System.Drawing.Color.Aqua
			Dim loglogin As Global.System.Windows.Forms.Control = Me.LOGLOGIN
			location = New Global.System.Drawing.Point(5, 14)
			loglogin.Location = location
			Me.LOGLOGIN.Name = "LOGLOGIN"
			Me.LOGLOGIN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim loglogin2 As Global.System.Windows.Forms.Control = Me.LOGLOGIN
			size = New Global.System.Drawing.Size(74, 17)
			loglogin2.Size = size
			Me.LOGLOGIN.TabIndex = 5
			Me.LOGLOGIN.Text = "Login/Out"
			Me.LOGLOGIN.UseVisualStyleBackColor = True
			Me.LOGCONNECTIONS.AutoSize = True
			Me.LOGCONNECTIONS.ForeColor = Global.System.Drawing.Color.Aqua
			Dim logconnections As Global.System.Windows.Forms.Control = Me.LOGCONNECTIONS
			location = New Global.System.Drawing.Point(5, 30)
			logconnections.Location = location
			Me.LOGCONNECTIONS.Name = "LOGCONNECTIONS"
			Me.LOGCONNECTIONS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logconnections2 As Global.System.Windows.Forms.Control = Me.LOGCONNECTIONS
			size = New Global.System.Drawing.Size(85, 17)
			logconnections2.Size = size
			Me.LOGCONNECTIONS.TabIndex = 4
			Me.LOGCONNECTIONS.Text = "Connections"
			Me.LOGCONNECTIONS.UseVisualStyleBackColor = True
			Me.LOGLERR.AutoSize = True
			Me.LOGLERR.ForeColor = Global.System.Drawing.Color.Aqua
			Dim loglerr As Global.System.Windows.Forms.Control = Me.LOGLERR
			location = New Global.System.Drawing.Point(5, 46)
			loglerr.Location = location
			Me.LOGLERR.Name = "LOGLERR"
			Me.LOGLERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim loglerr2 As Global.System.Windows.Forms.Control = Me.LOGLERR
			size = New Global.System.Drawing.Size(87, 17)
			loglerr2.Size = size
			Me.LOGLERR.TabIndex = 3
			Me.LOGLERR.Text = "Listner Errors"
			Me.LOGLERR.UseVisualStyleBackColor = True
			Me.LOGRERR.AutoSize = True
			Me.LOGRERR.ForeColor = Global.System.Drawing.Color.Aqua
			Dim logrerr As Global.System.Windows.Forms.Control = Me.LOGRERR
			location = New Global.System.Drawing.Point(5, 63)
			logrerr.Location = location
			Me.LOGRERR.Name = "LOGRERR"
			Me.LOGRERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logrerr2 As Global.System.Windows.Forms.Control = Me.LOGRERR
			size = New Global.System.Drawing.Size(93, 17)
			logrerr2.Size = size
			Me.LOGRERR.TabIndex = 2
			Me.LOGRERR.Text = "Remote Errors"
			Me.LOGRERR.UseVisualStyleBackColor = True
			Me.LOGMSGS.AutoSize = True
			Me.LOGMSGS.ForeColor = Global.System.Drawing.Color.Aqua
			Dim logmsgs As Global.System.Windows.Forms.Control = Me.LOGMSGS
			location = New Global.System.Drawing.Point(5, 80)
			logmsgs.Location = location
			Me.LOGMSGS.Name = "LOGMSGS"
			Me.LOGMSGS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logmsgs2 As Global.System.Windows.Forms.Control = Me.LOGMSGS
			size = New Global.System.Drawing.Size(74, 17)
			logmsgs2.Size = size
			Me.LOGMSGS.TabIndex = 1
			Me.LOGMSGS.Text = "Messages"
			Me.LOGMSGS.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.Label1)
			Me.GroupBox3.Controls.Add(Me.SCI)
			Me.GroupBox3.Controls.Add(Me.SCAUT)
			Me.GroupBox3.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(3, 1)
			groupBox5.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(115, 64)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 2
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Remote Desktop"
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(6, 39)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(27, 13)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Size"
			Me.SCI.BackColor = Global.System.Drawing.Color.Black
			Me.SCI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.SCI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.SCI.ForeColor = Global.System.Drawing.Color.Aqua
			Me.SCI.FormattingEnabled = True
			Me.SCI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim sci As Global.System.Windows.Forms.Control = Me.SCI
			location = New Global.System.Drawing.Point(38, 36)
			sci.Location = location
			Me.SCI.Name = "SCI"
			Dim sci2 As Global.System.Windows.Forms.Control = Me.SCI
			size = New Global.System.Drawing.Size(71, 21)
			sci2.Size = size
			Me.SCI.TabIndex = 2
			Me.SCAUT.AutoSize = True
			Me.SCAUT.ForeColor = Global.System.Drawing.Color.Aqua
			Dim scaut As Global.System.Windows.Forms.Control = Me.SCAUT
			location = New Global.System.Drawing.Point(6, 19)
			scaut.Location = location
			Me.SCAUT.Name = "SCAUT"
			Me.SCAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim scaut2 As Global.System.Windows.Forms.Control = Me.SCAUT
			size = New Global.System.Drawing.Size(70, 17)
			scaut2.Size = size
			Me.SCAUT.TabIndex = 1
			Me.SCAUT.Text = "AutoStart"
			Me.SCAUT.UseVisualStyleBackColor = True
			Me.GroupBox4.Controls.Add(Me.Label2)
			Me.GroupBox4.Controls.Add(Me.CAMI)
			Me.GroupBox4.Controls.Add(Me.CAMAUT)
			Me.GroupBox4.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(3, 68)
			groupBox7.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(115, 64)
			groupBox8.Size = size
			Me.GroupBox4.TabIndex = 3
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Remote Cam"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Global.System.Drawing.Color.Aqua
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(6, 39)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(27, 13)
			label4.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Size"
			Me.CAMI.BackColor = Global.System.Drawing.Color.Black
			Me.CAMI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.CAMI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CAMI.ForeColor = Global.System.Drawing.Color.Aqua
			Me.CAMI.FormattingEnabled = True
			Me.CAMI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim cami As Global.System.Windows.Forms.Control = Me.CAMI
			location = New Global.System.Drawing.Point(38, 36)
			cami.Location = location
			Me.CAMI.Name = "CAMI"
			Dim cami2 As Global.System.Windows.Forms.Control = Me.CAMI
			size = New Global.System.Drawing.Size(71, 21)
			cami2.Size = size
			Me.CAMI.TabIndex = 2
			Me.CAMAUT.AutoSize = True
			Me.CAMAUT.ForeColor = Global.System.Drawing.Color.Aqua
			Dim camaut As Global.System.Windows.Forms.Control = Me.CAMAUT
			location = New Global.System.Drawing.Point(6, 19)
			camaut.Location = location
			Me.CAMAUT.Name = "CAMAUT"
			Me.CAMAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim camaut2 As Global.System.Windows.Forms.Control = Me.CAMAUT
			size = New Global.System.Drawing.Size(70, 17)
			camaut2.Size = size
			Me.CAMAUT.TabIndex = 1
			Me.CAMAUT.Text = "AutoStart"
			Me.CAMAUT.UseVisualStyleBackColor = True
			Me.GroupBox5.Controls.Add(Me.MICI)
			Me.GroupBox5.Controls.Add(Me.MICAUT)
			Me.GroupBox5.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox5
			location = New Global.System.Drawing.Point(3, 135)
			groupBox9.Location = location
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(115, 64)
			groupBox10.Size = size
			Me.GroupBox5.TabIndex = 4
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Remote MIC"
			Me.MICI.BackColor = Global.System.Drawing.Color.Black
			Me.MICI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.MICI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.MICI.ForeColor = Global.System.Drawing.Color.Aqua
			Me.MICI.FormattingEnabled = True
			Me.MICI.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Dim mici As Global.System.Windows.Forms.Control = Me.MICI
			location = New Global.System.Drawing.Point(6, 36)
			mici.Location = location
			Me.MICI.Name = "MICI"
			Dim mici2 As Global.System.Windows.Forms.Control = Me.MICI
			size = New Global.System.Drawing.Size(103, 21)
			mici2.Size = size
			Me.MICI.TabIndex = 2
			Me.MICAUT.AutoSize = True
			Me.MICAUT.ForeColor = Global.System.Drawing.Color.Aqua
			Dim micaut As Global.System.Windows.Forms.Control = Me.MICAUT
			location = New Global.System.Drawing.Point(6, 19)
			micaut.Location = location
			Me.MICAUT.Name = "MICAUT"
			Me.MICAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim micaut2 As Global.System.Windows.Forms.Control = Me.MICAUT
			size = New Global.System.Drawing.Size(70, 17)
			micaut2.Size = size
			Me.MICAUT.TabIndex = 1
			Me.MICAUT.Text = "AutoStart"
			Me.MICAUT.UseVisualStyleBackColor = True
			Me.GroupBox6.Controls.Add(Me.Label3)
			Me.GroupBox6.Controls.Add(Me.scrI)
			Me.GroupBox6.ForeColor = Global.System.Drawing.Color.Aqua
			Dim groupBox11 As Global.System.Windows.Forms.Control = Me.GroupBox6
			location = New Global.System.Drawing.Point(124, 135)
			groupBox11.Location = location
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox12 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(117, 64)
			groupBox12.Size = size
			Me.GroupBox6.TabIndex = 5
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "Screen"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.Aqua
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(5, 14)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(89, 14)
			label6.Size = size
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Refresh Speed"
			Me.scrI.BackColor = Global.System.Drawing.Color.Black
			Me.scrI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.scrI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.scrI.ForeColor = Global.System.Drawing.Color.Aqua
			Me.scrI.FormattingEnabled = True
			Me.scrI.Items.AddRange(New Object() { "Ultra", "Fast", "Good", "Slow", "Slower" })
			Dim scrI As Global.System.Windows.Forms.Control = Me.scrI
			location = New Global.System.Drawing.Point(6, 36)
			scrI.Location = location
			Me.scrI.Name = "scrI"
			Me.scrI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim scrI2 As Global.System.Windows.Forms.Control = Me.scrI
			size = New Global.System.Drawing.Size(105, 21)
			scrI2.Size = size
			Me.scrI.TabIndex = 2
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.Aqua
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(3, 204)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(238, 32)
			button2.Size = size
			Me.Button1.TabIndex = 6
			Me.Button1.Text = "Save"
			Me.Button1.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(244, 241)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox6)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.GroupBox5)
			Me.Controls.Add(Me.GroupBox4)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.ForeColor = Global.System.Drawing.Color.White
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "STNG"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Settings"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400025F RID: 607
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
