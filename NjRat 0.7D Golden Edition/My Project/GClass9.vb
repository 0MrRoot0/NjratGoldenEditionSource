Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000034 RID: 52
	<DesignerGenerated()>
	Public NotInheritable Class GClass9
		Inherits ListView

		' Token: 0x060005BB RID: 1467 RVA: 0x00035030 File Offset: 0x00033230
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = GClass9.__ENCList
			SyncLock _ENCList
				If GClass9.__ENCList.Count = GClass9.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = GClass9.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = GClass9.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								GClass9.__ENCList(num) = GClass9.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					GClass9.__ENCList.RemoveRange(num, GClass9.__ENCList.Count - num)
					GClass9.__ENCList.Capacity = GClass9.__ENCList.Count
				End If
				GClass9.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005BC RID: 1468 RVA: 0x00035118 File Offset: 0x00033318
		Public Sub New()
			GClass9.__ENCAddToList(Me)
			AddHandler MyBase.ParentChanged, AddressOf Me.GClass9_ParentChanged
			AddHandler MyBase.MouseMove, AddressOf Me.GClass9_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.GClass9_MouseUp
			AddHandler MyBase.ColumnClick, AddressOf Me.GClass9_ColumnClick
			AddHandler MyBase.KeyDown, AddressOf Me.GClass9_KeyDown
			AddHandler MyBase.MouseDown, AddressOf Me.GClass9_MouseDown
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
			Me.point_1 = Point.Empty
			Me.AllowDrop = False
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.Dock = DockStyle.Fill
			Me.FullRowSelect = True
			Me.View = View.Details
			Me.OwnerDraw = True
			Me.SetStyle(ControlStyles.UserPaint, False)
			Me.DoubleBuffered = True
			Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
		End Sub

		' Token: 0x060005BD RID: 1469 RVA: 0x00003917 File Offset: 0x00001B17
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060005BE RID: 1470 RVA: 0x00003917 File Offset: 0x00001B17
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__4(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060005BF RID: 1471 RVA: 0x00035220 File Offset: 0x00033420
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.icontainer_0 IsNot Nothing Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060005C0 RID: 1472 RVA: 0x00035264 File Offset: 0x00033464
		Public Sub GClass9_ColumnClick(sender As Object, e As ColumnClickEventArgs)
			SyncLock Me
				If e.Column <> -1 Then
					Try
						Dim columnHeader As ColumnHeader = CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), Nothing, "Columns", New Object() { e.Column }, Nothing, Nothing, Nothing), ColumnHeader)
						Dim sortOrder_ As SortOrder
						If Me.columnHeader_0 Is Nothing Then
							sortOrder_ = SortOrder.Ascending
							columnHeader.Tag = "+"
						ElseIf columnHeader.Equals(Me.columnHeader_0) Then
							If Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.columnHeader_0.Tag), "+", False) Then
								sortOrder_ = SortOrder.Descending
								Me.columnHeader_0.Tag = "-"
							Else
								Me.columnHeader_0.Tag = "+"
								sortOrder_ = SortOrder.Ascending
							End If
						Else
							sortOrder_ = SortOrder.Ascending
						End If
						Me.columnHeader_0 = columnHeader
						If Me.columnHeader_0.Tag Is Nothing Then
							Me.columnHeader_0.Tag = "+"
						End If
						If sender IsNot Nothing Then
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { New GClass9.GClass10(e.Column, sortOrder_) }, Nothing, Nothing)
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), Nothing, "Sort", New Object(-1) {}, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { Nothing }, Nothing, Nothing)
						End If
					Catch ex As Exception
					End Try
				End If
			End SyncLock
		End Sub

		' Token: 0x060005C1 RID: 1473 RVA: 0x00035420 File Offset: 0x00033620
		Private Sub GClass9_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Space Then
				Me.method_3()
			End If
			If e.KeyCode = Keys.A And e.Control Then
				Try
					For Each obj As Object In Me.Items
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						listViewItem.Selected = True
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060005C2 RID: 1474 RVA: 0x0000391F File Offset: 0x00001B1F
		Private Sub GClass9_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.listViewItem_0 = Me.GetItemAt(e.X, e.Y)
				Me.point_0 = e.Location
			End If
		End Sub

		' Token: 0x060005C3 RID: 1475 RVA: 0x000354A8 File Offset: 0x000336A8
		Private Sub GClass9_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_1 = e.Location
			If Me.point_0 <> Point.Empty Then
				Dim flag As Boolean
				If Me.listViewItem_0 IsNot Nothing Then
					If Me.listViewItem_0.Index = -1 Then
						flag = True
						GoTo IL_3D
					End If
				End If
				flag = False
				IL_3D:
				If flag Then
					Me.listViewItem_0 = Nothing
				End If
				If(e.Button = MouseButtons.Left And Me.listViewItem_0 IsNot Nothing) AndAlso Me.listViewItem_0 IsNot Nothing Then
					Dim itemAt As ListViewItem = Me.GetItemAt(e.X, e.Y)
					If itemAt IsNot Nothing Then
						If itemAt.Index > Me.listViewItem_0.Index Then
							Dim index As Integer = itemAt.Index
							For i As Integer = Me.listViewItem_0.Index To index
								If Not Me.SelectedIndices.Contains(i) Then
									Me.SelectedIndices.Add(i)
								End If
							Next
							Try
								For Each obj As Object In Me.SelectedIndices
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj)))
									If Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), Me.listViewItem_0.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, False))))) Then
										Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)))
									End If
								Next
								Return
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
						Dim index2 As Integer = Me.listViewItem_0.Index
						For j As Integer = itemAt.Index To index2
							If Not Me.SelectedIndices.Contains(j) Then
								Me.SelectedIndices.Add(j)
							End If
						Next
						Try
							For Each obj2 As Object In Me.SelectedIndices
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj2)))
								If Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), Me.listViewItem_0.Index, False))))) Then
									Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)))
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x060005C4 RID: 1476 RVA: 0x00003954 File Offset: 0x00001B54
		Private Sub GClass9_MouseUp(sender As Object, e As MouseEventArgs)
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
		End Sub

		' Token: 0x060005C5 RID: 1477 RVA: 0x00035770 File Offset: 0x00033970
		Private Sub GClass9_ParentChanged(sender As Object, e As EventArgs)
			Try
				If Me.Parent IsNot Nothing Then
					RemoveHandler Me.Parent.Resize, AddressOf Me.lam__3
				End If
				AddHandler Me.Parent.Resize, AddressOf Me.lam__4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005C6 RID: 1478 RVA: 0x00003968 File Offset: 0x00001B68
		<DebuggerStepThrough()>
		Private Sub method_0()
			Me.icontainer_0 = New Container()
		End Sub

		' Token: 0x060005C7 RID: 1479 RVA: 0x00003975 File Offset: 0x00001B75
		Public Sub method_1()
			Me.method_3()
		End Sub

		' Token: 0x060005C8 RID: 1480 RVA: 0x000357E8 File Offset: 0x000339E8
		Public Function method_2() As ListViewItem()
			Dim result As ListViewItem()
			SyncLock Me
				Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
				If Me.Items.Count = 0 Then
					Return list.ToArray()
				End If
				Try
					Dim listViewItem As ListViewItem = Me.TopItem
					list.Add(listViewItem)
					Dim num As Integer = Me.Items.Count - 1
					For i As Integer = listViewItem.Index + 1 To num
						Try
							listViewItem = Me.Items(i)
							If Not Me.Bounds.IntersectsWith(Me.Items(i).Bounds) Then
								Exit Try
							End If
							list.Add(listViewItem)
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End SyncLock
			Return result
		End Function

		' Token: 0x060005C9 RID: 1481 RVA: 0x00035914 File Offset: 0x00033B14
		Public Sub method_3()
			Try
				If Me.Columns.Count <> 0 Then
					If Me.Items.Count = 0 Then
						Me.Columns(Me.Columns.Count - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
					Else
						Dim num As Integer = Me.Columns.Count - 1
						For i As Integer = 0 To num
							Me.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005CA RID: 1482 RVA: 0x000359C4 File Offset: 0x00033BC4
		Protected Overrides Sub OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0 As DrawListViewColumnHeaderEventArgs)
			Try
				Dim format As StringFormat = New StringFormat() With { .FormatFlags = StringFormatFlags.NoWrap, .Trimming = StringTrimming.EllipsisCharacter, .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }
				Dim rect As Rectangle = New Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(New Pen(ControlPaint.Light(Me.BackColor, 0.1F)).Brush, rect)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Me.Font, New Pen(Me.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(New Pen(Me.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.DrawDefault = False
			Catch ex As Exception
			End Try
			MyBase.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0)
		End Sub

		' Token: 0x060005CB RID: 1483 RVA: 0x0000397D File Offset: 0x00001B7D
		Protected Overrides Sub OnDrawItem(drawListViewItemEventArgs_0 As DrawListViewItemEventArgs)
			drawListViewItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawItem(drawListViewItemEventArgs_0)
		End Sub

		' Token: 0x060005CC RID: 1484 RVA: 0x0000398D File Offset: 0x00001B8D
		Protected Overrides Sub OnDrawSubItem(drawListViewSubItemEventArgs_0 As DrawListViewSubItemEventArgs)
			drawListViewSubItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawSubItem(drawListViewSubItemEventArgs_0)
		End Sub

		' Token: 0x060005CD RID: 1485 RVA: 0x0000399D File Offset: 0x00001B9D
		Protected Overrides Sub OnNotifyMessage(message_0 As Message)
			If message_0.Msg <> 20 Then
				MyBase.OnNotifyMessage(message_0)
			End If
		End Sub

		' Token: 0x04000324 RID: 804
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000325 RID: 805
		Public columnHeader_0 As ColumnHeader

		' Token: 0x04000326 RID: 806
		Private icontainer_0 As IContainer

		' Token: 0x04000327 RID: 807
		Private listViewItem_0 As ListViewItem

		' Token: 0x04000328 RID: 808
		Private point_0 As Point

		' Token: 0x04000329 RID: 809
		Private point_1 As Point

		' Token: 0x02000035 RID: 53
		Public NotInheritable Class GClass10
			Implements IComparer

			' Token: 0x060005CE RID: 1486 RVA: 0x000039B6 File Offset: 0x00001BB6
			Public Sub New(int_1 As Integer, sortOrder_1 As SortOrder)
				Me.int_0 = int_1
				Me.sortOrder_0 = sortOrder_1
			End Sub

			' Token: 0x060005CF RID: 1487 RVA: 0x00035B44 File Offset: 0x00033D44
			Public Function Compare(object_0 As Object, object_1 As Object) As Integer
				Dim listViewItem As ListViewItem = CType(object_0, ListViewItem)
				Dim listViewItem2 As ListViewItem = CType(object_1, ListViewItem)
				Dim text As String
				If listViewItem.SubItems.Count <= Me.int_0 Then
					text = String.Empty
				Else
					text = listViewItem.SubItems(Me.int_0).Text
				End If
				Dim text2 As String
				If listViewItem2.SubItems.Count <= Me.int_0 Then
					text2 = String.Empty
				Else
					text2 = listViewItem2.SubItems(Me.int_0).Text
				End If
				Dim result As Integer
				If Me.sortOrder_0 = SortOrder.Ascending Then
					If Versioned.IsNumeric(text) And Versioned.IsNumeric(text2) Then
						result = Conversion.Val(text).CompareTo(Conversion.Val(text2))
					ElseIf Information.IsDate(text) And Information.IsDate(text2) Then
						result = DateTime.Parse(text).CompareTo(DateTime.Parse(text2))
					Else
						result = String.Compare(text, text2)
					End If
				ElseIf Versioned.IsNumeric(text) And Versioned.IsNumeric(text2) Then
					result = Conversion.Val(text2).CompareTo(Conversion.Val(text))
				ElseIf Information.IsDate(text) And Information.IsDate(text2) Then
					result = DateTime.Parse(text2).CompareTo(DateTime.Parse(text))
				Else
					result = String.Compare(text2, text)
				End If
				Return result
			End Function

			' Token: 0x060005D0 RID: 1488 RVA: 0x000039CC File Offset: 0x00001BCC
			Public Function Compare1(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Return 0
			End Function

			' Token: 0x0400032A RID: 810
			Private int_0 As Integer

			' Token: 0x0400032B RID: 811
			Private sortOrder_0 As SortOrder
		End Class
	End Class
End Namespace
