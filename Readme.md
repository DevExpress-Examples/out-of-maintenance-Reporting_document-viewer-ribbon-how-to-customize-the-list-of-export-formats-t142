<!-- default file list -->
*Files to look at*:

* **[Index.cshtml](./CS/DXDocumentViewerExternalRibbon/Views/Home/Index.cshtml)**
<!-- default file list end -->
# Document Viewer - Ribbon - How to customize the list of export formats


<p>This example illustrates how to hide specific <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument1302">export formats</a> available in the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument10008">Document Viewer toolbar</a>. To accomplish this task, create an external Ribbon toolbar and assign it to the Document Viewer. <br><br>To add a Ribbon extension to a view, call the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcUIExtensionsFactory_Ribbontopic(pB7XtA)">ExtensionsFactory.Ribbon</a> helper method. This method's parameter provides access to the Ribbon settings provided by the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebMvcRibbonSettingstopic">RibbonSettings</a> class allowing you to completely customize the extension. For this example, obtain the Document Viewer's ribbon items using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcDocumentViewerExtension_DefaultRibbonTabstopic">DocumentViewerExtension.DefaultRibbonTabs</a> property and hide items corresponding to the required export formats.<br><br>To link the created Ribbon with the Document Viewer, set the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcDocumentViewerSettings_ToolbarModetopic">DocumentViewerSettings.ToolbarMode</a> property to <strong>ExternalRibbon</strong> and specify the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcDocumentViewerSettings_AssociatedRibbonNametopic">DocumentViewerSettings.AssociatedRibbonName</a> property.</p>

<br/>


