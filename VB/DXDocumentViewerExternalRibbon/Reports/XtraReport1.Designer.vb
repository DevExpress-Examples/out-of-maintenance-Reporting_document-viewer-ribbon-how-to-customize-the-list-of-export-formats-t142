Namespace DXDocumentViewerExternalRibbon.Reports

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim shapePolygon1 As DevExpress.XtraPrinting.Shape.ShapePolygon = New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeStar1 As DevExpress.XtraPrinting.Shape.ShapeStar = New DevExpress.XtraPrinting.Shape.ShapeStar()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrShape2 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrShape2, Me.xrShape1, Me.xrPageBreak1})
            Me.Detail.HeightF = 221F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.PageFooter.HeightF = 100F
            Me.PageFooter.Name = "PageFooter"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(407F, 10.00001F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100F, 23F)
            ' 
            ' xrShape2
            ' 
            Me.xrShape2.FillColor = System.Drawing.Color.FromArgb((CInt(((CByte((205)))))), (CInt(((CByte((133)))))), (CInt(((CByte((63)))))))
            Me.xrShape2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 123F)
            Me.xrShape2.Name = "xrShape2"
            shapePolygon1.NumberOfSides = 4
            Me.xrShape2.Shape = shapePolygon1
            Me.xrShape2.SizeF = New System.Drawing.SizeF(100F, 98F)
            ' 
            ' xrPageBreak1
            ' 
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 110.2084F)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            ' 
            ' xrShape1
            ' 
            Me.xrShape1.FillColor = System.Drawing.Color.FromArgb((CInt(((CByte((205)))))), (CInt(((CByte((92)))))), (CInt(((CByte((92)))))))
            Me.xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrShape1.Name = "xrShape1"
            shapeStar1.StarPointCount = 5
            Me.xrShape1.Shape = shapeStar1
            Me.xrShape1.SizeF = New System.Drawing.SizeF(100F, 86.83334F)
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter})
            Me.PageHeight = 504
            Me.PageWidth = 717
            Me.PaperKind = System.Drawing.Printing.PaperKind.B6JisRotated
            Me.Version = "14.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrShape2 As DevExpress.XtraReports.UI.XRShape

        Private xrShape1 As DevExpress.XtraReports.UI.XRShape

        Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    End Class
End Namespace
