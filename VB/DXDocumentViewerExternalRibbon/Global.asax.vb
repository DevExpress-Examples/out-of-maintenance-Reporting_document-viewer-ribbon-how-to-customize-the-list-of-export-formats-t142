Imports System
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DXDocumentViewerExternalRibbon

    ' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    ' visit http://go.microsoft.com/?LinkId=9394801
    Public Class MvcApplication
        Inherits HttpApplication

        Protected Sub Application_Start()
            Call AreaRegistration.RegisterAllAreas()
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)
            ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
            DevExpress.Web.ASPxClasses.ASPxWebControl.CallbackError += AddressOf Application_Error
        End Sub

        Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            Dim exception As Exception = HttpContext.Current.Server.GetLastError()
        'TODO: Handle Exception
        End Sub
    End Class
End Namespace
