Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class script
		Inherits Form

		' Token: 0x0600046C RID: 1132 RVA: 0x000252F8 File Offset: 0x000234F8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = script.__ENCList
			SyncLock _ENCList
				If script.__ENCList.Count = script.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = script.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = script.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								script.__ENCList(num) = script.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					script.__ENCList.RemoveRange(num, script.__ENCList.Count - num)
					script.__ENCList.Capacity = script.__ENCList.Count
				End If
				script.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x0600046F RID: 1135 RVA: 0x000257B4 File Offset: 0x000239B4
		' (set) Token: 0x06000470 RID: 1136 RVA: 0x000033FD File Offset: 0x000015FD
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

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x06000471 RID: 1137 RVA: 0x000257CC File Offset: 0x000239CC
		' (set) Token: 0x06000472 RID: 1138 RVA: 0x00003406 File Offset: 0x00001606
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

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x06000473 RID: 1139 RVA: 0x000257E4 File Offset: 0x000239E4
		' (set) Token: 0x06000474 RID: 1140 RVA: 0x0000340F File Offset: 0x0000160F
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

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x06000475 RID: 1141 RVA: 0x000257FC File Offset: 0x000239FC
		' (set) Token: 0x06000476 RID: 1142 RVA: 0x00025814 File Offset: 0x00023A14
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

		' Token: 0x06000477 RID: 1143 RVA: 0x00003418 File Offset: 0x00001618
		Public Sub New()
			script.__ENCAddToList(Me)
			Me.RunAs = "vbs"
			Me.Code = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000478 RID: 1144 RVA: 0x00003442 File Offset: 0x00001642
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Code = Me.TextBox1.Text
			Me.RunAs = Me.ComboBox1.Text
			Me.Close()
		End Sub

		' Token: 0x04000218 RID: 536
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400021A RID: 538
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400021B RID: 539
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400021C RID: 540
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400021D RID: 541
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400021E RID: 542
		Public Code As String

		' Token: 0x0400021F RID: 543
		Public F As Form1

		' Token: 0x04000220 RID: 544
		Public RunAs As String
	End Class
End Namespace
