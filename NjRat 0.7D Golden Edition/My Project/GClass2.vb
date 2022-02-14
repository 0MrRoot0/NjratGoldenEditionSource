Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x0200002C RID: 44
	<SuppressUnmanagedCodeSecurity()>
	Public NotInheritable Class GClass2
		' Token: 0x06000584 RID: 1412 RVA: 0x0000253A File Offset: 0x0000073A
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000585 RID: 1413
		Public Declare Function BeginUpdateResource Lib "kernel32" (string_0 As String, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As IntPtr

		' Token: 0x06000586 RID: 1414
		Public Declare Function EndUpdateResource Lib "kernel32" (intptr_0 As IntPtr, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x06000587 RID: 1415
		Public Declare Function UpdateResource Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, intptr_2 As IntPtr, short_0 As Short, <MarshalAs(UnmanagedType.LPArray, SizeConst := 0, SizeParamIndex := 5S)> byte_0 As Byte(), int_0 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Class
End Namespace
