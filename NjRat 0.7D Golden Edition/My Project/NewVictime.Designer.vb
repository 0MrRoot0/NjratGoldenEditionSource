Namespace NJRAT
	' Token: 0x02000019 RID: 25
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class NewVictime
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000361 RID: 865 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
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

		' Token: 0x06000362 RID: 866 RVA: 0x0001D91C File Offset: 0x0001BB1C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.p.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.p.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim p As Global.System.Windows.Forms.Control = Me.p
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			p.Location = location
			Me.p.Name = "p"
			Dim p2 As Global.System.Windows.Forms.Control = Me.p
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(267, 109)
			p2.Size = size
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 0
			Me.p.TabStop = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(267, 109)
			Me.ClientSize = size
			Me.Controls.Add(Me.p)
			Me.ForeColor = Global.System.Drawing.Color.Cyan
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Name = "notf"
			Me.Opacity = 0.8
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.Text = "notf"
			Me.TopMost = True
			Me.TransparencyKey = Global.System.Drawing.Color.Transparent
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000198 RID: 408
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
