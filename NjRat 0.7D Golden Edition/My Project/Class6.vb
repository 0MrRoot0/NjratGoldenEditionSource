Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000025 RID: 37
	Friend NotInheritable Class Class6
		' Token: 0x06000553 RID: 1363 RVA: 0x0000253A File Offset: 0x0000073A
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000554 RID: 1364
		Public Declare Function memcpy Lib "msvcrt.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, int_0 As Integer) As IntPtr

		' Token: 0x06000555 RID: 1365 RVA: 0x0002B3DC File Offset: 0x000295DC
		Public Shared Function smethod_0(int_0 As Integer, int_1 As Integer) As String
			Dim result As String
			If int_1 = 0 Then
				result = "%00.0"
			Else
				result = (Double.Parse(Conversions.ToString(int_0)) / Double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100")
			End If
			Return result
		End Function

		' Token: 0x06000556 RID: 1366 RVA: 0x0002B440 File Offset: 0x00029640
		Public Shared Function smethod_1(int_0 As Integer, int_1 As Integer) As Integer
			Dim result As Integer
			If int_1 = 0 Then
				result = 0
			Else
				result = CInt(Math.Round(Math.Round(CDbl(int_0) / CDbl(int_1) * 100.0)))
			End If
			Return result
		End Function

		' Token: 0x06000557 RID: 1367 RVA: 0x0002B474 File Offset: 0x00029674
		Public Shared Function smethod_10(string_0 As String) As Form
			Return MyProject.Application.OpenForms(string_0)
		End Function

		' Token: 0x06000558 RID: 1368 RVA: 0x0002B494 File Offset: 0x00029694
		Public Shared Function smethod_11(ByRef string_0 As String) As Byte()
			Return Encoding.[Default].GetBytes(string_0)
		End Function

		' Token: 0x06000559 RID: 1369 RVA: 0x0002B4B0 File Offset: 0x000296B0
		Public Shared Function smethod_12(ByRef byte_0 As Byte()) As String
			Return Encoding.[Default].GetString(byte_0)
		End Function

		' Token: 0x0600055A RID: 1370 RVA: 0x0002B4CC File Offset: 0x000296CC
		Public Shared Function smethod_13() As String
			Return MyProject.Computer.Clock.LocalTime.ToString("[hh:mm:ss]")
		End Function

		' Token: 0x0600055B RID: 1371 RVA: 0x0002B4F8 File Offset: 0x000296F8
		Public Shared Function smethod_14(ByRef string_0 As String) As String
			Return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
		End Function

		' Token: 0x0600055C RID: 1372 RVA: 0x0002B518 File Offset: 0x00029718
		Public Shared Function smethod_15(int_0 As Integer, int_1 As Integer, bool_0 As Boolean) As Integer
			Class6.long_0 = CLng(Math.Round(Math.Round(CDbl(Class6.long_0) + 333.33)))
			Dim random As Random = New Random(CInt(Class6.long_0))
			Return random.[Next](int_0, int_1 + 1)
		End Function

		' Token: 0x0600055D RID: 1373 RVA: 0x0002B560 File Offset: 0x00029760
		Public Shared Function smethod_16(string_0 As String) As String
			Dim num As Integer = 0
			Dim result As String
			While True
				Try
					Dim bytes As Byte() = Convert.FromBase64String(string_0)
					result = Encoding.UTF8.GetString(bytes)
					Exit Try
				Catch ex As Exception
					num += 1
					If num = 3 Then
						result = Nothing
						Exit Try
					End If
					string_0 += "="
				End Try
			End While
			Return result
		End Function

		' Token: 0x0600055E RID: 1374 RVA: 0x0002B5DC File Offset: 0x000297DC
		Public Shared Function smethod_17(long_1 As Long) As String
			Dim result As String
			If long_1.ToString().Length < 4 Then
				result = Conversions.ToString(long_1) + " Bytes"
			Else
				Dim str As String = String.Empty
				Dim num As Double = CDbl(long_1) / 1024.0
				If num < 1024.0 Then
					str = "KB"
				Else
					num /= 1024.0
					If num < 1024.0 Then
						str = "MB"
					Else
						num /= 1024.0
						str = "GB"
					End If
				End If
				result = num.ToString(".0") + " " + str
			End If
			Return result
		End Function

		' Token: 0x0600055F RID: 1375 RVA: 0x0002B684 File Offset: 0x00029884
		Public Shared Function smethod_2(string_0 As String, string_1 As String) As String
			Dim result As String
			Try
				result = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\" + Class7.string_0).GetValue(string_0, string_1)))
			Catch ex As Exception
				result = string_1
			End Try
			Return result
		End Function

		' Token: 0x06000560 RID: 1376 RVA: 0x0002B6F8 File Offset: 0x000298F8
		Public Shared Sub smethod_3(string_0 As String, string_1 As String)
			If string_1 = Nothing Then
				string_1 = String.Empty
			End If
			Try
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\" + Class7.string_0).SetValue(string_0, string_1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000561 RID: 1377 RVA: 0x0002B76C File Offset: 0x0002996C
		Public Shared Function smethod_4(string_0 As String) As String
			Return Class6.smethod_5(Class6.smethod_11(string_0))
		End Function

		' Token: 0x06000562 RID: 1378 RVA: 0x0002B788 File Offset: 0x00029988
		Public Shared Function smethod_5(byte_0 As Byte()) As String
			byte_0 = New MD5CryptoServiceProvider().ComputeHash(byte_0)
			Dim text As String = String.Empty
			For Each b As Byte In byte_0
				text += b.ToString("x2")
			Next
			Return text
		End Function

		' Token: 0x06000563 RID: 1379 RVA: 0x0002B7D8 File Offset: 0x000299D8
		Public Shared Function smethod_6(int_0 As Integer) As String
			Dim random As Random = New Random()
			Dim text As String = String.Empty
			Dim text2 As String = "abcdefghijklmnopqrstuvwxyz"
			For i As Integer = 1 To int_0
				text += Conversions.ToString(text2(random.[Next](0, text2.Length)))
			Next
			Return text
		End Function

		' Token: 0x06000564 RID: 1380 RVA: 0x0002B834 File Offset: 0x00029A34
		Public Shared Function smethod_7(string_0 As String, treeNodeCollection_0 As TreeNodeCollection) As TreeNode
			If string_0.EndsWith("\") Then
				string_0 = string_0.Remove(string_0.Length - 1, 1)
			End If
			Dim treeNode As TreeNode = Nothing
			For Each key As String In Strings.Split(string_0, "\", -1, CompareMethod.Binary)
				treeNode = treeNodeCollection_0(key)
				treeNodeCollection_0 = treeNode.Nodes
			Next
			Return treeNode
		End Function

		' Token: 0x06000565 RID: 1381 RVA: 0x0002B89C File Offset: 0x00029A9C
		Public Shared Function smethod_8(byte_0 As Byte(), ByRef bool_0 As Boolean) As Byte()
			Dim result As Byte()
			If bool_0 Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
				gzipStream.Write(byte_0, 0, byte_0.Length)
				gzipStream.Dispose()
				memoryStream.Position = 0L
				Dim array As Byte() = New Byte(CInt(memoryStream.Length) + 1 - 1 + 1 - 1) {}
				memoryStream.Read(array, 0, array.Length)
				memoryStream.Dispose()
				result = array
			Else
				Dim memoryStream2 As MemoryStream = New MemoryStream(byte_0)
				Dim gzipStream2 As GZipStream = New GZipStream(memoryStream2, CompressionMode.Decompress)
				Dim array2 As Byte() = New Byte(3) {}
				memoryStream2.Position = memoryStream2.Length - 5L
				memoryStream2.Read(array2, 0, 4)
				Dim num As Integer = BitConverter.ToInt32(array2, 0)
				memoryStream2.Position = 0L
				Dim array3 As Byte() = New Byte(num - 1 + 1 - 1 + 1 - 1) {}
				gzipStream2.Read(array3, 0, num)
				gzipStream2.Dispose()
				memoryStream2.Dispose()
				result = array3
			End If
			Return result
		End Function

		' Token: 0x06000566 RID: 1382 RVA: 0x0002B990 File Offset: 0x00029B90
		Public Shared Function smethod_9(byte_0 As Byte(), string_0 As String) As Array
			Dim list As List(Of Byte()) = New List(Of Byte())()
			Dim num As Integer = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))))
			While num > -1 And num + string_0.Length <= byte_0.Length
				Dim array As Byte() = New Byte(string_0.Length - 1 + 1 - 1 + 1 - 1) {}
				Dim num2 As Integer = 0
				Dim num3 As Integer = num + string_0.Length - 1
				For i As Integer = num To num3
					array(num2) = byte_0(i)
					num2 += 1
				Next
				If Operators.CompareString(Class6.smethod_12(array), string_0, False) = 0 Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					memoryStream.Write(byte_0, 0, num)
					list.Add(memoryStream.ToArray())
					memoryStream.Dispose()
					memoryStream = New MemoryStream()
					memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length))
					list.Add(memoryStream.ToArray())
					memoryStream.Dispose()
					IL_106:
					If list.Count = 0 Then
						list.Add(byte_0)
					End If
					Return list.ToArray()
				End If
				num = Array.IndexOf(Of Byte)(byte_0, CByte(Strings.Asc(string_0(0))), num + 1)
			End While
			GoTo IL_106
		End Function

		' Token: 0x04000289 RID: 649
		Public Shared long_0 As Long = 0L
	End Class
End Namespace
