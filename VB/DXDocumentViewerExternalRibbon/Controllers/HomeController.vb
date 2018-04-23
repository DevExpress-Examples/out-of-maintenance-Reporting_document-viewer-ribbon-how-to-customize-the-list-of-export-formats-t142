Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DXDocumentViewerExternalRibbon.Controllers
    Public Class HomeController
        Inherits Controller

        Private ReadOnly report As New DXDocumentViewerExternalRibbon.Reports.XtraReport1()

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function ReportPartial() As ActionResult
            Return PartialView("_ReportPartial", report)
        End Function

        Public Function ReportPartialExport() As ActionResult
            Return DocumentViewerExtension.ExportTo(report, Request)
        End Function
    End Class
End Namespace
