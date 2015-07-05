using System.Drawing;
namespace WinViewerDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle1 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle2 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle3 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle4 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle5 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle6 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle7 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle8 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle9 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            RasterEdge.XImage.WinFormsViewer.AnnoStyle annoStyle10 = new RasterEdge.XImage.WinFormsViewer.AnnoStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsConvertToTiff = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAnnotation = new System.Windows.Forms.ToolStrip();
            this.tsText = new System.Windows.Forms.ToolStripButton();
            this.tsFreehand = new System.Windows.Forms.ToolStripButton();
            this.tsLine = new System.Windows.Forms.ToolStripButton();
            this.tsLines = new System.Windows.Forms.ToolStripButton();
            this.tsFilledRetangle = new System.Windows.Forms.ToolStripButton();
            this.tsRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsHighLight = new System.Windows.Forms.ToolStripButton();
            this.tsEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsPolygon = new System.Windows.Forms.ToolStripButton();
            this.tsRubberStamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBurn = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteAnno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.tabViewer = new System.Windows.Forms.TabPage();
            this.toolStripViewer = new System.Windows.Forms.ToolStrip();
            this.tsTop = new System.Windows.Forms.ToolStripButton();
            this.tsUp = new System.Windows.Forms.ToolStripButton();
            this.tsPageIndex = new System.Windows.Forms.ToolStripComboBox();
            this.tsDown = new System.Windows.Forms.ToolStripButton();
            this.tsEnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsZoomIndex = new System.Windows.Forms.ToolStripComboBox();
            this.tsZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRotate90 = new System.Windows.Forms.ToolStripButton();
            this.tsRotate270 = new System.Windows.Forms.ToolStripButton();
            this.tsRotate180 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tabAnnotation = new System.Windows.Forms.TabPage();
            this.tabAddon = new System.Windows.Forms.TabPage();
            this.toolStripAddon = new System.Windows.Forms.ToolStrip();
            this.cbbOCRLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbOCRImageScale = new System.Windows.Forms.ToolStripTextBox();
            this.tsOCR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReadBarcode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.winViewer1 = new RasterEdge.XImage.WinFormsViewer.WinViewer();
            this.toolStripMain.SuspendLayout();
            this.toolStripAnnotation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabViewer.SuspendLayout();
            this.toolStripViewer.SuspendLayout();
            this.tabAnnotation.SuspendLayout();
            this.tabAddon.SuspendLayout();
            this.toolStripAddon.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(37, 32);
            this.toolStripMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.tsSaveFile,
            this.toolStripSeparator1,
            this.tsPrint,
            this.tsConvertToTiff,
            this.toolStripSeparator8});
            this.toolStripMain.Location = new System.Drawing.Point(3, 3);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(1280, 73);
            this.toolStripMain.TabIndex = 28;
            this.toolStripMain.TabStop = true;
            this.toolStripMain.Text = "File";
            // 
            // tsOpen
            // 
            this.tsOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsOpen.Image")));
            this.tsOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(48, 70);
            this.tsOpen.Text = "Open File";
            this.tsOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsOpen.MouseLeave += new System.EventHandler(this.tsOpen_MouseLeave);
            this.tsOpen.MouseEnter += new System.EventHandler(this.tsOpen_MouseEnter);
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsSaveFile
            // 
            this.tsSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveFile.Image")));
            this.tsSaveFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveFile.Name = "tsSaveFile";
            this.tsSaveFile.Size = new System.Drawing.Size(47, 70);
            this.tsSaveFile.Text = "Save File";
            this.tsSaveFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsSaveFile.MouseLeave += new System.EventHandler(this.tsSaveFile_MouseLeave);
            this.tsSaveFile.MouseEnter += new System.EventHandler(this.tsSaveFile_MouseEnter);
            this.tsSaveFile.Click += new System.EventHandler(this.tsSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // tsPrint
            // 
            this.tsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsPrint.Image")));
            this.tsPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(43, 70);
            this.tsPrint.Text = "Print File";
            this.tsPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsPrint.MouseLeave += new System.EventHandler(this.tsPrint_MouseLeave);
            this.tsPrint.MouseEnter += new System.EventHandler(this.tsPrint_MouseEnter);
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsConvertToTiff
            // 
            this.tsConvertToTiff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsConvertToTiff.Image = ((System.Drawing.Image)(resources.GetObject("tsConvertToTiff.Image")));
            this.tsConvertToTiff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsConvertToTiff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsConvertToTiff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsConvertToTiff.Name = "tsConvertToTiff";
            this.tsConvertToTiff.Size = new System.Drawing.Size(35, 70);
            this.tsConvertToTiff.Text = "Convert to Tiff";
            this.tsConvertToTiff.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsConvertToTiff.MouseLeave += new System.EventHandler(this.tsConvertToTiff_MouseLeave);
            this.tsConvertToTiff.MouseEnter += new System.EventHandler(this.tsConvertToTiff_MouseEnter);
            this.tsConvertToTiff.Click += new System.EventHandler(this.tsConvertToTiff_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripAnnotation
            // 
            this.toolStripAnnotation.AutoSize = false;
            this.toolStripAnnotation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripAnnotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripAnnotation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAnnotation.ImageScalingSize = new System.Drawing.Size(37, 32);
            this.toolStripAnnotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsText,
            this.tsFreehand,
            this.tsLine,
            this.tsLines,
            this.tsFilledRetangle,
            this.tsRectangle,
            this.tsHighLight,
            this.tsEllipse,
            this.tsPolygon,
            this.tsRubberStamp,
            this.toolStripSeparator3,
            this.tsBurn,
            this.tsDeleteAnno,
            this.toolStripSeparator5});
            this.toolStripAnnotation.Location = new System.Drawing.Point(3, 3);
            this.toolStripAnnotation.Name = "toolStripAnnotation";
            this.toolStripAnnotation.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripAnnotation.Size = new System.Drawing.Size(1280, 73);
            this.toolStripAnnotation.TabIndex = 29;
            this.toolStripAnnotation.Text = "Annotation";
            // 
            // tsText
            // 
            this.tsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsText.Image = ((System.Drawing.Image)(resources.GetObject("tsText.Image")));
            this.tsText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsText.Name = "tsText";
            this.tsText.Size = new System.Drawing.Size(39, 70);
            this.tsText.Text = "Text";
            this.tsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsText.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsText.MouseLeave += new System.EventHandler(this.tsText_MouseLeave);
            this.tsText.MouseEnter += new System.EventHandler(this.tsText_MouseEnter);
            this.tsText.Click += new System.EventHandler(this.tsText_Click);
            // 
            // tsFreehand
            // 
            this.tsFreehand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFreehand.Image = ((System.Drawing.Image)(resources.GetObject("tsFreehand.Image")));
            this.tsFreehand.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsFreehand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFreehand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFreehand.Name = "tsFreehand";
            this.tsFreehand.Size = new System.Drawing.Size(49, 70);
            this.tsFreehand.Text = "Freehand";
            this.tsFreehand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsFreehand.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsFreehand.MouseLeave += new System.EventHandler(this.tsFreehand_MouseLeave);
            this.tsFreehand.MouseEnter += new System.EventHandler(this.tsFreehand_MouseEnter);
            this.tsFreehand.Click += new System.EventHandler(this.tsFreehand_Click);
            // 
            // tsLine
            // 
            this.tsLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLine.Image = ((System.Drawing.Image)(resources.GetObject("tsLine.Image")));
            this.tsLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsLine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLine.Name = "tsLine";
            this.tsLine.Size = new System.Drawing.Size(37, 70);
            this.tsLine.Text = "Line";
            this.tsLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsLine.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsLine.MouseLeave += new System.EventHandler(this.tsLine_MouseLeave);
            this.tsLine.MouseEnter += new System.EventHandler(this.tsLine_MouseEnter);
            this.tsLine.Click += new System.EventHandler(this.tsLine_Click);
            // 
            // tsLines
            // 
            this.tsLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLines.Image = ((System.Drawing.Image)(resources.GetObject("tsLines.Image")));
            this.tsLines.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsLines.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLines.Name = "tsLines";
            this.tsLines.Size = new System.Drawing.Size(41, 70);
            this.tsLines.Text = "Polygon Lines";
            this.tsLines.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsLines.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsLines.MouseLeave += new System.EventHandler(this.tsLines_MouseLeave);
            this.tsLines.MouseEnter += new System.EventHandler(this.tsLines_MouseEnter);
            this.tsLines.Click += new System.EventHandler(this.tsLines_Click);
            // 
            // tsFilledRetangle
            // 
            this.tsFilledRetangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFilledRetangle.Image = ((System.Drawing.Image)(resources.GetObject("tsFilledRetangle.Image")));
            this.tsFilledRetangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsFilledRetangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFilledRetangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFilledRetangle.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsFilledRetangle.Name = "tsFilledRetangle";
            this.tsFilledRetangle.Size = new System.Drawing.Size(51, 67);
            this.tsFilledRetangle.Text = "Filled Rectangle";
            this.tsFilledRetangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsFilledRetangle.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsFilledRetangle.MouseLeave += new System.EventHandler(this.tsFilledRetangle_MouseLeave);
            this.tsFilledRetangle.MouseEnter += new System.EventHandler(this.tsFilledRetangle_MouseEnter);
            this.tsFilledRetangle.Click += new System.EventHandler(this.tsFilledRetangle_Click);
            // 
            // tsRectangle
            // 
            this.tsRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsRectangle.Image")));
            this.tsRectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRectangle.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsRectangle.Name = "tsRectangle";
            this.tsRectangle.Size = new System.Drawing.Size(51, 67);
            this.tsRectangle.Text = "Rectangle";
            this.tsRectangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsRectangle.MouseLeave += new System.EventHandler(this.tsRectangle_MouseLeave);
            this.tsRectangle.MouseEnter += new System.EventHandler(this.tsRectangle_MouseEnter);
            this.tsRectangle.Click += new System.EventHandler(this.tsRectangle_Click);
            // 
            // tsHighLight
            // 
            this.tsHighLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsHighLight.Image = ((System.Drawing.Image)(resources.GetObject("tsHighLight.Image")));
            this.tsHighLight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsHighLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsHighLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHighLight.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsHighLight.Name = "tsHighLight";
            this.tsHighLight.Size = new System.Drawing.Size(50, 67);
            this.tsHighLight.Text = "HightLight";
            this.tsHighLight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsHighLight.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsHighLight.MouseLeave += new System.EventHandler(this.tsHighLight_MouseLeave);
            this.tsHighLight.MouseEnter += new System.EventHandler(this.tsHighLight_MouseEnter);
            this.tsHighLight.Click += new System.EventHandler(this.tsHighLight_Click);
            // 
            // tsEllipse
            // 
            this.tsEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsEllipse.Image")));
            this.tsEllipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEllipse.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsEllipse.Name = "tsEllipse";
            this.tsEllipse.Size = new System.Drawing.Size(37, 67);
            this.tsEllipse.Text = "Ellipse";
            this.tsEllipse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsEllipse.MouseLeave += new System.EventHandler(this.tsEllipse_MouseLeave);
            this.tsEllipse.MouseEnter += new System.EventHandler(this.tsEllipse_MouseEnter);
            this.tsEllipse.Click += new System.EventHandler(this.tsEllipse_Click);
            // 
            // tsPolygon
            // 
            this.tsPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPolygon.Image = ((System.Drawing.Image)(resources.GetObject("tsPolygon.Image")));
            this.tsPolygon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsPolygon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPolygon.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsPolygon.Name = "tsPolygon";
            this.tsPolygon.Size = new System.Drawing.Size(41, 69);
            this.tsPolygon.Text = "Polygon";
            this.tsPolygon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsPolygon.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsPolygon.MouseLeave += new System.EventHandler(this.tsPolygon_MouseLeave);
            this.tsPolygon.MouseEnter += new System.EventHandler(this.tsPolygon_MouseEnter);
            this.tsPolygon.Click += new System.EventHandler(this.tsPolygon_Click);
            // 
            // tsRubberStamp
            // 
            this.tsRubberStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRubberStamp.Image = ((System.Drawing.Image)(resources.GetObject("tsRubberStamp.Image")));
            this.tsRubberStamp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRubberStamp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRubberStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRubberStamp.Name = "tsRubberStamp";
            this.tsRubberStamp.Size = new System.Drawing.Size(38, 70);
            this.tsRubberStamp.Text = "Rubber Stamp";
            this.tsRubberStamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRubberStamp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsRubberStamp.MouseLeave += new System.EventHandler(this.tsRubberStamp_MouseLeave);
            this.tsRubberStamp.MouseEnter += new System.EventHandler(this.tsRubberStamp_MouseEnter);
            this.tsRubberStamp.Click += new System.EventHandler(this.tsRubberStamp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
            // 
            // tsBurn
            // 
            this.tsBurn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBurn.Image = ((System.Drawing.Image)(resources.GetObject("tsBurn.Image")));
            this.tsBurn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBurn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBurn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBurn.Name = "tsBurn";
            this.tsBurn.Size = new System.Drawing.Size(31, 70);
            this.tsBurn.Text = "Burn  ";
            this.tsBurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBurn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsBurn.MouseLeave += new System.EventHandler(this.tsBurn_MouseLeave);
            this.tsBurn.MouseEnter += new System.EventHandler(this.tsBurn_MouseEnter);
            this.tsBurn.Click += new System.EventHandler(this.tsBurn_Click);
            // 
            // tsDeleteAnno
            // 
            this.tsDeleteAnno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteAnno.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteAnno.Image")));
            this.tsDeleteAnno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsDeleteAnno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteAnno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteAnno.Name = "tsDeleteAnno";
            this.tsDeleteAnno.Size = new System.Drawing.Size(55, 70);
            this.tsDeleteAnno.Text = "Delete Annotation";
            this.tsDeleteAnno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsDeleteAnno.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsDeleteAnno.MouseLeave += new System.EventHandler(this.tsDeleteAnno_MouseLeave);
            this.tsDeleteAnno.MouseEnter += new System.EventHandler(this.tsDeleteAnno_MouseEnter);
            this.tsDeleteAnno.Click += new System.EventHandler(this.tsDeleteAnno_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 73);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Controls.Add(this.tabViewer);
            this.tabControl1.Controls.Add(this.tabAnnotation);
            this.tabControl1.Controls.Add(this.tabAddon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1294, 105);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 50;
            this.tabControl1.TabStop = false;
            this.tabControl1.Tag = "";
            // 
            // tabFile
            // 
            this.tabFile.BackColor = System.Drawing.Color.Transparent;
            this.tabFile.Controls.Add(this.toolStripMain);
            this.tabFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabFile.ImageKey = "(none)";
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(1286, 79);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "File";
            this.tabFile.ToolTipText = "File tab";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // tabViewer
            // 
            this.tabViewer.Controls.Add(this.toolStripViewer);
            this.tabViewer.Location = new System.Drawing.Point(4, 22);
            this.tabViewer.Name = "tabViewer";
            this.tabViewer.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewer.Size = new System.Drawing.Size(1286, 79);
            this.tabViewer.TabIndex = 2;
            this.tabViewer.Text = "View";
            this.tabViewer.ToolTipText = "Viewer Tab";
            this.tabViewer.UseVisualStyleBackColor = true;
            // 
            // toolStripViewer
            // 
            this.toolStripViewer.AutoSize = false;
            this.toolStripViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripViewer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripViewer.ImageScalingSize = new System.Drawing.Size(37, 32);
            this.toolStripViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTop,
            this.tsUp,
            this.tsPageIndex,
            this.tsDown,
            this.tsEnd,
            this.toolStripSeparator2,
            this.tsZoomIndex,
            this.tsZoomOut,
            this.tsZoomIn,
            this.toolStripSeparator4,
            this.tsRotate90,
            this.tsRotate270,
            this.tsRotate180,
            this.toolStripSeparator7});
            this.toolStripViewer.Location = new System.Drawing.Point(3, 3);
            this.toolStripViewer.Name = "toolStripViewer";
            this.toolStripViewer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripViewer.Size = new System.Drawing.Size(1280, 73);
            this.toolStripViewer.TabIndex = 29;
            this.toolStripViewer.TabStop = true;
            this.toolStripViewer.Text = "Viewer";
            // 
            // tsTop
            // 
            this.tsTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTop.Image = ((System.Drawing.Image)(resources.GetObject("tsTop.Image")));
            this.tsTop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsTop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTop.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(48, 61);
            this.tsTop.Text = "Page Top";
            this.tsTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsTop.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsTop.MouseLeave += new System.EventHandler(this.tsTop_MouseLeave);
            this.tsTop.MouseEnter += new System.EventHandler(this.tsTop_MouseEnter);
            this.tsTop.Click += new System.EventHandler(this.tsTop_Click);
            // 
            // tsUp
            // 
            this.tsUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUp.Image = ((System.Drawing.Image)(resources.GetObject("tsUp.Image")));
            this.tsUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUp.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsUp.Name = "tsUp";
            this.tsUp.Size = new System.Drawing.Size(43, 61);
            this.tsUp.Text = "Page Up";
            this.tsUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsUp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsUp.MouseLeave += new System.EventHandler(this.tsUp_MouseLeave);
            this.tsUp.MouseEnter += new System.EventHandler(this.tsUp_MouseEnter);
            this.tsUp.Click += new System.EventHandler(this.tsUp_Click);
            // 
            // tsPageIndex
            // 
            this.tsPageIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsPageIndex.Margin = new System.Windows.Forms.Padding(1, -30, 1, 0);
            this.tsPageIndex.Name = "tsPageIndex";
            this.tsPageIndex.Size = new System.Drawing.Size(121, 103);
            this.tsPageIndex.SelectedIndexChanged += new System.EventHandler(this.tsPageIndex_SelectedIndexChanged);
            // 
            // tsDown
            // 
            this.tsDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDown.Image = ((System.Drawing.Image)(resources.GetObject("tsDown.Image")));
            this.tsDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDown.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsDown.Name = "tsDown";
            this.tsDown.Size = new System.Drawing.Size(43, 61);
            this.tsDown.Text = "Page Down";
            this.tsDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsDown.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsDown.MouseLeave += new System.EventHandler(this.tsDown_MouseLeave);
            this.tsDown.MouseEnter += new System.EventHandler(this.tsDown_MouseEnter);
            this.tsDown.Click += new System.EventHandler(this.tsDown_Click);
            // 
            // tsEnd
            // 
            this.tsEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsEnd.Image")));
            this.tsEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsEnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEnd.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.tsEnd.Name = "tsEnd";
            this.tsEnd.Size = new System.Drawing.Size(48, 61);
            this.tsEnd.Text = "Page End";
            this.tsEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsEnd.MouseLeave += new System.EventHandler(this.tsEnd_MouseLeave);
            this.tsEnd.MouseEnter += new System.EventHandler(this.tsEnd_MouseEnter);
            this.tsEnd.Click += new System.EventHandler(this.tsEnd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // tsZoomIndex
            // 
            this.tsZoomIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsZoomIndex.Items.AddRange(new object[] {
            "1200%",
            "1000%",
            "800%",
            "600%",
            "400%",
            "300%",
            "200%",
            "150%",
            "125%",
            "100%",
            "80%",
            "75%",
            "66.67%",
            "50%",
            "33.33%",
            "25%",
            "18.5%",
            "Actual Size",
            "Fit Page",
            "Fit Width"});
            this.tsZoomIndex.Margin = new System.Windows.Forms.Padding(1, -30, 1, 0);
            this.tsZoomIndex.Name = "tsZoomIndex";
            this.tsZoomIndex.Size = new System.Drawing.Size(121, 103);
            this.tsZoomIndex.SelectedIndexChanged += new System.EventHandler(this.tsZoomIndex_SelectedIndexChanged);
            // 
            // tsZoomOut
            // 
            this.tsZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsZoomOut.Image")));
            this.tsZoomOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoomOut.Name = "tsZoomOut";
            this.tsZoomOut.Size = new System.Drawing.Size(50, 70);
            this.tsZoomOut.Text = "Zoom Out";
            this.tsZoomOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsZoomOut.MouseLeave += new System.EventHandler(this.tsZoomOut_MouseLeave);
            this.tsZoomOut.MouseEnter += new System.EventHandler(this.tsZoomOut_MouseEnter);
            this.tsZoomOut.Click += new System.EventHandler(this.tsZoomOut_Click);
            // 
            // tsZoomIn
            // 
            this.tsZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsZoomIn.Image")));
            this.tsZoomIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoomIn.Name = "tsZoomIn";
            this.tsZoomIn.Size = new System.Drawing.Size(41, 70);
            this.tsZoomIn.Text = "Zoom In";
            this.tsZoomIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsZoomIn.MouseLeave += new System.EventHandler(this.tsZoomIn_MouseLeave);
            this.tsZoomIn.MouseEnter += new System.EventHandler(this.tsZoomIn_MouseEnter);
            this.tsZoomIn.Click += new System.EventHandler(this.tsZoomIn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 73);
            // 
            // tsRotate90
            // 
            this.tsRotate90.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRotate90.Image = ((System.Drawing.Image)(resources.GetObject("tsRotate90.Image")));
            this.tsRotate90.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate90.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRotate90.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRotate90.Name = "tsRotate90";
            this.tsRotate90.Size = new System.Drawing.Size(53, 70);
            this.tsRotate90.Text = "Rotate 90";
            this.tsRotate90.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate90.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsRotate90.MouseLeave += new System.EventHandler(this.tsRotate90_MouseLeave);
            this.tsRotate90.MouseEnter += new System.EventHandler(this.tsRotate90_MouseEnter);
            this.tsRotate90.Click += new System.EventHandler(this.tsRotate90_Click);
            // 
            // tsRotate270
            // 
            this.tsRotate270.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRotate270.Image = ((System.Drawing.Image)(resources.GetObject("tsRotate270.Image")));
            this.tsRotate270.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate270.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRotate270.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRotate270.Name = "tsRotate270";
            this.tsRotate270.Size = new System.Drawing.Size(59, 70);
            this.tsRotate270.Text = "Rotate 270";
            this.tsRotate270.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate270.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsRotate270.MouseLeave += new System.EventHandler(this.tsRotate270_MouseLeave);
            this.tsRotate270.MouseEnter += new System.EventHandler(this.tsRotate270_MouseEnter);
            this.tsRotate270.Click += new System.EventHandler(this.tsRotate270_Click);
            // 
            // tsRotate180
            // 
            this.tsRotate180.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRotate180.Image = ((System.Drawing.Image)(resources.GetObject("tsRotate180.Image")));
            this.tsRotate180.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate180.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRotate180.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRotate180.Name = "tsRotate180";
            this.tsRotate180.Size = new System.Drawing.Size(59, 70);
            this.tsRotate180.Text = "Rotate 180";
            this.tsRotate180.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsRotate180.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsRotate180.MouseLeave += new System.EventHandler(this.tsRotate180_MouseLeave);
            this.tsRotate180.MouseEnter += new System.EventHandler(this.tsRotate180_MouseEnter);
            this.tsRotate180.Click += new System.EventHandler(this.tsRotate180_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 73);
            // 
            // tabAnnotation
            // 
            this.tabAnnotation.BackColor = System.Drawing.Color.Transparent;
            this.tabAnnotation.Controls.Add(this.toolStripAnnotation);
            this.tabAnnotation.Location = new System.Drawing.Point(4, 22);
            this.tabAnnotation.Name = "tabAnnotation";
            this.tabAnnotation.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnnotation.Size = new System.Drawing.Size(1286, 79);
            this.tabAnnotation.TabIndex = 1;
            this.tabAnnotation.Text = "Annotate";
            this.tabAnnotation.ToolTipText = "Annotation tab";
            this.tabAnnotation.UseVisualStyleBackColor = true;
            // 
            // tabAddon
            // 
            this.tabAddon.Controls.Add(this.toolStripAddon);
            this.tabAddon.Location = new System.Drawing.Point(4, 22);
            this.tabAddon.Name = "tabAddon";
            this.tabAddon.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddon.Size = new System.Drawing.Size(1286, 79);
            this.tabAddon.TabIndex = 3;
            this.tabAddon.Text = "Add-on";
            this.tabAddon.ToolTipText = "Add-on Tab";
            this.tabAddon.UseVisualStyleBackColor = true;
            // 
            // toolStripAddon
            // 
            this.toolStripAddon.AutoSize = false;
            this.toolStripAddon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripAddon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripAddon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAddon.ImageScalingSize = new System.Drawing.Size(37, 32);
            this.toolStripAddon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripAddon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbOCRLanguage,
            this.toolStripLabel1,
            this.tbOCRImageScale,
            this.tsOCR,
            this.toolStripSeparator11,
            this.tsReadBarcode,
            this.toolStripSeparator6});
            this.toolStripAddon.Location = new System.Drawing.Point(3, 3);
            this.toolStripAddon.Name = "toolStripAddon";
            this.toolStripAddon.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripAddon.Size = new System.Drawing.Size(1280, 73);
            this.toolStripAddon.TabIndex = 29;
            this.toolStripAddon.TabStop = true;
            this.toolStripAddon.Text = "Addon";
            // 
            // cbbOCRLanguage
            // 
            this.cbbOCRLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "German",
            "Italian",
            "Russian",
            "Chinese (Simplified)",
            "Chinese (Traditional) ",
            "Arabic",
            "Japanese",
            "Ancient Greek",
            "Portuguese",
            "Korean",
            "Dutch",
            "Polish",
            "Hindi",
            "Esperanto alternative",
            "Ukrainian",
            "Turkish",
            "Thai",
            "Tagalog",
            "Telugu",
            "Tamil",
            "Swedish",
            "Swahili"});
            this.cbbOCRLanguage.Name = "cbbOCRLanguage";
            this.cbbOCRLanguage.Size = new System.Drawing.Size(75, 73);
            this.cbbOCRLanguage.SelectedIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(362, 70);
            this.toolStripLabel1.Text = "Magnify OCR image.\r\nThe higher magnification\r\n will return more\r\n accurate result,\r\n but take longer.";
            // 
            // tbOCRImageScale
            // 
            this.tbOCRImageScale.Name = "tbOCRImageScale";
            this.tbOCRImageScale.Size = new System.Drawing.Size(50, 73);
            this.tbOCRImageScale.Text = "200%";
            this.tbOCRImageScale.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOCRImageScale.LostFocus += new System.EventHandler(tbOCRImageScale_LostFocus);
            // 
            // tsOCR
            // 
            this.tsOCR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOCR.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsOCR.Image = ((System.Drawing.Image)(resources.GetObject("tsOCR.Image")));
            this.tsOCR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsOCR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOCR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOCR.Name = "tsOCR";
            this.tsOCR.Size = new System.Drawing.Size(36, 70);
            this.tsOCR.Text = "OCR";
            this.tsOCR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsOCR.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsOCR.MouseLeave += new System.EventHandler(this.tsOCR_MouseLeave);
            this.tsOCR.MouseEnter += new System.EventHandler(this.tsOCR_MouseEnter);
            this.tsOCR.Click += new System.EventHandler(this.tsOCR_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 73);
            // 
            // tsReadBarcode
            // 
            this.tsReadBarcode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReadBarcode.Image = ((System.Drawing.Image)(resources.GetObject("tsReadBarcode.Image")));
            this.tsReadBarcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsReadBarcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsReadBarcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReadBarcode.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsReadBarcode.Name = "tsReadBarcode";
            this.tsReadBarcode.Size = new System.Drawing.Size(44, 69);
            this.tsReadBarcode.Text = "Read Barcode";
            this.tsReadBarcode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsReadBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsReadBarcode.MouseLeave += new System.EventHandler(this.tsReadBarcode_MouseLeave);
            this.tsReadBarcode.MouseEnter += new System.EventHandler(this.tsReadBarcode_MouseEnter);
            this.tsReadBarcode.Click += new System.EventHandler(this.tsReadBarcode_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 73);
            // 
            // winViewer1
            // 
            this.winViewer1.AllowDrop = true;
            this.winViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.winViewer1.DocViewerHeight = 582;
            this.winViewer1.DocViewerWidth = 1094;
            annoStyle1.AnnoText = "";
            annoStyle1.FillColor = System.Drawing.Color.Orange;
            annoStyle1.OutLineColor = System.Drawing.Color.Empty;
            annoStyle1.OutLineWidth = 0;
            annoStyle1.TextColor = System.Drawing.Color.Empty;
            annoStyle1.TextFont = null;
            annoStyle1.Transparency = 0.4F;
            annoStyle1.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Ellipse;
            this.winViewer1.EllipseAnnoStyle = annoStyle1;
            annoStyle2.AnnoText = "";
            annoStyle2.FillColor = System.Drawing.Color.Black;
            annoStyle2.OutLineColor = System.Drawing.Color.Black;
            annoStyle2.OutLineWidth = 3;
            annoStyle2.TextColor = System.Drawing.Color.Empty;
            annoStyle2.TextFont = null;
            annoStyle2.Transparency = 1F;
            annoStyle2.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.FilledRectangle;
            this.winViewer1.FilledRectangleAnnoStyle = annoStyle2;
            annoStyle3.AnnoText = "";
            annoStyle3.FillColor = System.Drawing.Color.Empty;
            annoStyle3.OutLineColor = System.Drawing.Color.Red;
            annoStyle3.OutLineWidth = 3;
            annoStyle3.TextColor = System.Drawing.Color.Empty;
            annoStyle3.TextFont = null;
            annoStyle3.Transparency = 0.4F;
            annoStyle3.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Freehand;
            this.winViewer1.FreehandAnnoStyle = annoStyle3;
            annoStyle4.AnnoText = "";
            annoStyle4.FillColor = System.Drawing.Color.Yellow;
            annoStyle4.OutLineColor = System.Drawing.Color.Empty;
            annoStyle4.OutLineWidth = 0;
            annoStyle4.TextColor = System.Drawing.Color.Empty;
            annoStyle4.TextFont = null;
            annoStyle4.Transparency = 0.4F;
            annoStyle4.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.HighLightRectangle;
            this.winViewer1.HightlightAnnoStyle = annoStyle4;
            annoStyle5.AnnoText = "";
            annoStyle5.FillColor = System.Drawing.Color.Empty;
            annoStyle5.OutLineColor = System.Drawing.Color.Red;
            annoStyle5.OutLineWidth = 3;
            annoStyle5.TextColor = System.Drawing.Color.Empty;
            annoStyle5.TextFont = null;
            annoStyle5.Transparency = 0.4F;
            annoStyle5.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Line;
            this.winViewer1.LineAnnoStyle = annoStyle5;
            this.winViewer1.Location = new System.Drawing.Point(12, 107);
            this.winViewer1.Name = "winViewer1";
            annoStyle6.AnnoText = "";
            annoStyle6.FillColor = System.Drawing.Color.Orange;
            annoStyle6.OutLineColor = System.Drawing.Color.Orange;
            annoStyle6.OutLineWidth = 3;
            annoStyle6.TextColor = System.Drawing.Color.Empty;
            annoStyle6.TextFont = null;
            annoStyle6.Transparency = 0.4F;
            annoStyle6.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Polygon;
            this.winViewer1.PolygonAnnoStyle = annoStyle6;
            annoStyle7.AnnoText = "";
            annoStyle7.FillColor = System.Drawing.Color.Empty;
            annoStyle7.OutLineColor = System.Drawing.Color.Red;
            annoStyle7.OutLineWidth = 3;
            annoStyle7.TextColor = System.Drawing.Color.Empty;
            annoStyle7.TextFont = null;
            annoStyle7.Transparency = 0.4F;
            annoStyle7.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.PolygonLines;
            this.winViewer1.PolygonLinesAnnoStyle = annoStyle7;
            annoStyle8.AnnoText = "";
            annoStyle8.FillColor = System.Drawing.Color.Empty;
            annoStyle8.OutLineColor = System.Drawing.Color.Black;
            annoStyle8.OutLineWidth = 3;
            annoStyle8.TextColor = System.Drawing.Color.Empty;
            annoStyle8.TextFont = null;
            annoStyle8.Transparency = 0.4F;
            annoStyle8.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Rectangle;
            this.winViewer1.RectangleAnnoStyle = annoStyle8;
            annoStyle9.AnnoText = "Good";
            annoStyle9.FillColor = System.Drawing.Color.Red;
            annoStyle9.OutLineColor = System.Drawing.Color.Tomato;
            annoStyle9.OutLineWidth = 3;
            annoStyle9.TextColor = System.Drawing.Color.Black;
            annoStyle9.TextFont = new System.Drawing.Font("Arial", 20F);
            annoStyle9.Transparency = 0.4F;
            annoStyle9.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.RubberStamp;
            this.winViewer1.RubberStampAnnoStyle = annoStyle9;
            this.winViewer1.Size = new System.Drawing.Size(1270, 558);
            this.winViewer1.TabIndex = 30;
            this.winViewer1.Text = "winViewer1";
            annoStyle10.AnnoText = "double click to edit";
            annoStyle10.FillColor = System.Drawing.Color.White;
            annoStyle10.OutLineColor = System.Drawing.Color.Empty;
            annoStyle10.OutLineWidth = 0;
            annoStyle10.TextColor = System.Drawing.Color.Black;
            annoStyle10.TextFont = new System.Drawing.Font("Arial", 12F);
            annoStyle10.Transparency = 0.4F;
            annoStyle10.Type = RasterEdge.XImage.WinFormsViewer.Enum.AnnoType.Text;
            this.winViewer1.TextAnnoStyle = annoStyle10;
            this.winViewer1.ThumbDock = RasterEdge.XImage.WinFormsViewer.Enum.ThumbDock.Left;
            this.winViewer1.ThumbImageHeight = 130;
            this.winViewer1.ThumbImageWidth = 100;
            this.winViewer1.ThumbViewerHeight = 582;
            this.winViewer1.ThumbViewerWidth = 175;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.winViewer1);
            this.Name = "Form1";
            this.Text = "RasterEdge DocViewer";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStripAnnotation.ResumeLayout(false);
            this.toolStripAnnotation.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabFile.ResumeLayout(false);
            this.tabViewer.ResumeLayout(false);
            this.toolStripViewer.ResumeLayout(false);
            this.toolStripViewer.PerformLayout();
            this.tabAnnotation.ResumeLayout(false);
            this.tabAddon.ResumeLayout(false);
            this.toolStripAddon.ResumeLayout(false);
            this.toolStripAddon.PerformLayout();
            this.ResumeLayout(false);

        }

        void tbOCRImageScale_LostFocus(object sender, System.EventArgs e)
        {
            string input = this.tbOCRImageScale.Text;
            if (!input.EndsWith("%"))
            {
                this.tbOCRImageScale.Text = input + "%";
            }
        }

        void tsReadBarcode_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsReadBarcode.BackColor = Color.WhiteSmoke;
        }

        void tsReadBarcode_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsReadBarcode.BackColor = Color.LightBlue;
        }        

        void tsZoomOut_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsZoomOut.BackColor = Color.WhiteSmoke;
        }

        void tsZoomOut_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsZoomOut.BackColor = Color.LightBlue;
        }

        void tsZoomIn_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsZoomIn.BackColor = Color.WhiteSmoke;
        }

        void tsZoomIn_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsZoomIn.BackColor = Color.LightBlue;
        }        

        void tsTop_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsTop.BackColor = Color.WhiteSmoke;
        }

        void tsTop_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsTop.BackColor = Color.LightBlue;
        }

        void tsUp_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsUp.BackColor = Color.WhiteSmoke;
        }

        void tsUp_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsUp.BackColor = Color.LightBlue;
        }

        void tsDown_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsDown.BackColor = Color.WhiteSmoke;
        }

        void tsDown_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsDown.BackColor = Color.LightBlue;
        }

        void tsEnd_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsEnd.BackColor = Color.WhiteSmoke;
        }

        void tsEnd_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsEnd.BackColor = Color.LightBlue;
        }

        void tsConvertToTiff_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsConvertToTiff.BackColor = Color.WhiteSmoke;
        }

        void tsConvertToTiff_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsConvertToTiff.BackColor = Color.LightBlue;
        }
       
        void tsPrint_MouseLeave(object sender, System.EventArgs e)
        {
            this.tsPrint.BackColor = Color.WhiteSmoke;
        }

        void tsPrint_MouseEnter(object sender, System.EventArgs e)
        {
            this.tsPrint.BackColor = Color.LightBlue;
        }

        void tsDeleteAnno_MouseLeave(object sender, System.EventArgs e)
        {
            tsDeleteAnno.BackColor = Color.WhiteSmoke;
        }

        void tsDeleteAnno_MouseEnter(object sender, System.EventArgs e)
        {
            tsDeleteAnno.BackColor = Color.LightBlue;
        }

        void tsBurn_MouseLeave(object sender, System.EventArgs e)
        {
            tsBurn.BackColor = Color.WhiteSmoke;
        }

        void tsBurn_MouseEnter(object sender, System.EventArgs e)
        {
            tsBurn.BackColor = Color.LightBlue;
        }

        void tsRubberStamp_MouseLeave(object sender, System.EventArgs e)
        {
            tsRubberStamp.BackColor = Color.WhiteSmoke;
        }

        void tsRubberStamp_MouseEnter(object sender, System.EventArgs e)
        {
            tsRubberStamp.BackColor = Color.LightBlue;
        }

        void tsPolygon_MouseLeave(object sender, System.EventArgs e)
        {
            tsPolygon.BackColor = Color.WhiteSmoke;
        }

        void tsPolygon_MouseEnter(object sender, System.EventArgs e)
        {
            tsPolygon.BackColor = Color.LightBlue;
        }

        void tsEllipse_MouseLeave(object sender, System.EventArgs e)
        {
            tsEllipse.BackColor = Color.WhiteSmoke;
        }

        void tsEllipse_MouseEnter(object sender, System.EventArgs e)
        {
            tsEllipse.BackColor = Color.LightBlue;
        }

        void tsHighLight_MouseLeave(object sender, System.EventArgs e)
        {
            tsHighLight.BackColor = Color.WhiteSmoke;
        }

        void tsHighLight_MouseEnter(object sender, System.EventArgs e)
        {
            tsHighLight.BackColor = Color.LightBlue;
        }

        void tsRectangle_MouseLeave(object sender, System.EventArgs e)
        {
            tsRectangle.BackColor = Color.WhiteSmoke;
        }

        void tsRectangle_MouseEnter(object sender, System.EventArgs e)
        {
            tsRectangle.BackColor = Color.LightBlue;
        }

        void tsFilledRetangle_MouseLeave(object sender, System.EventArgs e)
        {
            tsFilledRetangle.BackColor = Color.WhiteSmoke;
        }

        void tsFilledRetangle_MouseEnter(object sender, System.EventArgs e)
        {
            tsFilledRetangle.BackColor = Color.LightBlue;
        }

        void tsLines_MouseLeave(object sender, System.EventArgs e)
        {
            tsLines.BackColor = Color.WhiteSmoke;
        }

        void tsLines_MouseEnter(object sender, System.EventArgs e)
        {
            tsLines.BackColor = Color.LightBlue;
        }

        void tsLine_MouseLeave(object sender, System.EventArgs e)
        {
            tsLine.BackColor = Color.WhiteSmoke;
        }

        void tsLine_MouseEnter(object sender, System.EventArgs e)
        {
            tsLine.BackColor = Color.LightBlue;
        }

        void tsFreehand_MouseLeave(object sender, System.EventArgs e)
        {
            tsFreehand.BackColor = Color.WhiteSmoke;
        }

        void tsFreehand_MouseEnter(object sender, System.EventArgs e)
        {
            tsFreehand.BackColor = Color.LightBlue;
        }

        void tsText_MouseLeave(object sender, System.EventArgs e)
        {
            tsText.BackColor = Color.WhiteSmoke;
        }

        void tsText_MouseEnter(object sender, System.EventArgs e)
        {
            tsText.BackColor = Color.LightBlue;
        }

        void tsOCR_MouseLeave(object sender, System.EventArgs e)
        {
            tsOCR.BackColor = Color.WhiteSmoke;
        }

        void tsOCR_MouseEnter(object sender, System.EventArgs e)
        {
            tsOCR.BackColor = Color.LightBlue;
        }

        void tsRotate180_MouseLeave(object sender, System.EventArgs e)
        {
            tsRotate180.BackColor = Color.WhiteSmoke;
        }

        void tsRotate180_MouseEnter(object sender, System.EventArgs e)
        {
            tsRotate180.BackColor = Color.LightBlue;
        }

        void tsRotate270_MouseLeave(object sender, System.EventArgs e)
        {
            tsRotate270.BackColor = Color.WhiteSmoke;
        }

        void tsRotate270_MouseEnter(object sender, System.EventArgs e)
        {
            tsRotate270.BackColor = Color.LightBlue;
        }

        void tsRotate90_MouseLeave(object sender, System.EventArgs e)
        {
            tsRotate90.BackColor = Color.WhiteSmoke;
        }

        void tsRotate90_MouseEnter(object sender, System.EventArgs e)
        {
            tsRotate90.BackColor = Color.LightBlue;
        }        

        void tsSaveFile_MouseLeave(object sender, System.EventArgs e)
        {
            tsSaveFile.BackColor = Color.WhiteSmoke;
        }

        void tsSaveFile_MouseEnter(object sender, System.EventArgs e)
        {
            tsSaveFile.BackColor = Color.LightBlue;
        }

        void tsOpen_MouseLeave(object sender, System.EventArgs e)
        {          
            tsOpen.BackColor = Color.WhiteSmoke;
        }

        void tsOpen_MouseEnter(object sender, System.EventArgs e)
        {           
            tsOpen.BackColor = Color.LightBlue;
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStrip toolStripAnnotation;
        private System.Windows.Forms.ToolStripButton tsText;
        private System.Windows.Forms.ToolStripButton tsFreehand;
        private System.Windows.Forms.ToolStripButton tsLine;
        private System.Windows.Forms.ToolStripButton tsLines;
        private System.Windows.Forms.ToolStripButton tsFilledRetangle;
        private System.Windows.Forms.ToolStripButton tsRectangle;
        private System.Windows.Forms.ToolStripButton tsHighLight;
        private System.Windows.Forms.ToolStripButton tsEllipse;
        private System.Windows.Forms.ToolStripButton tsPolygon;
        private System.Windows.Forms.ToolStripButton tsRubberStamp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBurn;
        private System.Windows.Forms.ToolStripButton tsDeleteAnno;
        private System.Windows.Forms.ToolStripButton tsSaveFile;
        private RasterEdge.XImage.WinFormsViewer.WinViewer winViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TabPage tabAnnotation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabPage tabViewer;
        private System.Windows.Forms.ToolStrip toolStripViewer;
        private System.Windows.Forms.ToolStripButton tsRotate90;
        private System.Windows.Forms.ToolStripButton tsRotate270;
        private System.Windows.Forms.ToolStripButton tsRotate180;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TabPage tabAddon;
        private System.Windows.Forms.ToolStrip toolStripAddon;
        private System.Windows.Forms.ToolStripButton tsOCR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsConvertToTiff;
        private System.Windows.Forms.ToolStripButton tsTop;
        private System.Windows.Forms.ToolStripButton tsUp;
        private System.Windows.Forms.ToolStripComboBox tsPageIndex;
        private System.Windows.Forms.ToolStripButton tsDown;
        private System.Windows.Forms.ToolStripButton tsEnd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tsZoomIndex;
        private System.Windows.Forms.ToolStripButton tsZoomOut;
        private System.Windows.Forms.ToolStripButton tsZoomIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsReadBarcode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripComboBox cbbOCRLanguage;
        private System.Windows.Forms.ToolStripTextBox tbOCRImageScale;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        





    }
}

