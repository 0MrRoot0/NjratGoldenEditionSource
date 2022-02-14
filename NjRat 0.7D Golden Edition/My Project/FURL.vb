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
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class FURL
		Inherits Form

		' Token: 0x0600021C RID: 540 RVA: 0x00013CA4 File Offset: 0x00011EA4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FURL.__ENCList
			SyncLock _ENCList
				If FURL.__ENCList.Count = FURL.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FURL.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FURL.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FURL.__ENCList(num) = FURL.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FURL.__ENCList.RemoveRange(num, FURL.__ENCList.Count - num)
					FURL.__ENCList.Capacity = FURL.__ENCList.Count
				End If
				FURL.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x0600021F RID: 543 RVA: 0x0001423C File Offset: 0x0001243C
		' (set) Token: 0x06000220 RID: 544 RVA: 0x00002C1A File Offset: 0x00000E1A
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000221 RID: 545 RVA: 0x00014254 File Offset: 0x00012454
		' (set) Token: 0x06000222 RID: 546 RVA: 0x00002C23 File Offset: 0x00000E23
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

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000223 RID: 547 RVA: 0x0001426C File Offset: 0x0001246C
		' (set) Token: 0x06000224 RID: 548 RVA: 0x00002C2C File Offset: 0x00000E2C
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000225 RID: 549 RVA: 0x00014284 File Offset: 0x00012484
		' (set) Token: 0x06000226 RID: 550 RVA: 0x0001429C File Offset: 0x0001249C
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim value3 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextChanged, value2
					RemoveHandler Me._TextBox1.TextAlignChanged, value3
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextChanged, value2
					AddHandler Me._TextBox1.TextAlignChanged, value3
				End If
			End Set
		End Property

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000227 RID: 551 RVA: 0x00014318 File Offset: 0x00012518
		' (set) Token: 0x06000228 RID: 552 RVA: 0x00014330 File Offset: 0x00012530
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				If Me._Button2 IsNot Nothing Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				If Me._Button2 IsNot Nothing Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000229 RID: 553 RVA: 0x00014388 File Offset: 0x00012588
		' (set) Token: 0x0600022A RID: 554 RVA: 0x000143A0 File Offset: 0x000125A0
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

		' Token: 0x0600022B RID: 555 RVA: 0x00002C35 File Offset: 0x00000E35
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.FURL_KeyDown
			FURL.__ENCAddToList(Me)
			Me.IsOK = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600022C RID: 556 RVA: 0x00002C63 File Offset: 0x00000E63
		Private Sub FURL_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
			End If
		End Sub

		' Token: 0x0600022D RID: 557 RVA: 0x00002A6F File Offset: 0x00000C6F
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600022E RID: 558 RVA: 0x000143F8 File Offset: 0x000125F8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Me.TextBox1.Text.Length > 0 And Me.TextBox1.Text.ToLower().StartsWith("http") And Me.TextBox2.TextLength > 0 Then
				Me.IsOK = True
				Me.Close()
			End If
		End Sub

		' Token: 0x0600022F RID: 559 RVA: 0x0000276C File Offset: 0x0000096C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000230 RID: 560 RVA: 0x00014454 File Offset: 0x00012654
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040000F2 RID: 242
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000F4 RID: 244
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000F5 RID: 245
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000F6 RID: 246
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040000F7 RID: 247
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040000F8 RID: 248
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000F9 RID: 249
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000FA RID: 250
		Public IsOK As Boolean
	End Class
End Namespace
