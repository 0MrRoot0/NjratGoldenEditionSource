Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My.Resources
	' Token: 0x0200003E RID: 62
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<CompilerGenerated()>
	Friend NotInheritable Module Resources
		' Token: 0x170001EC RID: 492
		' (get) Token: 0x06000600 RID: 1536 RVA: 0x00036E9C File Offset: 0x0003509C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("NJRAT.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000601 RID: 1537 RVA: 0x00036EE0 File Offset: 0x000350E0
		' (set) Token: 0x06000602 RID: 1538 RVA: 0x00003A16 File Offset: 0x00001C16
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x06000603 RID: 1539 RVA: 0x00036EF4 File Offset: 0x000350F4
		Friend ReadOnly Property bullet_arrow_down As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_down", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x06000604 RID: 1540 RVA: 0x00036F24 File Offset: 0x00035124
		Friend ReadOnly Property bullet_arrow_up As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_up", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x06000605 RID: 1541 RVA: 0x00036F54 File Offset: 0x00035154
		Friend ReadOnly Property control_pause_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_pause_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x06000606 RID: 1542 RVA: 0x00036F84 File Offset: 0x00035184
		Friend ReadOnly Property control_play_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_play_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x06000607 RID: 1543 RVA: 0x00036FB4 File Offset: 0x000351B4
		Friend ReadOnly Property icon As Icon
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("icon", Resources.resourceCulture))
				Return CType(objectValue, Icon)
			End Get
		End Property

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x06000608 RID: 1544 RVA: 0x00036FE4 File Offset: 0x000351E4
		Friend ReadOnly Property JPEG As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("JPEG", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x06000609 RID: 1545 RVA: 0x00037014 File Offset: 0x00035214
		Friend ReadOnly Property notf As String
			Get
				Return Resources.ResourceManager.GetString("notf", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x0400033C RID: 828
		Private resourceMan As ResourceManager

		' Token: 0x0400033D RID: 829
		Private resourceCulture As CultureInfo
	End Module
End Namespace
