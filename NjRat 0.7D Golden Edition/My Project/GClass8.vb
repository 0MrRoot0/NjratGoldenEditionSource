Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000033 RID: 51
	Public NotInheritable Class GClass8
		Inherits PictureBox

		' Token: 0x060005B3 RID: 1459 RVA: 0x00034B40 File Offset: 0x00032D40
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = GClass8.__ENCList
			SyncLock _ENCList
				If GClass8.__ENCList.Count = GClass8.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = GClass8.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = GClass8.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								GClass8.__ENCList(num) = GClass8.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					GClass8.__ENCList.RemoveRange(num, GClass8.__ENCList.Count - num)
					GClass8.__ENCList.Capacity = GClass8.__ENCList.Count
				End If
				GClass8.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005B4 RID: 1460 RVA: 0x00034C28 File Offset: 0x00032E28
		Public Sub New()
			GClass8.__ENCAddToList(Me)
			Me.fonty = New Font("arial", 8F, FontStyle.Bold)
			Me.Lines = New List(Of Object())()
			Dim t As Timer = New Timer() With { .Interval = 50, .Enabled = False }
			Me.T = t
			Me.SizeMode = PictureBoxSizeMode.Normal
		End Sub

		' Token: 0x060005B5 RID: 1461 RVA: 0x00034C88 File Offset: 0x00032E88
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub lam__4(sender As Object, e As EventArgs)
			Try
				Me.wrk()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005B6 RID: 1462 RVA: 0x00034CBC File Offset: 0x00032EBC
		Public Sub wrk()
			Try
				Me.T.Enabled = False
				SyncLock Me
					Dim image As Bitmap = New Bitmap(Me.Width, Me.Height)
					Me.G = Graphics.FromImage(image)

					Dim num As Integer = 3
					Dim height As Integer = TextRenderer.MeasureText("test", Me.Font).Height
					Dim color As Color = Color.White
					For i As Integer = Me.Lines.Count - 1 To 0 Step -1
						Dim num2 As Integer = 3
						Dim array As Object() = Me.Lines(i)
						Dim num3 As Integer = array.Length - 1
						For j As Integer = 0 To num3
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array(j))))))))
							Dim left As String = objectValue.[GetType]().ToString()
							If Operators.CompareString(left, GetType(Bitmap).ToString(), False) = 0 Then
								Dim bitmap As Bitmap = CType(objectValue, Bitmap)
								If bitmap.Height > height Then
									Dim callbackData As IntPtr
									bitmap = CType(bitmap.GetThumbnailImage(height, height, Nothing, callbackData), Bitmap)
								End If
								Me.G.DrawImage(bitmap, num2, num)
								num2 += bitmap.Width + 3
							ElseIf Operators.CompareString(left, GetType(String).ToString(), False) = 0 Then
								Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))))
								Dim size As Size = TextRenderer.MeasureText(text, Me.Font)
								Me.G.DrawString(text, Me.Font, New Pen(color).Brush, CSng(num2), CSng(num))
								If size.Height - height > 0 Then
									num += size.Height - height
									num2 = 3
								Else
									num2 += size.Width + 3
								End If
							ElseIf Operators.CompareString(left, GetType(Color).ToString(), False) = 0 Then
								color = CType(objectValue, Color)
							End If
						Next
						num += height
					Next
					Me.G.Dispose()
					Me.Image = image
				End SyncLock
				Me.T.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005B7 RID: 1463 RVA: 0x00034F64 File Offset: 0x00033164
		Public Sub WRT(ParamArray A As Object())
			SyncLock Me
				Me.Lines.Add(A)
				If Me.Lines.Count = 100 Then
					Me.Lines.RemoveAt(0)
				End If
			End SyncLock
		End Sub

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x060005B8 RID: 1464 RVA: 0x00034FC0 File Offset: 0x000331C0
		' (set) Token: 0x060005B9 RID: 1465 RVA: 0x00034FD8 File Offset: 0x000331D8
		Public Property T As Timer
			Get
				Return Me._T
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.lam__4
				If Me._T IsNot Nothing Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				If Me._T IsNot Nothing Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x0400031F RID: 799
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000320 RID: 800
		Private _T As Timer

		' Token: 0x04000321 RID: 801
		Public fonty As Font

		' Token: 0x04000322 RID: 802
		Public G As Graphics

		' Token: 0x04000323 RID: 803
		Public Lines As List(Of Object())
	End Class
End Namespace
