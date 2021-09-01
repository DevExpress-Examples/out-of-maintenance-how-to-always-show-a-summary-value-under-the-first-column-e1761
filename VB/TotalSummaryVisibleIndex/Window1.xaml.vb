Imports System.Collections.Generic
Imports System.Windows

Namespace TotalSummaryVisibleIndex
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim list As New List(Of SiteInfo)()
			list.Add(New SiteInfo() With {
				.Category = "Component vendor",
				.Hyperlink = "http://devexpress.com",
				.Name = "Developer Express"
			})
			list.Add(New SiteInfo() With {
				.Category = "Search engine",
				.Hyperlink = "http://google.com",
				.Name = "Google"
			})
			list.Add(New SiteInfo() With {
				.Category = "Documentation",
				.Hyperlink = "http://msdn.com",
				.Name = "MSDN"
			})
			grid.ItemsSource = list
		End Sub
	End Class
	Public Class SiteInfo
		Public Property Category() As String
		Public Property Hyperlink() As String
		Public Property Name() As String
	End Class
End Namespace