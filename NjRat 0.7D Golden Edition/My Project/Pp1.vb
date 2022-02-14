Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200003C RID: 60
	Public NotInheritable Class Pp1
		Inherits PictureBox

		' Token: 0x060005F4 RID: 1524 RVA: 0x00036660 File Offset: 0x00034860
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pp1.__ENCList
			SyncLock _ENCList
				If Pp1.__ENCList.Count = Pp1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pp1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pp1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Pp1.__ENCList(num) = Pp1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pp1.__ENCList.RemoveRange(num, Pp1.__ENCList.Count - num)
					Pp1.__ENCList.Capacity = Pp1.__ENCList.Count
				End If
				Pp1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005F5 RID: 1525 RVA: 0x00036748 File Offset: 0x00034948
		Public Sub New()
			Pp1.__ENCAddToList(Me)
			Me.font = New Font("arial", 8F, FontStyle.Bold)
			Me.Lines = New List(Of Object())()
			Dim t As Timer = New Timer() With { .Interval = 50, .Enabled = False }
			Me.T = t
			Me.SizeMode = PictureBoxSizeMode.Normal
		End Sub

		' Token: 0x060005F6 RID: 1526 RVA: 0x000367A8 File Offset: 0x000349A8
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub ksh__4(sender As Object, e As EventArgs)
			Try
				Me.wrk()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005F7 RID: 1527 RVA: 0x000367DC File Offset: 0x000349DC
		Public Sub wrk()
			Try
				Me.T.Enabled = False
				SyncLock Me
					Dim image As Bitmap = New Bitmap(Me.Width, Me.Height)
					Me.G = Graphics.FromImage(image)
					Me.G.Clear(Color.Black)
					Dim num As Integer = 3
					Dim height As Integer = TextRenderer.MeasureText("test", Me.font).Height
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
								Dim size As Size = TextRenderer.MeasureText(text, Me.font)
								Me.G.DrawString(text, Me.font, New Pen(color).Brush, CSng(num2), CSng(num))
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

		' Token: 0x060005F8 RID: 1528 RVA: 0x00036A84 File Offset: 0x00034C84
		Public Sub WRT(ParamArray A As Object())
			SyncLock Me
				Me.Lines.Add(A)
				If Me.Lines.Count = 100 Then
					Me.Lines.RemoveAt(0)
				End If
			End SyncLock
		End Sub

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x060005F9 RID: 1529 RVA: 0x00036AE0 File Offset: 0x00034CE0
		' (set) Token: 0x060005FA RID: 1530 RVA: 0x00036AF8 File Offset: 0x00034CF8
		Public Property T As Timer
			Get
				Return Me._T
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ksh__4
				If Me._T IsNot Nothing Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				If Me._T IsNot Nothing Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x04000333 RID: 819
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000334 RID: 820
		Private _T As Timer

		' Token: 0x04000335 RID: 821
		Public font As Font

		' Token: 0x04000336 RID: 822
		Public G As Graphics

		' Token: 0x04000337 RID: 823
		Public Lines As List(Of Object())
	End Class
End Namespace
