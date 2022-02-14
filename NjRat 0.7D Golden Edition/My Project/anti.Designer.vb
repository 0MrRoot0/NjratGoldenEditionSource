Namespace NJRAT
	' Token: 0x02000009 RID: 9
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class anti
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000074 RID: 116 RVA: 0x000050AC File Offset: 0x000032AC
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

		' Token: 0x06000075 RID: 117 RVA: 0x000050F0 File Offset: 0x000032F0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.anti))
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.NDDelay = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.btnAtualizar = New Global.System.Windows.Forms.Button()
			Me.LVListProcess = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.CM = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.AdicionarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.IM = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.btnCriar = New Global.System.Windows.Forms.Button()
			Me.LVProcess = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.CM1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ExcluirToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtNomeProcess = New Global.System.Windows.Forms.TextBox()
			Me.btnAdicionar = New Global.System.Windows.Forms.Button()
			Me.CKAtivarStartUp = New Global.System.Windows.Forms.CheckBox()
			Me.txtNomeStartUp = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			CType(Me.NDDelay, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.CM.SuspendLayout()
			Me.CM1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.NDDelay)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.btnAtualizar)
			Me.GroupBox1.Controls.Add(Me.LVListProcess)
			Me.GroupBox1.Controls.Add(Me.btnCriar)
			Me.GroupBox1.Controls.Add(Me.LVProcess)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtNomeProcess)
			Me.GroupBox1.Controls.Add(Me.btnAdicionar)
			Me.GroupBox1.Controls.Add(Me.CKAtivarStartUp)
			Me.GroupBox1.Controls.Add(Me.txtNomeStartUp)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Segoe UI", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 54)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(684, 474)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Configuration"
			Me.NDDelay.BackColor = Global.System.Drawing.Color.Black
			Me.NDDelay.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.NDDelay.ForeColor = Global.System.Drawing.Color.White
			Dim nddelay As Global.System.Windows.Forms.NumericUpDown = Me.NDDelay
			Dim num As Decimal = New Decimal(New Integer() { 2, 0, 0, 0 })
			nddelay.Increment = num
			Dim nddelay2 As Global.System.Windows.Forms.Control = Me.NDDelay
			location = New Global.System.Drawing.Point(6, 370)
			nddelay2.Location = location
			Dim nddelay3 As Global.System.Windows.Forms.NumericUpDown = Me.NDDelay
			num = New Decimal(New Integer() { 1874919423, 2328306, 0, 0 })
			nddelay3.Maximum = num
			Dim nddelay4 As Global.System.Windows.Forms.NumericUpDown = Me.NDDelay
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			nddelay4.Minimum = num
			Me.NDDelay.Name = "NDDelay"
			Dim nddelay5 As Global.System.Windows.Forms.Control = Me.NDDelay
			size = New Global.System.Drawing.Size(142, 22)
			nddelay5.Size = size
			Me.NDDelay.TabIndex = 10
			Me.NDDelay.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Dim nddelay6 As Global.System.Windows.Forms.NumericUpDown = Me.NDDelay
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			nddelay6.Value = num
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.Yellow
			Dim label As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(4, 348)
			label.Location = location
			Me.Label2.Name = "Label2"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(144, 17)
			label2.Size = size
			Me.Label2.TabIndex = 9
			Me.Label2.Text = "Chreck Process Every :"
			Me.btnAtualizar.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.btnAtualizar.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnAtualizar.ForeColor = Global.System.Drawing.Color.DarkCyan
			Dim btnAtualizar As Global.System.Windows.Forms.Control = Me.btnAtualizar
			location = New Global.System.Drawing.Point(396, 297)
			btnAtualizar.Location = location
			Me.btnAtualizar.Name = "btnAtualizar"
			Dim btnAtualizar2 As Global.System.Windows.Forms.Control = Me.btnAtualizar
			size = New Global.System.Drawing.Size(284, 48)
			btnAtualizar2.Size = size
			Me.btnAtualizar.TabIndex = 7
			Me.btnAtualizar.Text = "Refraich"
			Me.btnAtualizar.UseVisualStyleBackColor = True
			Me.LVListProcess.BackColor = Global.System.Drawing.Color.Black
			Me.LVListProcess.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.LVListProcess.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader2 })
			Me.LVListProcess.ContextMenuStrip = Me.CM
			Me.LVListProcess.ForeColor = Global.System.Drawing.Color.White
			Me.LVListProcess.FullRowSelect = True
			Me.LVListProcess.GridLines = True
			Dim lvlistProcess As Global.System.Windows.Forms.Control = Me.LVListProcess
			location = New Global.System.Drawing.Point(396, 16)
			lvlistProcess.Location = location
			Me.LVListProcess.Name = "LVListProcess"
			Dim lvlistProcess2 As Global.System.Windows.Forms.Control = Me.LVListProcess
			size = New Global.System.Drawing.Size(284, 273)
			lvlistProcess2.Size = size
			Me.LVListProcess.SmallImageList = Me.IM
			Me.LVListProcess.TabIndex = 6
			Me.LVListProcess.UseCompatibleStateImageBehavior = False
			Me.LVListProcess.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader2.Text = "Process List"
			Me.ColumnHeader2.Width = 265
			Me.CM.BackColor = Global.System.Drawing.Color.Black
			Dim cm As Global.System.Windows.Forms.ToolStrip = Me.CM
			size = New Global.System.Drawing.Size(18, 18)
			cm.ImageScalingSize = size
			Me.CM.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.AdicionarToolStripMenuItem })
			Me.CM.Name = "CM"
			Me.CM.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim cm2 As Global.System.Windows.Forms.Control = Me.CM
			size = New Global.System.Drawing.Size(99, 28)
			cm2.Size = size
			Me.AdicionarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.White
			Me.AdicionarToolStripMenuItem.Image = CType(componentResourceManager.GetObject("AdicionarToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
			Dim adicionarToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AdicionarToolStripMenuItem
			size = New Global.System.Drawing.Size(98, 24)
			adicionarToolStripMenuItem.Size = size
			Me.AdicionarToolStripMenuItem.Text = "Add"
			Me.IM.ImageStream = CType(componentResourceManager.GetObject("IM.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.IM.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.IM.Images.SetKeyName(0, "215.png")
			Me.btnCriar.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.btnCriar.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnCriar.Font = New Global.System.Drawing.Font("Segoe UI", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCriar.ForeColor = Global.System.Drawing.Color.DarkCyan
			Dim btnCriar As Global.System.Windows.Forms.Control = Me.btnCriar
			location = New Global.System.Drawing.Point(6, 398)
			btnCriar.Location = location
			Me.btnCriar.Name = "btnCriar"
			Dim btnCriar2 As Global.System.Windows.Forms.Control = Me.btnCriar
			size = New Global.System.Drawing.Size(674, 68)
			btnCriar2.Size = size
			Me.btnCriar.TabIndex = 5
			Me.btnCriar.Text = "Build Server"
			Me.btnCriar.UseVisualStyleBackColor = True
			Me.LVProcess.BackColor = Global.System.Drawing.Color.Black
			Me.LVProcess.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.LVProcess.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1 })
			Me.LVProcess.ContextMenuStrip = Me.CM1
			Me.LVProcess.ForeColor = Global.System.Drawing.Color.White
			Me.LVProcess.FullRowSelect = True
			Me.LVProcess.GridLines = True
			Dim lvprocess As Global.System.Windows.Forms.Control = Me.LVProcess
			location = New Global.System.Drawing.Point(5, 16)
			lvprocess.Location = location
			Me.LVProcess.Name = "LVProcess"
			Dim lvprocess2 As Global.System.Windows.Forms.Control = Me.LVProcess
			size = New Global.System.Drawing.Size(385, 273)
			lvprocess2.Size = size
			Me.LVProcess.SmallImageList = Me.IM
			Me.LVProcess.TabIndex = 0
			Me.LVProcess.UseCompatibleStateImageBehavior = False
			Me.LVProcess.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Text = "Process"
			Me.ColumnHeader1.Width = 363
			Me.CM1.BackColor = Global.System.Drawing.Color.Black
			Dim cm3 As Global.System.Windows.Forms.ToolStrip = Me.CM1
			size = New Global.System.Drawing.Size(18, 18)
			cm3.ImageScalingSize = size
			Me.CM1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ExcluirToolStripMenuItem })
			Me.CM1.Name = "CM1"
			Me.CM1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim cm4 As Global.System.Windows.Forms.Control = Me.CM1
			size = New Global.System.Drawing.Size(110, 28)
			cm4.Size = size
			Me.ExcluirToolStripMenuItem.ForeColor = Global.System.Drawing.Color.White
			Me.ExcluirToolStripMenuItem.Image = CType(componentResourceManager.GetObject("ExcluirToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
			Dim excluirToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExcluirToolStripMenuItem
			size = New Global.System.Drawing.Size(109, 24)
			excluirToolStripMenuItem.Size = size
			Me.ExcluirToolStripMenuItem.Text = "Delete"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(4, 298)
			label3.Location = location
			Me.Label1.Name = "Label1"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(233, 17)
			label4.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Name (Process) > ex : processhacker"
			Me.txtNomeProcess.BackColor = Global.System.Drawing.Color.Black
			Me.txtNomeProcess.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtNomeProcess.ForeColor = Global.System.Drawing.Color.White
			Dim txtNomeProcess As Global.System.Windows.Forms.Control = Me.txtNomeProcess
			location = New Global.System.Drawing.Point(6, 323)
			txtNomeProcess.Location = location
			Me.txtNomeProcess.Name = "txtNomeProcess"
			Dim txtNomeProcess2 As Global.System.Windows.Forms.Control = Me.txtNomeProcess
			size = New Global.System.Drawing.Size(384, 22)
			txtNomeProcess2.Size = size
			Me.txtNomeProcess.TabIndex = 3
			Me.btnAdicionar.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.btnAdicionar.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnAdicionar.ForeColor = Global.System.Drawing.Color.DarkCyan
			Dim btnAdicionar As Global.System.Windows.Forms.Control = Me.btnAdicionar
			location = New Global.System.Drawing.Point(273, 353)
			btnAdicionar.Location = location
			Me.btnAdicionar.Name = "btnAdicionar"
			Dim btnAdicionar2 As Global.System.Windows.Forms.Control = Me.btnAdicionar
			size = New Global.System.Drawing.Size(117, 39)
			btnAdicionar2.Size = size
			Me.btnAdicionar.TabIndex = 2
			Me.btnAdicionar.Text = "Add"
			Me.btnAdicionar.UseVisualStyleBackColor = True
			Me.CKAtivarStartUp.AutoSize = True
			Me.CKAtivarStartUp.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.CKAtivarStartUp.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.CKAtivarStartUp.ForeColor = Global.System.Drawing.Color.Red
			Dim ckativarStartUp As Global.System.Windows.Forms.Control = Me.CKAtivarStartUp
			location = New Global.System.Drawing.Point(396, 348)
			ckativarStartUp.Location = location
			Me.CKAtivarStartUp.Name = "CKAtivarStartUp"
			Dim ckativarStartUp2 As Global.System.Windows.Forms.Control = Me.CKAtivarStartUp
			size = New Global.System.Drawing.Size(123, 21)
			ckativarStartUp2.Size = size
			Me.CKAtivarStartUp.TabIndex = 1
			Me.CKAtivarStartUp.Text = "Copy In Startup"
			Me.CKAtivarStartUp.UseVisualStyleBackColor = True
			Me.txtNomeStartUp.BackColor = Global.System.Drawing.Color.Black
			Me.txtNomeStartUp.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtNomeStartUp.Enabled = False
			Me.txtNomeStartUp.ForeColor = Global.System.Drawing.Color.White
			Dim txtNomeStartUp As Global.System.Windows.Forms.Control = Me.txtNomeStartUp
			location = New Global.System.Drawing.Point(396, 370)
			txtNomeStartUp.Location = location
			Me.txtNomeStartUp.Name = "txtNomeStartUp"
			Dim txtNomeStartUp2 As Global.System.Windows.Forms.Control = Me.txtNomeStartUp
			size = New Global.System.Drawing.Size(284, 22)
			txtNomeStartUp2.Size = size
			Me.txtNomeStartUp.TabIndex = 8
			Me.txtNomeStartUp.Text = "Dllhost"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(158, 375)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(59, 17)
			label6.Size = size
			Me.Label3.TabIndex = 11
			Me.Label3.Text = "Seconde"
			Me.Label4.AutoSize = True
			Me.Label4.ForeColor = Global.System.Drawing.Color.Coral
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(-25, 38)
			label7.Location = location
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(751, 13)
			label8.Size = size
			Me.Label4.TabIndex = 2
			Me.Label4.Text = "____________________________________________________________________________________________________________________________"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 18F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(12, 9)
			label9.Location = location
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(228, 29)
			label10.Size = size
			Me.Label5.TabIndex = 5
			Me.Label5.Text = "Build Anti-Process"
			Me.Button2.BackColor = Global.System.Drawing.Color.Gray
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(538, 6)
			button.Location = location
			Me.Button2.Name = "Button2"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(67, 39)
			button2.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.Text = "_"
			Me.Button2.UseVisualStyleBackColor = False
			Me.Button1.BackColor = Global.System.Drawing.Color.Red
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.White
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(611, 6)
			button3.Location = location
			Me.Button1.Name = "Button1"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(81, 39)
			button4.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.Text = "X"
			Me.Button1.UseVisualStyleBackColor = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(701, 543)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ForeColor = Global.System.Drawing.Color.White
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.MaximizeBox = False
			Me.Name = "anti"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Anti Process"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.NDDelay, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.CM.ResumeLayout(False)
			Me.CM1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000033 RID: 51
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
