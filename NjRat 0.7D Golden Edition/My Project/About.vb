Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class About
		Inherits Form

		' Token: 0x06000050 RID: 80 RVA: 0x0000255C File Offset: 0x0000075C
		<DebuggerNonUserCode()>
		Public Sub New()
			About.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000051 RID: 81 RVA: 0x0000420C File Offset: 0x0000240C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = About.__ENCList
			SyncLock _ENCList
				If About.__ENCList.Count = About.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = About.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = About.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								About.__ENCList(num) = About.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					About.__ENCList.RemoveRange(num, About.__ENCList.Count - num)
					About.__ENCList.Capacity = About.__ENCList.Count
				End If
				About.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000054 RID: 84 RVA: 0x00004E1C File Offset: 0x0000301C
		' (set) Token: 0x06000055 RID: 85 RVA: 0x00004E34 File Offset: 0x00003034
		Friend Overridable Property LinkLabel1 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked_1
				If Me._LinkLabel1 IsNot Nothing Then
					RemoveHandler Me._LinkLabel1.LinkClicked, value2
				End If
				Me._LinkLabel1 = value
				If Me._LinkLabel1 IsNot Nothing Then
					AddHandler Me._LinkLabel1.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000056 RID: 86 RVA: 0x00004E8C File Offset: 0x0000308C
		' (set) Token: 0x06000057 RID: 87 RVA: 0x00002570 File Offset: 0x00000770
		Friend Overridable Property Label12 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label12 = value
			End Set
		End Property

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000058 RID: 88 RVA: 0x00004EA4 File Offset: 0x000030A4
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00002579 File Offset: 0x00000779
		Friend Overridable Property Label14 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label14 = value
			End Set
		End Property

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600005A RID: 90 RVA: 0x00004EBC File Offset: 0x000030BC
		' (set) Token: 0x0600005B RID: 91 RVA: 0x00002582 File Offset: 0x00000782
		Friend Overridable Property Label16 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label16 = value
			End Set
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x0600005C RID: 92 RVA: 0x00004ED4 File Offset: 0x000030D4
		' (set) Token: 0x0600005D RID: 93 RVA: 0x0000258B File Offset: 0x0000078B
		Friend Overridable Property Label17 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label17 = value
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600005E RID: 94 RVA: 0x00004EEC File Offset: 0x000030EC
		' (set) Token: 0x0600005F RID: 95 RVA: 0x00002594 File Offset: 0x00000794
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

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000060 RID: 96 RVA: 0x00004F04 File Offset: 0x00003104
		' (set) Token: 0x06000061 RID: 97 RVA: 0x0000259D File Offset: 0x0000079D
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000062 RID: 98 RVA: 0x00004F1C File Offset: 0x0000311C
		' (set) Token: 0x06000063 RID: 99 RVA: 0x000025A6 File Offset: 0x000007A6
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

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000064 RID: 100 RVA: 0x00004F34 File Offset: 0x00003134
		' (set) Token: 0x06000065 RID: 101 RVA: 0x000025AF File Offset: 0x000007AF
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

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000066 RID: 102 RVA: 0x00004F4C File Offset: 0x0000314C
		' (set) Token: 0x06000067 RID: 103 RVA: 0x000025B8 File Offset: 0x000007B8
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000068 RID: 104 RVA: 0x00004F64 File Offset: 0x00003164
		' (set) Token: 0x06000069 RID: 105 RVA: 0x000025C1 File Offset: 0x000007C1
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00004F7C File Offset: 0x0000317C
		' (set) Token: 0x0600006B RID: 107 RVA: 0x000025CA File Offset: 0x000007CA
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

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00004F94 File Offset: 0x00003194
		' (set) Token: 0x0600006D RID: 109 RVA: 0x000025D3 File Offset: 0x000007D3
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00004FAC File Offset: 0x000031AC
		' (set) Token: 0x0600006F RID: 111 RVA: 0x000025DC File Offset: 0x000007DC
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x06000070 RID: 112 RVA: 0x000025E5 File Offset: 0x000007E5
		Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://www.facebook.com/hacher.extern")
		End Sub

		' Token: 0x04000022 RID: 34
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000024 RID: 36
		<AccessedThroughProperty("LinkLabel1")>
		Private _LinkLabel1 As LinkLabel

		' Token: 0x04000025 RID: 37
		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		' Token: 0x04000026 RID: 38
		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		' Token: 0x04000027 RID: 39
		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		' Token: 0x04000028 RID: 40
		<AccessedThroughProperty("Label17")>
		Private _Label17 As Label

		' Token: 0x04000029 RID: 41
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400002A RID: 42
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400002B RID: 43
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400002C RID: 44
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400002D RID: 45
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400002E RID: 46
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400002F RID: 47
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000030 RID: 48
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000031 RID: 49
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox
	End Class
End Namespace
