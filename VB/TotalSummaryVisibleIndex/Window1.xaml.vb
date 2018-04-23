Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace TotalSummaryVisibleIndex
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim list As New List(Of SiteInfo)()
			list.Add(New SiteInfo() With {.Category = "Component vendor", .Hyperlink = "http://devexpress.com", .Name = "Developer Express"})
			list.Add(New SiteInfo() With {.Category = "Search engine", .Hyperlink = "http://google.com", .Name = "Google"})
			list.Add(New SiteInfo() With {.Category = "Documentation", .Hyperlink = "http://msdn.com", .Name = "MSDN"})
			grid.DataSource = list
		End Sub
	End Class
	Public Class SiteInfo
		Private privateCategory As String
		Public Property Category() As String
			Get
				Return privateCategory
			End Get
			Set(ByVal value As String)
				privateCategory = value
			End Set
		End Property
		Private privateHyperlink As String
		Public Property Hyperlink() As String
			Get
				Return privateHyperlink
			End Get
			Set(ByVal value As String)
				privateHyperlink = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class

End Namespace
