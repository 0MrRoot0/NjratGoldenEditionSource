Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000040 RID: 64
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x0600060E RID: 1550 RVA: 0x000370A8 File Offset: 0x000352A8
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
