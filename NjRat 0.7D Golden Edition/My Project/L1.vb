Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000036 RID: 54
	Public NotInheritable Class L1
		Inherits DataGridView

		' Token: 0x060005D2 RID: 1490 RVA: 0x00035C94 File Offset: 0x00033E94
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = L1.__ENCList
			SyncLock _ENCList
				If L1.__ENCList.Count = L1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = L1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = L1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								L1.__ENCList(num) = L1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					L1.__ENCList.RemoveRange(num, L1.__ENCList.Count - num)
					L1.__ENCList.Capacity = L1.__ENCList.Count
				End If
				L1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005D3 RID: 1491 RVA: 0x00035D7C File Offset: 0x00033F7C
		Public Sub New()
			L1.__ENCAddToList(Me)
			Me.collection_0 = New Collection()
			Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			Me.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]
			Me.RowHeadersVisible = False
			Me.DoubleBuffered = True
			Me.ShowCellErrors = True
			Me.ShowEditingIcon = True
			Me.ShowRowErrors = True
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.EnableNotifyMessage Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub

		' Token: 0x060005D4 RID: 1492 RVA: 0x00035E00 File Offset: 0x00034000
		Public Function method_0(int_0 As Integer) As DataGridViewRow
			Return CType(Me.collection_0(int_0 + 1), DataGridViewRow)
		End Function

		' Token: 0x060005D5 RID: 1493 RVA: 0x00035E24 File Offset: 0x00034024
		Public Function method_1(string_0 As String) As DataGridViewRow
			Return CType(Me.collection_0(string_0), DataGridViewRow)
		End Function

		' Token: 0x060005D6 RID: 1494 RVA: 0x00035E44 File Offset: 0x00034044
		Public Sub method_10(int_0 As Integer)
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_10, New Object() { int_0 })
					Return
				End SyncLock
			End If
			Me.Rows.RemoveAt(int_0)
		End Sub

		' Token: 0x060005D7 RID: 1495 RVA: 0x00035EB4 File Offset: 0x000340B4
		Public Sub method_11(string_0 As String, genum0_0 As L1.GEnum0, dataGridViewAutoSizeColumnMode_0 As DataGridViewAutoSizeColumnMode)
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Dim dataGridViewColumn As DataGridViewColumn = Nothing
				Select Case genum0_0
					Case L1.GEnum0.Text
						dataGridViewColumn = New DataGridViewTextBoxColumn()
					Case L1.GEnum0.Link
						dataGridViewColumn = New DataGridViewLinkColumn()
					Case L1.GEnum0.Image
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewColumn = dataGridViewImageColumn
					Case L1.GEnum0.StretchImage
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewColumn = dataGridViewImageColumn
				End Select
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0
				dataGridViewColumn.Tag = genum0_0
				dataGridViewColumn.HeaderText = string_0
				Me.Columns.Add(dataGridViewColumn)
			End SyncLock
		End Sub

		' Token: 0x060005D8 RID: 1496 RVA: 0x000039DB File Offset: 0x00001BDB
		Public Function method_2(string_0 As String) As Boolean
			Return Me.collection_0.Contains(string_0)
		End Function

		' Token: 0x060005D9 RID: 1497 RVA: 0x00035F6C File Offset: 0x0003416C
		Public Function method_3() As DataGridViewRow()
			Dim list As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
			Dim result As DataGridViewRow()
			If Me.RowCount = 0 Then
				result = list.ToArray()
			Else
				Try
					Dim num As Integer = Me.FirstDisplayedScrollingRowIndex + Me.DisplayedRowCount(False)
					For i As Integer = Me.FirstDisplayedScrollingRowIndex To num
						If i > Me.RowCount - 1 Then
							Exit For
						End If
						Try
							list.Add(Me.Rows(i))
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End If
			Return result
		End Function

		' Token: 0x060005DA RID: 1498 RVA: 0x0003603C File Offset: 0x0003423C
		Public Sub method_4()
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Me.Rows.Clear()
				Me.collection_0.Clear()
			End SyncLock
		End Sub

		' Token: 0x060005DB RID: 1499 RVA: 0x00036088 File Offset: 0x00034288
		Public Function method_5(object_0 As Object()) As DataGridViewRow
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_5, object_0), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow()
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Normal }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, Nothing, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060005DC RID: 1500 RVA: 0x00036254 File Offset: 0x00034454
		Public Function method_6() As Integer
			Return Me.RowTemplate.Height
		End Function

		' Token: 0x060005DD RID: 1501 RVA: 0x000039E9 File Offset: 0x00001BE9
		Public Sub method_7(int_0 As Integer)
			Me.RowTemplate.Height = int_0
		End Sub

		' Token: 0x060005DE RID: 1502 RVA: 0x00036270 File Offset: 0x00034470
		Public Function method_8(string_0 As String, object_0 As Object()) As DataGridViewRow
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_8, New Object() { string_0, object_0 }), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow() With { .Height = Me.method_6() }
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, string_0, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060005DF RID: 1503 RVA: 0x00036464 File Offset: 0x00034664
		Public Sub method_9(dataGridViewRow_0 As DataGridViewRow)
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_9, New Object() { dataGridViewRow_0 })
					Return
				End SyncLock
			End If
			Me.Rows.Remove(dataGridViewRow_0)
		End Sub

		' Token: 0x060005E0 RID: 1504 RVA: 0x000364D0 File Offset: 0x000346D0
		Protected Overrides Sub OnMouseUp(mouseEventArgs_0 As MouseEventArgs)
			If mouseEventArgs_0.Button = MouseButtons.Right Then
				Try
					Dim hitTestInfo As DataGridView.HitTestInfo = Me.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y)
					If hitTestInfo.RowIndex <> -1 Then
						Dim dataGridViewRow As DataGridViewRow = Me.Rows(hitTestInfo.RowIndex)
						If Not dataGridViewRow.Selected Then
							Me.ClearSelection()
							dataGridViewRow.Selected = True
						End If
					End If
				Catch ex As Exception
				End Try
			End If
			MyBase.OnMouseUp(mouseEventArgs_0)
		End Sub

		' Token: 0x060005E1 RID: 1505 RVA: 0x0003656C File Offset: 0x0003476C
		Protected Overrides Sub OnMouseWheel(mouseEventArgs_0 As MouseEventArgs)
			MyBase.OnMouseWheel(mouseEventArgs_0)
			Try
				Dim delta As Integer = mouseEventArgs_0.Delta
				If delta = 120 Then
					Me.FirstDisplayedScrollingRowIndex = Math.Max(0, Me.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines)
				ElseIf delta = -120 Then
					Me.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005E2 RID: 1506 RVA: 0x000365EC File Offset: 0x000347EC
		Protected Overrides Sub OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0 As DataGridViewRowPostPaintEventArgs)
			Try
				Dim dataGridViewRow As DataGridViewRow = Me.Rows(dataGridViewRowPostPaintEventArgs_0.RowIndex)
				If dataGridViewRow.Height <> Me.method_6() Then
					dataGridViewRow.Height = Me.method_6()
				End If
			Catch ex As Exception
			End Try
			MyBase.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0)
		End Sub

		' Token: 0x0400032C RID: 812
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400032D RID: 813
		Private collection_0 As Collection

		' Token: 0x02000037 RID: 55
		' (Invoke) Token: 0x060005E6 RID: 1510
		Private Delegate Function Delegate1(object_0 As Object()) As DataGridViewRow

		' Token: 0x02000038 RID: 56
		' (Invoke) Token: 0x060005EA RID: 1514
		Private Delegate Function Delegate2(string_0 As String, object_0 As Object()) As DataGridViewRow

		' Token: 0x02000039 RID: 57
		' (Invoke) Token: 0x060005EE RID: 1518
		Private Delegate Sub Delegate3(dataGridViewRow_0 As DataGridViewRow)

		' Token: 0x0200003A RID: 58
		' (Invoke) Token: 0x060005F2 RID: 1522
		Private Delegate Sub Delegate4(int_0 As Integer)

		' Token: 0x0200003B RID: 59
		Public Enum GEnum0
			' Token: 0x0400032F RID: 815
			Image = 2
			' Token: 0x04000330 RID: 816
			Link = 1
			' Token: 0x04000331 RID: 817
			StretchImage = 3
			' Token: 0x04000332 RID: 818
			Text = 0
		End Enum
	End Class
End Namespace
