using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXDocumentViewerExternalRibbon.Controllers {
    public class HomeController : Controller {
        readonly DXDocumentViewerExternalRibbon.Reports.XtraReport1 report = new DXDocumentViewerExternalRibbon.Reports.XtraReport1();

        public ActionResult Index() {
            return View();
        }

        public ActionResult ReportPartial() {
            return PartialView("_ReportPartial", report);
        }

        public ActionResult ReportPartialExport() {
            return DocumentViewerExtension.ExportTo(report, Request);
        }
    }
}
