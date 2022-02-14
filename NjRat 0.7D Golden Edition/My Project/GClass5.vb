Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200002F RID: 47
	Public NotInheritable Class GClass5
		' Token: 0x060005A7 RID: 1447 RVA: 0x000038A9 File Offset: 0x00001AA9
		Public Sub New(string_1 As String)
			Me.string_0 = string_1
		End Sub

		' Token: 0x060005A8 RID: 1448 RVA: 0x00034928 File Offset: 0x00032B28
		Public Function method_0() As Integer
			Dim result As Integer
			If Me.string_0 = Nothing Or Operators.CompareString(Me.string_0, String.Empty, False) = 0 Then
				result = GClass5.int_0
			Else
				result = Convert.ToInt32(Me.string_0.Substring(4, 3)) - 105
			End If
			Return result
		End Function

		' Token: 0x060005A9 RID: 1449 RVA: 0x000038B8 File Offset: 0x00001AB8
		Public Function method_1() As Boolean
			Return Me.string_0.IndexOf("FREE") < 0
		End Function

		' Token: 0x060005AA RID: 1450 RVA: 0x00034974 File Offset: 0x00032B74
		Public Function method_2() As DateTime
			Dim num As Integer = Me.string_0.Length - 10
			For i As Integer = 0 To num
				If Char.IsWhiteSpace(Me.string_0(i)) Then
					Dim s As String = Me.string_0.Substring(i + 1, 8)
					Try
						Return DateTime.ParseExact(s, "yyyyMMdd", Nothing)
					Catch ex As Exception
						Dim ex2 As Exception = ex
						Console.Write(ex2.Message)
					End Try
					IL_7F:
					Return DateTime.Now
				End If
			Next
			GoTo IL_7F
		End Function

		' Token: 0x060005AB RID: 1451 RVA: 0x00034A18 File Offset: 0x00032C18
		Public Function method_3() As String
			Return Me.string_0
		End Function

		' Token: 0x040002FA RID: 762
		Public Shared int_0 As Integer = 1

		' Token: 0x040002FB RID: 763
		Public Shared int_1 As Integer = 7

		' Token: 0x040002FC RID: 764
		Public Shared int_10 As Integer = 11

		' Token: 0x040002FD RID: 765
		Public Shared int_11 As Integer = 12

		' Token: 0x040002FE RID: 766
		Public Shared int_12 As Integer = 21

		' Token: 0x040002FF RID: 767
		Public Shared int_13 As Integer = 22

		' Token: 0x04000300 RID: 768
		Public Shared int_14 As Integer = 23

		' Token: 0x04000301 RID: 769
		Public Shared int_15 As Integer = 24

		' Token: 0x04000302 RID: 770
		Public Shared int_16 As Integer = 30

		' Token: 0x04000303 RID: 771
		Public Shared int_17 As Integer = 31

		' Token: 0x04000304 RID: 772
		Public Shared int_18 As Integer = 32

		' Token: 0x04000305 RID: 773
		Public Shared int_19 As Integer = 33

		' Token: 0x04000306 RID: 774
		Public Shared int_2 As Integer = 3

		' Token: 0x04000307 RID: 775
		Public Shared int_3 As Integer = 6

		' Token: 0x04000308 RID: 776
		Public Shared int_4 As Integer = 2

		' Token: 0x04000309 RID: 777
		Public Shared int_5 As Integer = 5

		' Token: 0x0400030A RID: 778
		Public Shared int_6 As Integer = 4

		' Token: 0x0400030B RID: 779
		Public Shared int_7 As Integer = 8

		' Token: 0x0400030C RID: 780
		Public Shared int_8 As Integer = 9

		' Token: 0x0400030D RID: 781
		Public Shared int_9 As Integer = 10

		' Token: 0x0400030E RID: 782
		Private string_0 As String
	End Class
End Namespace
