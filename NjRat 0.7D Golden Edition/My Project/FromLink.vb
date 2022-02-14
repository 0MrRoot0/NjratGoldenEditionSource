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
	' Token: 0x02000010 RID: 16
	<DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Form

		' Token: 0x06000208 RID: 520 RVA: 0x00002BD0 File Offset: 0x00000DD0
		<DebuggerNonUserCode()>
		Public Sub New()
			FromLink.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000209 RID: 521 RVA: 0x000134EC File Offset: 0x000116EC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FromLink.__ENCList
			SyncLock _ENCList
				If FromLink.__ENCList.Count = FromLink.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FromLink.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FromLink.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FromLink.__ENCList(num) = FromLink.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FromLink.__ENCList.RemoveRange(num, FromLink.__ENCList.Count - num)
					FromLink.__ENCList.Capacity = FromLink.__ENCList.Count
				End If
				FromLink.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x0600020C RID: 524 RVA: 0x00013A90 File Offset: 0x00011C90
		' (set) Token: 0x0600020D RID: 525 RVA: 0x00013AA8 File Offset: 0x00011CA8
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

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x0600020E RID: 526 RVA: 0x00013B00 File Offset: 0x00011D00
		' (set) Token: 0x0600020F RID: 527 RVA: 0x00013B18 File Offset: 0x00011D18
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

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x06000210 RID: 528 RVA: 0x00013B70 File Offset: 0x00011D70
		' (set) Token: 0x06000211 RID: 529 RVA: 0x00013B88 File Offset: 0x00011D88
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextAlignChanged, value2
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextAlignChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x06000212 RID: 530 RVA: 0x00013BE0 File Offset: 0x00011DE0
		' (set) Token: 0x06000213 RID: 531 RVA: 0x00002BE4 File Offset: 0x00000DE4
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

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x06000214 RID: 532 RVA: 0x00013BF8 File Offset: 0x00011DF8
		' (set) Token: 0x06000215 RID: 533 RVA: 0x00002BED File Offset: 0x00000DED
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

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x06000216 RID: 534 RVA: 0x00013C10 File Offset: 0x00011E10
		' (set) Token: 0x06000217 RID: 535 RVA: 0x00002BF6 File Offset: 0x00000DF6
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

		' Token: 0x06000218 RID: 536 RVA: 0x00002BFF File Offset: 0x00000DFF
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.IsOK = True
			Me.Close()
		End Sub

		' Token: 0x06000219 RID: 537 RVA: 0x0000276C File Offset: 0x0000096C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600021A RID: 538 RVA: 0x00013C28 File Offset: 0x00011E28
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
				Me.TextBox2.Text = "File.txt"
			End Try
		End Sub

		' Token: 0x040000E9 RID: 233
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000EB RID: 235
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000EC RID: 236
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000ED RID: 237
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040000EE RID: 238
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040000EF RID: 239
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000F0 RID: 240
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000F1 RID: 241
		Public IsOK As Boolean
	End Class
End Namespace
