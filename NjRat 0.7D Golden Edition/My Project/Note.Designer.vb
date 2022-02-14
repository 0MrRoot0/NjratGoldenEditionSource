Namespace NJRAT
	' Token: 0x02000018 RID: 24
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Note
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000355 RID: 853 RVA: 0x0001D360 File Offset: 0x0001B560
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

		' Token: 0x06000356 RID: 854 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Note))
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Me.MenuStrip1.LayoutStyle = Global.System.Windows.Forms.ToolStripLayoutStyle.Flow
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(629, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.Aqua
			Me.ToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(113, 20)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "Save Changes"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.Yellow
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(0, 24)
			textBox.Location = location
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(629, 204)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(629, 228)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Note"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Note"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000191 RID: 401
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
