Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002D RID: 45
	Public NotInheritable Class GClass3
		' Token: 0x06000589 RID: 1417 RVA: 0x00003885 File Offset: 0x00001A85
		Public Sub New(string_3 As String)
			Me.New(string_3, GClass3.int_20)
		End Sub

		' Token: 0x0600058A RID: 1418 RVA: 0x0003342C File Offset: 0x0003162C
		Public Sub New(string_3 As String, int_26 As Integer)
			Me.fileStream_0 = Nothing
			Me.gclass5_0 = Nothing
			Me.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(New Object())))
			Me.byte_0 = Convert.ToByte(GClass5.int_0)
			Me.int_3 = 0
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0 = New FileStream(string_3, FileMode.Open, FileAccess.Read)
				End SyncLock
				Me.int_2 = int_26
				Me.method_0()
			Catch ex As SystemException
				Console.Write("cannot open file " + string_3 + vbLf)
			End Try
		End Sub

		' Token: 0x0600058B RID: 1419 RVA: 0x00033514 File Offset: 0x00031714
		Private Sub method_0()
			Dim array As Byte() = New Byte(2) {}
			Dim array2 As Byte() = New Byte(GClass3.int_9 - 1 + 1 - 1 + 1 - 1) {}
			Me.byte_0 = CByte(GClass5.int_0)
			Me.int_1 = GClass3.int_10
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
			Dim obj As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			SyncLock obj
				Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
				Dim num As Integer = GClass3.int_6 - 1
				Dim i As Integer = 0
				While i <= num
					Me.fileStream_0.Read(array, 0, 3)
					If array(0) <> 255 OrElse array(1) <> 255 Then
						GoTo IL_AC
					End If
					If array(2) <> 255 Then
						GoTo IL_AC
					End If
					Dim flag As Boolean = True
					IL_AD:
					If Not flag Then
						Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						i += 1
						Continue While
					End If
					Me.byte_0 = Convert.ToByte(Me.fileStream_0.ReadByte())
					If Me.byte_0 >= 106 Then
						Me.byte_0 -= 105
					End If
					If CInt(Me.byte_0) = GClass5.int_1 Then
						Me.int_0 = New Integer() { GClass3.int_15 }
						Me.int_1 = GClass3.int_10
					ElseIf CInt(Me.byte_0) = GClass5.int_2 Then
						Me.int_0 = New Integer() { GClass3.int_16 }
						Me.int_1 = GClass3.int_10
					Else
						Dim flag2 As Boolean
						If CInt(Me.byte_0) <> GClass5.int_3 Then
							If CInt(Me.byte_0) <> GClass5.int_4 Then
								If CInt(Me.byte_0) <> GClass5.int_5 Then
									If CInt(Me.byte_0) <> GClass5.int_14 Then
										If CInt(Me.byte_0) <> GClass5.int_6 Then
											If CInt(Me.byte_0) <> GClass5.int_13 Then
												If CInt(Me.byte_0) <> GClass5.int_8 Then
													If CInt(Me.byte_0) <> GClass5.int_12 Then
														If CInt(Me.byte_0) <> GClass5.int_18 Then
															If CInt(Me.byte_0) <> GClass5.int_19 Then
																If CInt(Me.byte_0) <> GClass5.int_17 AndAlso CInt(Me.byte_0) <> GClass5.int_16 Then
																	flag2 = False
																	GoTo IL_233
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						flag2 = True
						IL_233:
						If flag2 Then
							Me.int_0 = New Integer() { 0 }
							Dim flag3 As Boolean
							If CInt(Me.byte_0) <> GClass5.int_3 Then
								If CInt(Me.byte_0) <> GClass5.int_4 Then
									If CInt(Me.byte_0) <> GClass5.int_12 Then
										If CInt(Me.byte_0) <> GClass5.int_18 Then
											If CInt(Me.byte_0) <> GClass5.int_19 Then
												If CInt(Me.byte_0) <> GClass5.int_17 Then
													If CInt(Me.byte_0) <> GClass5.int_16 AndAlso CInt(Me.byte_0) <> GClass5.int_8 Then
														flag3 = False
														GoTo IL_2BF
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							flag3 = True
							IL_2BF:
							If flag3 Then
								Me.int_1 = GClass3.int_10
							Else
								Me.int_1 = GClass3.int_11
							End If
							Me.fileStream_0.Read(array2, 0, GClass3.int_9)
							Dim num2 As Integer = GClass3.int_9 - 1
							For j As Integer = 0 To num2
								Me.int_0(0) = Me.int_0(0) + (GClass3.smethod_2(array2(j)) << j * 8)
							Next
						End If
					End If
					IL_32D:
					Dim flag4 As Boolean
					If CInt(Me.byte_0) <> GClass5.int_0 Then
						If CInt(Me.byte_0) <> GClass5.int_11 Then
							If CInt(Me.byte_0) <> GClass5.int_7 AndAlso CInt(Me.byte_0) <> GClass5.int_9 Then
								flag4 = False
								GoTo IL_367
							End If
						End If
					End If
					flag4 = True
					IL_367:
					If flag4 Then
						Me.int_0 = New Integer() { GClass3.int_4 }
						Me.int_1 = GClass3.int_10
					End If
					If(Me.int_2 And GClass3.int_21) = 1 Then
						Dim num3 As Integer = CInt(Me.fileStream_0.Length)
						Me.byte_1 = New Byte(num3 - 1 + 1 - 1 + 1 - 1) {}
						Me.fileStream_0.Seek(0L, SeekOrigin.Begin)
						Me.fileStream_0.Read(Me.byte_1, 0, num3)
					End If
					Return
					IL_AC:
					flag = False
					GoTo IL_AD
				End While
				GoTo IL_32D
			End SyncLock
		End Sub

		' Token: 0x0600058C RID: 1420 RVA: 0x00033934 File Offset: 0x00031B34
		Public Sub method_1()
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Close()
				End SyncLock
				Me.fileStream_0 = Nothing
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600058D RID: 1421 RVA: 0x000339BC File Offset: 0x00031BBC
		Public Function method_10() As GClass5
			Dim result As GClass5
			If Me.gclass5_0 IsNot Nothing Then
				result = Me.gclass5_0
			Else
				Try
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag As Boolean = False
						Dim array As Byte() = New Byte(2) {}
						Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						Dim num As Integer = GClass3.int_6 - 1
						Dim i As Integer = 0
						While i <= num
							Me.fileStream_0.Read(array, 0, 3)
							If array(0) <> 255 OrElse array(1) <> 255 Then
								GoTo IL_A4
							End If
							If array(2) <> 255 Then
								GoTo IL_A4
							End If
							Dim flag2 As Boolean = True
							IL_A5:
							If Not flag2 Then
								Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
								i += 1
								Continue While
							End If
							flag = True
							IL_D2:
							If flag Then
								Me.fileStream_0.Seek(-6L, SeekOrigin.Current)
							Else
								Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
							End If
							Dim num2 As Integer = GClass3.int_7 - 1
							Dim j As Integer = 0
							While j <= num2
								Me.fileStream_0.Read(array, 0, 3)
								If array(0) <> 0 OrElse array(1) <> 0 Then
									GoTo IL_13B
								End If
								If array(2) <> 0 Then
									GoTo IL_13B
								End If
								Dim flag3 As Boolean = True
								IL_13C:
								If Not flag3 Then
									Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
									j += 1
									Continue While
								End If
								Dim array2 As Byte() = New Byte(j - 1 + 1 - 1 + 1 - 1) {}
								Dim array3 As Char() = New Char(j - 1 + 1 - 1 + 1 - 1) {}
								Me.fileStream_0.Read(array2, 0, j)
								Dim num3 As Integer = j - 1
								For k As Integer = 0 To num3
									array3(k) = Convert.ToChar(array2(k))
								Next
								Me.gclass5_0 = New GClass5(New String(array3))
								Return Me.gclass5_0
								IL_13B:
								flag3 = False
								GoTo IL_13C
							End While
							GoTo IL_1EA
							IL_A4:
							flag2 = False
							GoTo IL_A5
						End While
						GoTo IL_D2
					End SyncLock
					IL_1EA:
				Catch ex As Exception
					Dim ex2 As Exception = ex
					Console.Write(ex2.Message)
				End Try
				result = New GClass5(String.Empty)
			End If
			Return result
		End Function

		' Token: 0x0600058E RID: 1422 RVA: 0x00033C20 File Offset: 0x00031E20
		Public Function method_11(ipaddress_0 As IPAddress) As GClass6
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())))
		End Function

		' Token: 0x0600058F RID: 1423 RVA: 0x00033C48 File Offset: 0x00031E48
		Public Function method_12(string_3 As String) As GClass6
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())))
		End Function

		' Token: 0x06000590 RID: 1424 RVA: 0x00033CB0 File Offset: 0x00031EB0
		Public Function method_13(ipaddress_0 As IPAddress) As String
			Return Me.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000591 RID: 1425 RVA: 0x00033CD0 File Offset: 0x00031ED0
		Public Function method_14(string_3 As String) As String
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_16(ipaddress_)
		End Function

		' Token: 0x06000592 RID: 1426 RVA: 0x00033D28 File Offset: 0x00031F28
		Public Function method_15(string_3 As String) As String
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x06000593 RID: 1427 RVA: 0x00033D8C File Offset: 0x00031F8C
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_16(ipaddress_0 As IPAddress) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_18(ipaddress_0)
				If num2 = Me.int_0(0) Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				If(Me.int_2 And GClass3.int_21) = 1 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
					GoTo IL_FA
				End If
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
					Me.fileStream_0.Read(array, 0, GClass3.int_13)
					GoTo IL_FA
				End SyncLock
				IL_EB:
				array2(num) = Convert.ToChar(array(num))
				num += 1
				IL_FA:
				If array(num) <> 0 Then
					GoTo IL_EB
				End If
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06000594 RID: 1428 RVA: 0x00033EF8 File Offset: 0x000320F8
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_17(long_0 As Long) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_19(long_0)
				If num2 = Me.int_0(0) Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				If(Me.int_2 And GClass3.int_21) = 1 Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
					GoTo IL_FA
				End If
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
					Me.fileStream_0.Read(array, 0, GClass3.int_13)
					GoTo IL_FA
				End SyncLock
				IL_EB:
				array2(num) = Convert.ToChar(array(num))
				num += 1
				IL_FA:
				If array(num) <> 0 Then
					GoTo IL_EB
				End If
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06000595 RID: 1429 RVA: 0x00034064 File Offset: 0x00032264
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_18(ipaddress_0 As IPAddress) As Integer
			Dim addressBytes As Byte() = ipaddress_0.GetAddressBytes()
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 127
			While True
				Try
					If(Me.int_2 And GClass3.int_21) = 1 Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
					GoTo IL_1DB
				Catch ex As IOException
					Console.Write("IO Exception")
					GoTo IL_1DB
				End Try
				GoTo IL_105
				IL_143:
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				If num4 > num5 Then
					num6 += 1
					If num6 <= 1 Then
						GoTo IL_15E
					End If
					Dim num7 As Integer = 127 - num2
					Dim num8 As Integer = num7 >> 3
					Dim num9 As Integer = 1 << ((num7 And 7) Xor 7)
					If(CInt(addressBytes(num8)) And num9) > 0 Then
						If array2(1) >= Me.int_0(0) Then
							GoTo IL_1E3
						End If
						num = array2(1)
					Else
						If array2(0) >= Me.int_0(0) Then
							GoTo IL_1EA
						End If
						num = array2(0)
					End If
					num2 += -1
					If num2 < 0 Then
						Exit For
					End If
					Continue For
				End If
				IL_105:
				Dim num10 As Integer = CInt(array(num6 * Me.int_1 + num4))
				If num10 < 0 Then
					num10 += 256
				End If
				Dim num11 As Integer = num6
				array2(num11) += num10 << num4 * 8
				num4 += 1
				GoTo IL_143
				IL_15E:
				array2(num6) = 0
				num5 = Me.int_1 - 1
				num4 = 0
				GoTo IL_143
				IL_1DB:
				num6 = 0
				GoTo IL_15E
			End While
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0))
			Return 0
			IL_1E3:
			Return array2(1)
			IL_1EA:
			Return array2(0)
		End Function

		' Token: 0x06000596 RID: 1430 RVA: 0x00034298 File Offset: 0x00032498
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_19(long_0 As Long) As Integer
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 31
			While True
				Try
					If(Me.int_2 And GClass3.int_21) = 1 Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
					GoTo IL_1C0
				Catch ex As IOException
					Console.Write("IO Exception")
					GoTo IL_1C0
				End Try
				GoTo IL_FD
				IL_13B:
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				If num4 > num5 Then
					num6 += 1
					If num6 <= 1 Then
						GoTo IL_156
					End If
					If(long_0 And 1L << (num2 And 31)) > 0L Then
						If array2(1) >= Me.int_0(0) Then
							GoTo IL_1C5
						End If
						num = array2(1)
					Else
						If array2(0) >= Me.int_0(0) Then
							GoTo IL_1CC
						End If
						num = array2(0)
					End If
					num2 += -1
					If num2 < 0 Then
						Exit For
					End If
					Continue For
				End If
				IL_FD:
				Dim num7 As Integer = CInt(array(num6 * Me.int_1 + num4))
				If num7 < 0 Then
					num7 += 256
				End If
				Dim num8 As Integer = num6
				array2(num8) += num7 << num4 * 8
				num4 += 1
				GoTo IL_13B
				IL_156:
				array2(num6) = 0
				num5 = Me.int_1 - 1
				num4 = 0
				GoTo IL_13B
				IL_1C0:
				num6 = 0
				GoTo IL_156
			End While
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0))
			Return 0
			IL_1C5:
			Return array2(1)
			IL_1CC:
			Return array2(0)
		End Function

		' Token: 0x06000597 RID: 1431 RVA: 0x000344B0 File Offset: 0x000326B0
		Public Function method_2(ipaddress_0 As IPAddress) As GClass4
			Return Me.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x06000598 RID: 1432 RVA: 0x000344D0 File Offset: 0x000326D0
		Public Function method_3(string_3 As String) As GClass4
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_5(ipaddress_)
		End Function

		' Token: 0x06000599 RID: 1433 RVA: 0x00034534 File Offset: 0x00032734
		Public Function method_4(string_3 As String) As GClass4
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x0600059A RID: 1434 RVA: 0x000345A0 File Offset: 0x000327A0
		Public Function method_5(ipaddress_0 As IPAddress) As GClass4
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Dim result As GClass4
			If CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3 Then
				Dim gclass As GClass6 = Me.method_11(ipaddress_0)
				If gclass Is Nothing Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_18(ipaddress_0) - GClass3.int_4
				If num = 0 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x0600059B RID: 1435 RVA: 0x0003463C File Offset: 0x0003283C
		Public Function method_6(long_0 As Long) As GClass4
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Dim result As GClass4
			If CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3 Then
				Dim gclass As GClass6 = Me.method_12(Conversions.ToString(long_0))
				If gclass Is Nothing Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_19(long_0) - GClass3.int_4
				If num = 0 Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x0600059C RID: 1436 RVA: 0x000346DC File Offset: 0x000328DC
		Public Function method_7(string_3 As String) As Integer
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return 0
			End Try
			Return Me.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x0600059D RID: 1437 RVA: 0x00034740 File Offset: 0x00032940
		Public Function method_8(ipaddress_0 As IPAddress) As Integer
			Return Me.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x0600059E RID: 1438 RVA: 0x00034760 File Offset: 0x00032960
		Public Function method_9(long_0 As Long) As Integer
			If Me.fileStream_0 Is Nothing Then
				Throw New Exception("Database has been closed.")
			End If
			Return Me.method_19(long_0) - Me.int_0(0)
		End Function

		' Token: 0x0600059F RID: 1439 RVA: 0x00034798 File Offset: 0x00032998
		Private Shared Function smethod_0(long_0 As Long) As Long
			Return(long_0 >> 0 And 255L) << 24 Or (long_0 >> 8 And 255L) << 16 Or (long_0 >> 16 And 255L) << 8 Or (long_0 >> 24 And 255L) << 0
		End Function

		' Token: 0x060005A0 RID: 1440 RVA: 0x000347EC File Offset: 0x000329EC
		Private Shared Function smethod_1(byte_2 As Byte()) As Long
			Dim num As Long = 0L
			Dim num2 As Integer = 0
			Do
				Dim num3 As Long = CLng(CULng(byte_2(num2)))
				If num3 < 0L Then
					num3 += 256L
				End If
				num += num3 << (3 - num2) * 8
				num2 += 1
			Loop While num2 <= 3
			Return num
		End Function

		' Token: 0x060005A1 RID: 1441 RVA: 0x0003484C File Offset: 0x00032A4C
		Private Shared Function smethod_2(byte_2 As Byte) As Integer
			Return CInt((byte_2 And Byte.MaxValue))
		End Function

		' Token: 0x060005A2 RID: 1442 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		Private Shared Function smethod_3(Of T)(ByRef gparam_0 As T, gparam_1 As T) As T
			gparam_0 = gparam_1
			Return gparam_1
		End Function

		' Token: 0x040002D5 RID: 725
		Private byte_0 As Byte

		' Token: 0x040002D6 RID: 726
		Private byte_1 As Byte()

		' Token: 0x040002D7 RID: 727
		Private fileStream_0 As FileStream

		' Token: 0x040002D8 RID: 728
		Private Shared gclass4_0 As GClass4 = New GClass4("--", "N/A")

		' Token: 0x040002D9 RID: 729
		Private gclass5_0 As GClass5

		' Token: 0x040002DA RID: 730
		Private int_0 As Integer()

		' Token: 0x040002DB RID: 731
		Private int_1 As Integer

		' Token: 0x040002DC RID: 732
		Private Shared int_10 As Integer = 3

		' Token: 0x040002DD RID: 733
		Private Shared int_11 As Integer = 4

		' Token: 0x040002DE RID: 734
		Private Shared int_12 As Integer = 4

		' Token: 0x040002DF RID: 735
		Private Shared int_13 As Integer = 1000

		' Token: 0x040002E0 RID: 736
		Private Shared int_14 As Integer = 360

		' Token: 0x040002E1 RID: 737
		Private Shared int_15 As Integer = 16700000

		' Token: 0x040002E2 RID: 738
		Private Shared int_16 As Integer = 16000000

		' Token: 0x040002E3 RID: 739
		Private Shared int_17 As Integer = 1

		' Token: 0x040002E4 RID: 740
		Private Shared int_18 As Integer = 677

		' Token: 0x040002E5 RID: 741
		Private Shared int_19 As Integer = 1353

		' Token: 0x040002E6 RID: 742
		Private int_2 As Integer

		' Token: 0x040002E7 RID: 743
		Public Shared int_20 As Integer = 0

		' Token: 0x040002E8 RID: 744
		Public Shared int_21 As Integer = 1

		' Token: 0x040002E9 RID: 745
		Public Shared int_22 As Integer = 0

		' Token: 0x040002EA RID: 746
		Public Shared int_23 As Integer = 1

		' Token: 0x040002EB RID: 747
		Public Shared int_24 As Integer = 2

		' Token: 0x040002EC RID: 748
		Public Shared int_25 As Integer = 3

		' Token: 0x040002ED RID: 749
		Private int_3 As Integer

		' Token: 0x040002EE RID: 750
		Private Shared int_4 As Integer = 16776960

		' Token: 0x040002EF RID: 751
		Private Shared int_5 As Integer = 16700000

		' Token: 0x040002F0 RID: 752
		Private Shared int_6 As Integer = 20

		' Token: 0x040002F1 RID: 753
		Private Shared int_7 As Integer = 100

		' Token: 0x040002F2 RID: 754
		Private Shared int_8 As Integer = 100

		' Token: 0x040002F3 RID: 755
		Private Shared int_9 As Integer = 3

		' Token: 0x040002F4 RID: 756
		Private object_0 As Object

		' Token: 0x040002F5 RID: 757
		Private string_0 As String

		' Token: 0x040002F6 RID: 758
		Public Shared string_1 As String() = New String() { "--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF", "BQ", "SS", "O1" }

		' Token: 0x040002F7 RID: 759
		Private Shared string_2 As String() = New String() { "N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other" }
	End Class
End Namespace
