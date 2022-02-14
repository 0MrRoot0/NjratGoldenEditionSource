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
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class port
		Inherits Form

		' Token: 0x06000405 RID: 1029 RVA: 0x0002224C File Offset: 0x0002044C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = NJRAT.port.__ENCList
			SyncLock _ENCList
				If NJRAT.port.__ENCList.Count = NJRAT.port.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = NJRAT.port.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = NJRAT.port.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								NJRAT.port.__ENCList(num) = NJRAT.port.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					NJRAT.port.__ENCList.RemoveRange(num, NJRAT.port.__ENCList.Count - num)
					NJRAT.port.__ENCList.Capacity = NJRAT.port.__ENCList.Count
				End If
				NJRAT.port.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x06000408 RID: 1032 RVA: 0x0002291C File Offset: 0x00020B1C
		' (set) Token: 0x06000409 RID: 1033 RVA: 0x00022934 File Offset: 0x00020B34
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextChanged, value2
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x0600040A RID: 1034 RVA: 0x0002298C File Offset: 0x00020B8C
		' (set) Token: 0x0600040B RID: 1035 RVA: 0x000229A4 File Offset: 0x00020BA4
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

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x0600040C RID: 1036 RVA: 0x000229FC File Offset: 0x00020BFC
		' (set) Token: 0x0600040D RID: 1037 RVA: 0x00003286 File Offset: 0x00001486
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

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x0600040E RID: 1038 RVA: 0x00022A14 File Offset: 0x00020C14
		' (set) Token: 0x0600040F RID: 1039 RVA: 0x00022A2C File Offset: 0x00020C2C
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

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x06000410 RID: 1040 RVA: 0x00022A84 File Offset: 0x00020C84
		' (set) Token: 0x06000411 RID: 1041 RVA: 0x0000328F File Offset: 0x0000148F
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

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x06000412 RID: 1042 RVA: 0x00022A9C File Offset: 0x00020C9C
		' (set) Token: 0x06000413 RID: 1043 RVA: 0x00003298 File Offset: 0x00001498
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x06000414 RID: 1044 RVA: 0x00022AB4 File Offset: 0x00020CB4
		' (set) Token: 0x06000415 RID: 1045 RVA: 0x000032A1 File Offset: 0x000014A1
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x06000416 RID: 1046 RVA: 0x00022ACC File Offset: 0x00020CCC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.port_Load
			AddHandler MyBase.KeyDown, AddressOf Me.port_KeyDown
			AddHandler MyBase.Activated, AddressOf Me.port_Activated
			NJRAT.port.__ENCAddToList(Me)
			Me.port = -1
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000417 RID: 1047 RVA: 0x000032AA File Offset: 0x000014AA
		Private Sub port_Activated(sender As Object, e As EventArgs)
			Me.TextBox1.Focus()
		End Sub

		' Token: 0x06000418 RID: 1048 RVA: 0x00022B2C File Offset: 0x00020D2C
		Private Sub port_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				e.SuppressKeyPress = True
				If Me.Button1.Enabled Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), New EventArgs())
				End If
			ElseIf e.KeyCode = Keys.Escape Then
				Me.port = -1
				Me.Close()
			End If
		End Sub

		' Token: 0x06000419 RID: 1049 RVA: 0x000032B8 File Offset: 0x000014B8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.port = Conversions.ToInteger(Me.TextBox1.Text)
			Me.Close()
		End Sub

		' Token: 0x0600041A RID: 1050 RVA: 0x000032D6 File Offset: 0x000014D6
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.port = -1
			Me.Close()
		End Sub

		' Token: 0x0600041B RID: 1051 RVA: 0x000032E5 File Offset: 0x000014E5
		Private Sub port_Load(sender As Object, e As EventArgs)
			Me.Label3.Text = Environment.UserName
			Me.Icon = Resources.icon
		End Sub

		' Token: 0x0600041C RID: 1052 RVA: 0x00022B90 File Offset: 0x00020D90
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Conversions.ToInteger(Me.TextBox1.Text)
				If Conversions.ToInteger(Me.TextBox1.Text) > 65534 Or Conversions.ToInteger(Me.TextBox1.Text) < 1 Then
					Me.Button1.Enabled = False
				Else
					Me.Button1.Enabled = True
				End If
			Catch ex As Exception
				Me.Button1.Enabled = False
			End Try
		End Sub

		' Token: 0x040001E1 RID: 481
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001E3 RID: 483
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001E4 RID: 484
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001E5 RID: 485
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001E6 RID: 486
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040001E7 RID: 487
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040001E8 RID: 488
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040001E9 RID: 489
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040001EA RID: 490
		Public port As Integer
	End Class
End Namespace
