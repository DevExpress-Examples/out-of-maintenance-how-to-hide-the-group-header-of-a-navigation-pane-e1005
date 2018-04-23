Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace CustomNavigation
    Public Class CustomNavPaneViewInfo
        Inherits SkinNavigationPaneViewInfo

        Public Sub New(ByVal navBar As NavBarControl)
            MyBase.New(navBar)
        End Sub
        Protected Overrides Function CreateNavPaneHeaderPainter() As NavigationPaneHeaderPainter
            Return New CustomNavPaneHeaderPainter(Me)
        End Function
    End Class
    Public Class CustomNavPaneHeaderPainter
        Inherits SkinNavigationPaneHeaderPainter

        Public Sub New(ByVal npvi As NavigationPaneViewInfo)
            MyBase.New(npvi)
        End Sub

        Public Overrides Function CalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
            Return Rectangle.Empty
        End Function
    End Class
    Public Class CustomNavPaneViewInfoRegistrator
        Inherits SkinNavigationPaneViewInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "CustomNavPaneView"
            End Get
        End Property
        Public Overrides Function CreateViewInfo(ByVal navBar As NavBarControl) As NavBarViewInfo
            Return New CustomNavPaneViewInfo(navBar)
        End Function

    End Class
End Namespace
