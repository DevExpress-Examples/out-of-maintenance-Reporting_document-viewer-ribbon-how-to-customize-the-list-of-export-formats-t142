<!-- default file list -->
*Files to look at*:

* **[Index.cshtml](./CS/DXDocumentViewerExternalRibbon/Views/Home/Index.cshtml)**
<!-- default file list end -->
# Document Viewer - Ribbon - How to customize the list of export formats


This example illustrates how to hide specific <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument1302">export formats</a> available in the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument10008">Document Viewer toolbar</a>. To accomplish this task, create an external Ribbon toolbar and assign it to the Document Viewer. 

To add a Ribbon to a view, call the [ExtensionsFactory.Ribbon](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.UI.ExtensionsFactory.Ribbon.overloads) helper method. For this example, obtain the Document Viewer's ribbon items using the [DocumentViewerExtension.DefaultRibbonTabs](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.DocumentViewerExtension.DefaultRibbonTabs) property and hide items for certain export formats.

To link the created Ribbon to the Document Viewer, set the [DocumentViewerSettings.ToolbarMode](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.DocumentViewerSettings.ToolbarMode) property to <strong>ExternalRibbon</strong> and specify the [DocumentViewerSettings.AssociatedRibbonName](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.DocumentViewerSettings.AssociatedRibbonName) property.




