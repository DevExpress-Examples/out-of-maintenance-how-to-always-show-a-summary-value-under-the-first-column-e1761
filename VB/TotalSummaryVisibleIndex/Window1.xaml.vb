Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports System.Windows.Forms

Namespace TotalSummaryVisibleIndex


    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window
        Public Sub New()
            InitializeComponent()
            Dim list As List(Of SiteInfo) = New List(Of SiteInfo)()
            Dim si As SiteInfo = New SiteInfo()
            With si
                .Category = "Component vendor"
                .Hyperlink = "http://devexpress.com"
                .Name = "Developer Express"
            End With
            list.Add(si)
            si = New SiteInfo()
            With si
                .Category = "Search engine"
                .Hyperlink = "http://google.com"
                .Name = "Google"
            End With
            list.Add(si)
            si = New SiteInfo()
            With si
                .Category = "Documentation"
                .Hyperlink = "http://msdn.com"
                .Name = "MSDN"
            End With
            list.Add(si)
            grid.DataSource = list
        End Sub
    End Class
    Public Class SiteInfo
        Private _category As String
        Public Property Category() As String
            Get
                Return _category
            End Get
            Set(ByVal value As String)
                _category = value
            End Set
        End Property
        Private _link As String
        Public Property Hyperlink() As String
            Get
                Return _link
            End Get
            Set(ByVal value As String)
                _link = value
            End Set
        End Property
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
    End Class
End Namespace

