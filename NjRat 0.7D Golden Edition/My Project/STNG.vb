Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000023 RID: 35
	<DesignerGenerated()>
	Public Partial Class STNG
		Inherits Form

		' Token: 0x06000509 RID: 1289 RVA: 0x000036F7 File Offset: 0x000018F7
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.STNG_Load
			STNG.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600050A RID: 1290 RVA: 0x000292BC File Offset: 0x000274BC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = STNG.__ENCList
			SyncLock _ENCList
				If STNG.__ENCList.Count = STNG.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = STNG.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = STNG.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								STNG.__ENCList(num) = STNG.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					STNG.__ENCList.RemoveRange(num, STNG.__ENCList.Count - num)
					STNG.__ENCList.Capacity = STNG.__ENCList.Count
				End If
				STNG.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x0600050D RID: 1293 RVA: 0x0002A5F4 File Offset: 0x000287F4
		' (set) Token: 0x0600050E RID: 1294 RVA: 0x0000371E File Offset: 0x0000191E
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x0600050F RID: 1295 RVA: 0x0002A60C File Offset: 0x0002880C
		' (set) Token: 0x06000510 RID: 1296 RVA: 0x00003727 File Offset: 0x00001927
		Friend Overridable Property ShowAlert As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowAlert
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._ShowAlert = value
			End Set
		End Property

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x06000511 RID: 1297 RVA: 0x0002A624 File Offset: 0x00028824
		' (set) Token: 0x06000512 RID: 1298 RVA: 0x00003730 File Offset: 0x00001930
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x06000513 RID: 1299 RVA: 0x0002A63C File Offset: 0x0002883C
		' (set) Token: 0x06000514 RID: 1300 RVA: 0x00003739 File Offset: 0x00001939
		Friend Overridable Property LOGMSGS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGMSGS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGMSGS = value
			End Set
		End Property

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x06000515 RID: 1301 RVA: 0x0002A654 File Offset: 0x00028854
		' (set) Token: 0x06000516 RID: 1302 RVA: 0x00003742 File Offset: 0x00001942
		Friend Overridable Property LOGRERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGRERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGRERR = value
			End Set
		End Property

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x06000517 RID: 1303 RVA: 0x0002A66C File Offset: 0x0002886C
		' (set) Token: 0x06000518 RID: 1304 RVA: 0x0000374B File Offset: 0x0000194B
		Friend Overridable Property LOGCONNECTIONS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGCONNECTIONS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGCONNECTIONS = value
			End Set
		End Property

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x06000519 RID: 1305 RVA: 0x0002A684 File Offset: 0x00028884
		' (set) Token: 0x0600051A RID: 1306 RVA: 0x00003754 File Offset: 0x00001954
		Friend Overridable Property LOGLERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLERR = value
			End Set
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x0600051B RID: 1307 RVA: 0x0002A69C File Offset: 0x0002889C
		' (set) Token: 0x0600051C RID: 1308 RVA: 0x0000375D File Offset: 0x0000195D
		Friend Overridable Property LOGLOGIN As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLOGIN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLOGIN = value
			End Set
		End Property

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x0600051D RID: 1309 RVA: 0x0002A6B4 File Offset: 0x000288B4
		' (set) Token: 0x0600051E RID: 1310 RVA: 0x00003766 File Offset: 0x00001966
		Friend Overridable Property GroupBox3 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox3 = value
			End Set
		End Property

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x0600051F RID: 1311 RVA: 0x0002A6CC File Offset: 0x000288CC
		' (set) Token: 0x06000520 RID: 1312 RVA: 0x0000376F File Offset: 0x0000196F
		Friend Overridable Property SCAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._SCAUT = value
			End Set
		End Property

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x06000521 RID: 1313 RVA: 0x0002A6E4 File Offset: 0x000288E4
		' (set) Token: 0x06000522 RID: 1314 RVA: 0x00003778 File Offset: 0x00001978
		Friend Overridable Property SCI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._SCI = value
			End Set
		End Property

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x06000523 RID: 1315 RVA: 0x0002A6FC File Offset: 0x000288FC
		' (set) Token: 0x06000524 RID: 1316 RVA: 0x00003781 File Offset: 0x00001981
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

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x06000525 RID: 1317 RVA: 0x0002A714 File Offset: 0x00028914
		' (set) Token: 0x06000526 RID: 1318 RVA: 0x0000378A File Offset: 0x0000198A
		Friend Overridable Property GroupBox4 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox4 = value
			End Set
		End Property

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x06000527 RID: 1319 RVA: 0x0002A72C File Offset: 0x0002892C
		' (set) Token: 0x06000528 RID: 1320 RVA: 0x00003793 File Offset: 0x00001993
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

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x06000529 RID: 1321 RVA: 0x0002A744 File Offset: 0x00028944
		' (set) Token: 0x0600052A RID: 1322 RVA: 0x0000379C File Offset: 0x0000199C
		Friend Overridable Property CAMI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._CAMI = value
			End Set
		End Property

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x0600052B RID: 1323 RVA: 0x0002A75C File Offset: 0x0002895C
		' (set) Token: 0x0600052C RID: 1324 RVA: 0x000037A5 File Offset: 0x000019A5
		Friend Overridable Property CAMAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CAMAUT = value
			End Set
		End Property

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x0600052D RID: 1325 RVA: 0x0002A774 File Offset: 0x00028974
		' (set) Token: 0x0600052E RID: 1326 RVA: 0x000037AE File Offset: 0x000019AE
		Friend Overridable Property GroupBox5 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox5 = value
			End Set
		End Property

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x0600052F RID: 1327 RVA: 0x0002A78C File Offset: 0x0002898C
		' (set) Token: 0x06000530 RID: 1328 RVA: 0x000037B7 File Offset: 0x000019B7
		Friend Overridable Property MICI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._MICI = value
			End Set
		End Property

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x06000531 RID: 1329 RVA: 0x0002A7A4 File Offset: 0x000289A4
		' (set) Token: 0x06000532 RID: 1330 RVA: 0x000037C0 File Offset: 0x000019C0
		Friend Overridable Property MICAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._MICAUT = value
			End Set
		End Property

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x06000533 RID: 1331 RVA: 0x0002A7BC File Offset: 0x000289BC
		' (set) Token: 0x06000534 RID: 1332 RVA: 0x000037C9 File Offset: 0x000019C9
		Friend Overridable Property GroupBox6 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox6 = value
			End Set
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x06000535 RID: 1333 RVA: 0x0002A7D4 File Offset: 0x000289D4
		' (set) Token: 0x06000536 RID: 1334 RVA: 0x000037D2 File Offset: 0x000019D2
		Friend Overridable Property scrI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._scrI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._scrI = value
			End Set
		End Property

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x06000537 RID: 1335 RVA: 0x0002A7EC File Offset: 0x000289EC
		' (set) Token: 0x06000538 RID: 1336 RVA: 0x0002A804 File Offset: 0x00028A04
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

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x06000539 RID: 1337 RVA: 0x0002A85C File Offset: 0x00028A5C
		' (set) Token: 0x0600053A RID: 1338 RVA: 0x000037DB File Offset: 0x000019DB
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

		' Token: 0x0600053B RID: 1339 RVA: 0x0002A874 File Offset: 0x00028A74
		Private Sub STNG_Load(sender As Object, e As EventArgs)
			Me.SCAUT.Checked = Class7.class8_0.bool_6
			Me.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
			Me.CAMAUT.Checked = Class7.class8_0.bool_7
			Me.CAMI.SelectedIndex = Class7.class8_0.int_0
			Me.MICAUT.Checked = Class7.class8_0.bool_8
			Me.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2
			Me.LOGLERR.Checked = Class7.class8_0.bool_3
			Me.LOGRERR.Checked = Class7.class8_0.bool_4
			Me.LOGMSGS.Checked = Class7.class8_0.bool_5
			Me.LOGLOGIN.Checked = Class7.class8_0.bool_1
			Me.ShowAlert.Checked = Class7.class8_0.bool_0
			Me.MICI.SelectedIndex = Class7.class8_0.int_1
			Me.scrI.SelectedIndex = Class7.class8_0.int_2
		End Sub

		' Token: 0x0600053C RID: 1340 RVA: 0x0002A998 File Offset: 0x00028B98
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Class7.class8_0.bool_6 = Me.SCAUT.Checked
			Class7.class8_0.string_0 = Conversions.ToString(Me.SCI.SelectedIndex)
			Class7.class8_0.bool_7 = Me.CAMAUT.Checked
			Class7.class8_0.int_0 = Me.CAMI.SelectedIndex
			Class7.class8_0.bool_8 = Me.MICAUT.Checked
			Class7.class8_0.bool_2 = Me.LOGCONNECTIONS.Checked
			Class7.class8_0.bool_3 = Me.LOGLERR.Checked
			Class7.class8_0.bool_4 = Me.LOGRERR.Checked
			Class7.class8_0.bool_5 = Me.LOGMSGS.Checked
			Class7.class8_0.bool_1 = Me.LOGLOGIN.Checked
			Class7.class8_0.bool_0 = Me.ShowAlert.Checked
			Class7.class8_0.int_1 = Me.MICI.SelectedIndex
			Class7.class8_0.int_2 = Me.scrI.SelectedIndex
			Class7.class8_0.method_1()
			Me.Close()
		End Sub

		' Token: 0x0400025E RID: 606
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000260 RID: 608
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000261 RID: 609
		<AccessedThroughProperty("ShowAlert")>
		Private _ShowAlert As CheckBox

		' Token: 0x04000262 RID: 610
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000263 RID: 611
		<AccessedThroughProperty("LOGMSGS")>
		Private _LOGMSGS As CheckBox

		' Token: 0x04000264 RID: 612
		<AccessedThroughProperty("LOGRERR")>
		Private _LOGRERR As CheckBox

		' Token: 0x04000265 RID: 613
		<AccessedThroughProperty("LOGCONNECTIONS")>
		Private _LOGCONNECTIONS As CheckBox

		' Token: 0x04000266 RID: 614
		<AccessedThroughProperty("LOGLERR")>
		Private _LOGLERR As CheckBox

		' Token: 0x04000267 RID: 615
		<AccessedThroughProperty("LOGLOGIN")>
		Private _LOGLOGIN As CheckBox

		' Token: 0x04000268 RID: 616
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000269 RID: 617
		<AccessedThroughProperty("SCAUT")>
		Private _SCAUT As CheckBox

		' Token: 0x0400026A RID: 618
		<AccessedThroughProperty("SCI")>
		Private _SCI As ComboBox

		' Token: 0x0400026B RID: 619
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400026C RID: 620
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400026D RID: 621
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400026E RID: 622
		<AccessedThroughProperty("CAMI")>
		Private _CAMI As ComboBox

		' Token: 0x0400026F RID: 623
		<AccessedThroughProperty("CAMAUT")>
		Private _CAMAUT As CheckBox

		' Token: 0x04000270 RID: 624
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000271 RID: 625
		<AccessedThroughProperty("MICI")>
		Private _MICI As ComboBox

		' Token: 0x04000272 RID: 626
		<AccessedThroughProperty("MICAUT")>
		Private _MICAUT As CheckBox

		' Token: 0x04000273 RID: 627
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x04000274 RID: 628
		<AccessedThroughProperty("scrI")>
		Private _scrI As ComboBox

		' Token: 0x04000275 RID: 629
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000276 RID: 630
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000277 RID: 631
		Private ColorDialog1 As ColorDialog

		' Token: 0x04000278 RID: 632
		Private ColorDialog2 As ColorDialog
	End Class
End Namespace
