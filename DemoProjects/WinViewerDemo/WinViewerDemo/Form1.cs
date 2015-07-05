using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;



using RasterEdge.Imaging.Basic;

using RasterEdge.XImage.WinFormsViewer;
using RasterEdge.XImage.OCR;
using RasterEdge.XDoc.PDF;


namespace WinViewerDemo
{
    //[LicenseProvider(typeof(WinViewerLicenseProvider))]
    public partial class Form1 : Form
    {
        private string _fileType = "";
        private int _pageCount = 0;
        private string _saveName;
        private string _convertName;
        private string _ocrName;
        private delegate void PageCountChangeDelegate();

        public Form1()
        {
            //License license = System.ComponentModel.LicenseManager.Validate(typeof(Form1), this); 
            
            InitializeComponent();
            WorkRegistry.Reset();

            this.WindowState = FormWindowState.Maximized;

            this.tsSaveFile.Enabled = false;
            this.tsPrint.Enabled = false;
            this.tsConvertToTiff.Enabled = false;

            this.tsBurn.Enabled = false;
            this.tsDeleteAnno.Enabled = false;
            this.tsEllipse.Enabled = false;
            this.tsFilledRetangle.Enabled = false;
            this.tsFreehand.Enabled = false;
            this.tsHighLight.Enabled = false;
            this.tsLine.Enabled = false;
            this.tsLines.Enabled = false;            
            this.tsPolygon.Enabled = false;
            this.tsRectangle.Enabled = false;           
            this.tsRubberStamp.Enabled = false;            
            this.tsText.Enabled = false;

            this.tsTop.Enabled = false;
            this.tsUp.Enabled = false;
            this.tsDown.Enabled = false;
            this.tsEnd.Enabled = false;
            this.tsZoomIn.Enabled = false;
            this.tsZoomOut.Enabled = false;
            this.tsRotate180.Enabled = false;
            this.tsRotate270.Enabled = false;
            this.tsRotate90.Enabled = false;

            this.tsOCR.Enabled = false;
            this.cbbOCRLanguage.Enabled = false;
            this.tbOCRImageScale.Enabled = false;
            this.tsReadBarcode.Enabled = false;

            this.winViewer1.PageCountChanged += new FileOnAddEventHandler(winViewer1_PageCountChanged);
            this.winViewer1.SelectedPageIndexChanged += new FileOnAddEventHandler(winViewer1_SelectedPageIndexChanged);
            this.winViewer1.SelectedZoomIndexChanged += new PageZoomIndexChangedEventHandler(winViewer1_SelectedZoomIndexChanged);
        }

        void winViewer1_SelectedZoomIndexChanged(object sender, PageZoomIndexChangedEventArgs e)
        {
            this.tsZoomIndex.SelectedIndex = e.ZoomIndex;
        }

        void winViewer1_SelectedPageIndexChanged(object sender, FileOnAddEventArgs e)
        {
            this.tsPageIndex.SelectedIndex = e.PageIndex;
        }

        void winViewer1_PageCountChanged(object sender, FileOnAddEventArgs e)
        {
            _pageCount = e.PageIndex;

            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(startLoadPageIndex));
            thread.Start();
        }

        private void startLoadPageIndex()
        {
            PageCountChangeDelegate handler = new PageCountChangeDelegate(loadPageIndex);
            this.BeginInvoke(handler);
        }

        private void loadPageIndex()
        {
            this.tsPageIndex.Items.Clear();
            for (int i = 1; i <= _pageCount; i++)
            {
                this.tsPageIndex.Items.Add(i + " / " + _pageCount);
            }

            this.tsPageIndex.SelectedIndex = 0;

            if (_pageCount <= 1)
            {
                this.tsTop.Enabled = false;
                this.tsUp.Enabled = false;
                this.tsDown.Enabled = false;
                this.tsEnd.Enabled = false;
            }
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "(*.*)|*.*";
            ofd.Filter = "All File(*.*)|*.*" +
                "|PDF(*.pdf)|*.pdf" +
                "|MS Word(*.docx,*.docm,*.dotx,*.dotm,*.doc)|*.docx;*.docm;*.dotx;*.dotm;*.doc" +
                "|MS Excel(*.xlsx,*.xlsm,*.xltx,*.xls)|*.xlsx;*.xlsm;*.xltx;*.xls" +
                "|MS PPT(*.pptx,*.ppsx,*.pptm,*.potm,*.potx,*.ppsm,*.ppt)|*.pptx;*.ppsx;*.pptm;*.potm;*.potx;*.ppsm;*.ppt" +
                "|TIFF(*.tif,*.tiff)|*.tif;*.tiff" +
                "|PNG(*.png)|*.png" +
                "|BMP(*.bmp,*.rle,*.dib,*.vga,*.rl4,*.rl8,*.sys)|*.bmp;*.rle;*.dib;*.vga;*.rl4;*.rl8;*.sys" +
                "|GIF(*.gif)|*.gif" +
                "|JPEG(*.jpg,*.jpeg,*.jfif,*.jpe)|*.jpg;*.jpeg;*.jfif;*.jpe" +
                "|DICOM(*.dcm)|*.dcm" +
                "|JBIG(*.jbg,*.jbig)|*.jbg;*.jbig" +
                "|JBIG2(*.jbig2,*.jb2)|*.jbig2;*.jb2" +
                "|XBM(*.xbm)|*.xbm" +
                "|XPM(*.xpm)|*.xpm" +
                "|PPM(*.ppm)|*.ppm" +
                "|PGM(*.pgm)|*.pgm" +
                "|PBM(*.pbm)|*.pbm" +
                "|DNG(*.dng)|*.dng" +
                "|DPX(*.dpx)|*.dpx" +
                "|HDR(*.hdr)|*.hdr" +
                "|ICON(*.ico)|*.ico" +
                "|PCL(*.pcl)|*.pcl" +
                "|PCX(*.pcx)|*.pcx" +
                "|PNM(*.pnm)|*.pnm" +
                "|PS(*.ps)|*.ps" +
                "|PSD(*.psd)|*.psd" +
                "|SVG(*.svg)|*.svg" +
                "|TGA(*.tga)|*.tga" +
                "|TTF(*.ttf)|*.ttf" +
                "|TXT(*.txt)|*.txt" +
                "|JPEG2000(*.jp2,*.j2k)|*.jp2;*.j2k";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = ofd.FileName.ToLower();

                    if (filename.EndsWith(".pdf") ||
                        filename.EndsWith(".docx") || filename.EndsWith(".docm") || filename.EndsWith(".dotx") || filename.EndsWith(".dotm") || filename.EndsWith(".doc") ||
                        filename.EndsWith(".xlsx") || filename.EndsWith(".xlsm") || filename.EndsWith(".xltx") || filename.EndsWith(".xls") ||
                        filename.EndsWith(".pptx") || filename.EndsWith(".ppsx") || filename.EndsWith(".pptm") || filename.EndsWith(".potm") || filename.EndsWith(".potx") || filename.EndsWith(".ppsm") || filename.EndsWith(".ppt") ||
                        filename.EndsWith(".tif") || filename.EndsWith(".tiff") ||
                        filename.EndsWith(".png") ||
                        filename.EndsWith(".bmp") || filename.EndsWith(".rle") || filename.EndsWith(".dib") || filename.EndsWith(".vga") || filename.EndsWith(".rl4") || filename.EndsWith(".rl8") || filename.EndsWith(".sys") ||
                        filename.EndsWith(".gif") ||
                        filename.EndsWith(".jpg") || filename.EndsWith(".jpeg") || filename.EndsWith(".jfif") || filename.EndsWith(".jpe") ||
                        filename.EndsWith(".dcm") ||
                        filename.EndsWith(".jbig2") || filename.EndsWith(".jb2") ||
                        filename.EndsWith(".jbg") || filename.EndsWith(".jbig") ||
                        filename.EndsWith(".xbm") ||
                        filename.EndsWith(".xpm") ||
                        filename.EndsWith(".ppm") ||
                        filename.EndsWith(".pgm") ||
                        filename.EndsWith(".pbm") ||
                        filename.EndsWith(".dng") ||
                        filename.EndsWith(".dpx") ||
                        filename.EndsWith(".hdr") ||
                        filename.EndsWith(".ico") ||
                        filename.EndsWith(".pcl") ||
                        filename.EndsWith(".pcx") ||
                        filename.EndsWith(".pnm") ||
                        filename.EndsWith(".ps") || filename.EndsWith(".psd") ||
                        filename.EndsWith(".svg") ||
                        filename.EndsWith(".tga") ||
                        filename.EndsWith(".ttf") ||
                        filename.EndsWith(".txt") ||
                        filename.EndsWith(".jp2") || filename.EndsWith(".j2k"))
                    { }
                    else
                    {
                        return;
                    }

                    if (filename.EndsWith(".pdf"))
                    {  
                        _fileType = "pdf";
                    }
                    else
                    {                        
                        _fileType = "";
                    }

                    this.tsSaveFile.Enabled = true;
                    this.tsPrint.Enabled = true;
                    this.tsConvertToTiff.Enabled = true;

                    this.tsBurn.Enabled = true;
                    this.tsDeleteAnno.Enabled = true;
                    this.tsEllipse.Enabled = true;
                    this.tsFilledRetangle.Enabled = true;
                    this.tsFreehand.Enabled = true;
                    this.tsHighLight.Enabled = true;
                    this.tsLine.Enabled = true;
                    this.tsLines.Enabled = true;
                    this.tsPolygon.Enabled = true;
                    this.tsRectangle.Enabled = true;
                    this.tsRubberStamp.Enabled = true;
                    this.tsText.Enabled = true;
                    //if (filename.EndsWith(".png") || filename.EndsWith(".bmp") || filename.EndsWith(".gif") || filename.EndsWith(".jpg") || filename.EndsWith(".jpeg") ||
                    //    filename.EndsWith(".dic") || filename.EndsWith(".dcm") || filename.EndsWith(".jbig2") || filename.EndsWith(".jbg")
                    //)
                    //{
                    //    this.tsRotate180.Enabled = false;
                    //    this.tsRotate270.Enabled = false;
                    //    this.tsRotate90.Enabled = false;
                    //}
                    //else
                    //{
                    //    this.tsRotate180.Enabled = true;
                    //    this.tsRotate270.Enabled = true;
                    //    this.tsRotate90.Enabled = true;
                    //}

                    this.tsTop.Enabled = true;
                    this.tsUp.Enabled = true;
                    this.tsDown.Enabled = true;
                    this.tsEnd.Enabled = true;
                    this.tsZoomIn.Enabled = true;
                    this.tsZoomOut.Enabled = true;
                    this.tsRotate180.Enabled = true;
                    this.tsRotate270.Enabled = true;
                    this.tsRotate90.Enabled = true;
                    
                    this.tsOCR.Enabled = true;
                    this.cbbOCRLanguage.Enabled = true;
                    this.tbOCRImageScale.Enabled = true;
                    this.tsReadBarcode.Enabled = true;

                    filename = filename.Replace("\\", "/");
                    int posi = filename.LastIndexOf("/");
                    _saveName = filename.Substring(posi + 1);                    
                    posi = _saveName.LastIndexOf(".");
                    _convertName = _saveName.Substring(0, posi);
                    posi = filename.LastIndexOf(".");
                    _ocrName = filename.Substring(0, posi);
                                       
                    this.Text = _saveName;

                    this.winViewer1.LoadFromFile(filename);
                   
                }
                catch
                {
                    this.tsSaveFile.Enabled = false;
                    this.tsPrint.Enabled = false;
                    this.tsConvertToTiff.Enabled = false;

                    this.tsBurn.Enabled = false;
                    this.tsDeleteAnno.Enabled = false;
                    this.tsEllipse.Enabled = false;
                    this.tsFilledRetangle.Enabled = false;
                    this.tsFreehand.Enabled = false;
                    this.tsHighLight.Enabled = false;
                    this.tsLine.Enabled = false;
                    this.tsLines.Enabled = false;
                    this.tsPolygon.Enabled = false;
                    this.tsRectangle.Enabled = false;
                    this.tsRubberStamp.Enabled = false;
                    this.tsText.Enabled = false;

                    this.tsTop.Enabled = false;
                    this.tsUp.Enabled = false;
                    this.tsDown.Enabled = false;
                    this.tsEnd.Enabled = false;
                    this.tsZoomIn.Enabled = false;
                    this.tsZoomOut.Enabled = false;
                    this.tsRotate180.Enabled = false;
                    this.tsRotate270.Enabled = false;
                    this.tsRotate90.Enabled = false;

                    this.tsOCR.Enabled = false;
                    this.cbbOCRLanguage.Enabled = false;
                    this.tbOCRImageScale.Enabled = false;
                    this.tsReadBarcode.Enabled = false;

                    this.Text = "RasterEdge DocViewer";
                }

               
            }
        }
              
         

        private void tsAddPage_Click(object sender, EventArgs e)
        {
            this.winViewer1.AddPage();
        }

        private void tsDeletePage_Click(object sender, EventArgs e)
        {
            this.winViewer1.DeletePage();
        }

        private void tsRotate90_Click(object sender, EventArgs e)
        {
            this.winViewer1.Rotate90();
        }

        private void tsRotate270_Click(object sender, EventArgs e)
        {
            this.winViewer1.Rotate270();
        }

        private void tsRotate180_Click(object sender, EventArgs e)
        {
            this.winViewer1.Rotate180();
        }

        private void tsText_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.TextAnnoStyle = new AnnoStyle();
            this.winViewer1.TextAnnoStyle.Type = AnnoType.Text;
            this.winViewer1.TextAnnoStyle.FillColor = Color.White;
            this.winViewer1.TextAnnoStyle.AnnoText = "double click to edit";
            this.winViewer1.TextAnnoStyle.TextColor = Color.Black;
            this.winViewer1.TextAnnoStyle.TextFont = new Font("Arial", 12, FontStyle.Regular);
            this.winViewer1.TextAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawText();
        }

        private void tsFreehand_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.FreehandAnnoStyle = new AnnoStyle();
            this.winViewer1.FreehandAnnoStyle.Type = AnnoType.Freehand;
            this.winViewer1.FreehandAnnoStyle.OutLineColor = Color.Red;
            this.winViewer1.FreehandAnnoStyle.OutLineWidth = 3;
            this.winViewer1.FreehandAnnoStyle.Transparency = 0.4f;
            */
            
            this.winViewer1.DrawFreehand();
        }

        private void tsLine_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.LineAnnoStyle = new AnnoStyle();
            this.winViewer1.LineAnnoStyle.Type = AnnoType.Line;
            this.winViewer1.LineAnnoStyle.OutLineColor = Color.Red;
            this.winViewer1.LineAnnoStyle.OutLineWidth = 3;
            this.winViewer1.LineAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawLine();
        }

        private void tsLines_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.PolygonLinesAnnoStyle = new AnnoStyle();
            this.winViewer1.PolygonLinesAnnoStyle.Type = AnnoType.PolygonLines;
            this.winViewer1.PolygonLinesAnnoStyle.OutLineColor = Color.Red;
            this.winViewer1.PolygonLinesAnnoStyle.OutLineWidth = 3;
            this.winViewer1.PolygonLinesAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawPolygonLines();
        }

        private void tsFilledRetangle_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.FilledRectangleAnnoStyle = new AnnoStyle();
            this.winViewer1.FilledRectangleAnnoStyle.Type = AnnoType.FilledRectangle;
            this.winViewer1.FilledRectangleAnnoStyle.OutLineColor = Color.Black;
            this.winViewer1.FilledRectangleAnnoStyle.OutLineWidth = 3;
            this.winViewer1.FilledRectangleAnnoStyle.FillColor = Color.Black;
            this.winViewer1.FilledRectangleAnnoStyle.Transparency = 1;
            */

            this.winViewer1.DrawFilledRectangle();
        }

        private void tsRectangle_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.RectangleAnnoStyle = new AnnoStyle();
            this.winViewer1.RectangleAnnoStyle.Type = AnnoType.Rectangle;
            this.winViewer1.RectangleAnnoStyle.OutLineColor = Color.Black;
            this.winViewer1.RectangleAnnoStyle.OutLineWidth = 3;
            this.winViewer1.RectangleAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawRectangle();
        }

        private void tsHighLight_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.HightlightAnnoStyle = new AnnoStyle();
            this.winViewer1.HightlightAnnoStyle.Type = AnnoType.HighLightRectangle;
            this.winViewer1.HightlightAnnoStyle.FillColor = Color.Yellow;
            this.winViewer1.HightlightAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawHightLight();
        }

        private void tsEllipse_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.EllipseAnnoStyle = new AnnoStyle();
            this.winViewer1.EllipseAnnoStyle.Type = AnnoType.Ellipse;
            this.winViewer1.EllipseAnnoStyle.FillColor = Color.Cyan;
            this.winViewer1.EllipseAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawEllipse();
        }

        private void tsPolygon_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.PolygonAnnoStyle = new AnnoStyle();
            this.winViewer1.PolygonAnnoStyle.Type = AnnoType.Polygon;
            this.winViewer1.PolygonAnnoStyle.OutLineColor = Color.Orange;
            this.winViewer1.PolygonAnnoStyle.OutLineWidth = 3;
            this.winViewer1.PolygonAnnoStyle.FillColor = Color.Cyan;
            this.winViewer1.PolygonAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawPolygon();
        }

        private void tsRubberStamp_Click(object sender, EventArgs e)
        {
            /*
            this.winViewer1.RubberStampAnnoStyle = new AnnoStyle();
            this.winViewer1.RubberStampAnnoStyle.Type = AnnoType.RubberStamp;
            this.winViewer1.RubberStampAnnoStyle.OutLineColor = Color.Tomato;
            this.winViewer1.RubberStampAnnoStyle.OutLineWidth = 3;
            this.winViewer1.RubberStampAnnoStyle.FillColor = Color.Red;
            this.winViewer1.RubberStampAnnoStyle.AnnoText = "Good";
            this.winViewer1.RubberStampAnnoStyle.TextColor = Color.Black;
            this.winViewer1.RubberStampAnnoStyle.TextFont = new Font("Arial", 20, FontStyle.Regular);
            this.winViewer1.RubberStampAnnoStyle.Transparency = 0.4f;
            */

            this.winViewer1.DrawRubberStamp();
        }

        private void tsBurn_Click(object sender, EventArgs e)
        {
            this.winViewer1.BurnAnnotation();
        }

        private void tsDeleteAnno_Click(object sender, EventArgs e)
        {
            this.winViewer1.DeleteAnnotation();
        }

        private void tsSaveFile_Click(object sender, EventArgs e)
        {
            //if (_saveName.EndsWith(".xls") || _saveName.EndsWith(".doc") || _saveName.EndsWith(".ppt"))
            //{
            //    MessageBox.Show("Can not save MS Office 2003 file currently!");
            //}
            //else
            //{
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "(*.*)|*.*";
            //sfd.FileName = _saveName;

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        this.winViewer1.SaveFile(sfd.FileName);
            //    }
            //}    

            // Used to register all DLL assemblies.
            WorkRegistry.Reset();

            // Load a PDF document.
            String inputFilePath = @"F:\Experiments\RasterEdge.DocImageSDK9.5.0(release)\Test.pdf";
            PDFDocument doc = new PDFDocument(inputFilePath);

            // Convert and output to a DOCX file.
            String outputFilePath2 = inputFilePath + ".docx";
            doc.ConvertToDocument(DocumentType.DOCX, outputFilePath2);
        }

        private void tsOCR_Click(object sender, EventArgs e)
        {
            Language lang = getOCRLanguage();
            string scaleStr = this.tbOCRImageScale.Text;
            float scale = 2.0f;
            try
            {
                scaleStr = scaleStr.Replace("%", "");
                scale = float.Parse(scaleStr);
                scale = scale / 100;
            }
            catch
            {
                scale = 2.0f;
            }

            this.winViewer1.GetCurrentPageTextByOCR(lang, scale, _ocrName);
        }

        private void changeAllButtonBackColor()
        {
            
            tsBurn.BackColor = Color.WhiteSmoke;
            tsDeleteAnno.BackColor = Color.WhiteSmoke;
            tsEllipse.BackColor = Color.WhiteSmoke;
            tsFilledRetangle.BackColor = Color.WhiteSmoke;
            tsFreehand.BackColor = Color.WhiteSmoke;
            tsHighLight.BackColor = Color.WhiteSmoke;
            tsLine.BackColor = Color.WhiteSmoke;
            tsLines.BackColor = Color.WhiteSmoke;
            tsOCR.BackColor = Color.WhiteSmoke;
            tsOpen.BackColor = Color.WhiteSmoke;
            tsPolygon.BackColor = Color.WhiteSmoke;
            tsRectangle.BackColor = Color.WhiteSmoke;
            tsRotate180.BackColor = Color.WhiteSmoke;
            tsRotate270.BackColor = Color.WhiteSmoke;
            tsRotate90.BackColor = Color.WhiteSmoke;
            tsRubberStamp.BackColor = Color.WhiteSmoke;
            tsSaveFile.BackColor = Color.WhiteSmoke;
            tsText.BackColor = Color.WhiteSmoke;      
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF(*.pdf)|*.pdf";
            sfd.FileName = _convertName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.winViewer1.ConvertToPDF(sfd.FileName);
            }
        }

        private void tsConvertToTiff_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TIFF(*.tif,*.tiff)|*.tif;*.tiff";
            sfd.FileName = _convertName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.winViewer1.ConvertToTiff(sfd.FileName);
            }
        }

        private void tsTop_Click(object sender, EventArgs e)
        {
            this.tsPageIndex.SelectedIndex = 0;
        }

        private void tsUp_Click(object sender, EventArgs e)
        {
            this.tsPageIndex.SelectedIndex--;
        }

        private void tsDown_Click(object sender, EventArgs e)
        {
            this.tsPageIndex.SelectedIndex++;
        }

        private void tsEnd_Click(object sender, EventArgs e)
        {
            this.tsPageIndex.SelectedIndex = this.tsPageIndex.Items.Count - 1;
        }

       
        void tsPageIndex_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tsPageIndex.SelectedIndex == 0)
            {
                this.tsTop.Enabled = false;
                this.tsUp.Enabled = false;
                this.tsDown.Enabled = true;
                this.tsEnd.Enabled = true;
            }
            else if (tsPageIndex.SelectedIndex == tsPageIndex.Items.Count - 1)
            {
                this.tsTop.Enabled = true;
                this.tsUp.Enabled = true;
                this.tsDown.Enabled = false;
                this.tsEnd.Enabled = false;
            }
            else
            {
                this.tsTop.Enabled = true;
                this.tsUp.Enabled = true;
                this.tsDown.Enabled = true;
                this.tsEnd.Enabled = true;
            }

            this.winViewer1.PageIndexChanged(tsPageIndex.SelectedIndex);            
        }

        private void tsZoomOut_Click(object sender, EventArgs e)
        {
            this.tsZoomIndex.SelectedIndex++;
        }

        private void tsZoomIn_Click(object sender, EventArgs e)
        {
            this.tsZoomIndex.SelectedIndex--;
        }
       
        void tsZoomIndex_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tsZoomIndex.SelectedIndex == 0)
            {
                this.tsZoomIn.Enabled = false;
                this.tsZoomOut.Enabled = true;
            }
            else if (tsZoomIndex.SelectedIndex == 16)
            {
                this.tsZoomIn.Enabled = true;
                this.tsZoomOut.Enabled = false;
            }
            else if (tsZoomIndex.SelectedIndex > 16)
            {
                this.tsZoomIn.Enabled = false;
                this.tsZoomOut.Enabled = false;
            }
            else
            {
                this.tsZoomIn.Enabled = true;
                this.tsZoomOut.Enabled = true;
            }

            this.winViewer1.ZoomIndexChanged(this.tsZoomIndex.SelectedIndex);
        }

        private void tsReadBarcode_Click(object sender, EventArgs e)
        {
            this.winViewer1.GetCurrentPageBarcodeReading();
        }


        private Language getOCRLanguage()
        {
            Language lang = Language.Eng;
            int index = this.cbbOCRLanguage.SelectedIndex;
            switch (index)
            {
                case 0:
                    return Language.Eng;
                case 1:
                    return Language.Spa;
                case 2:
                    return Language.Fra;
                case 3:
                    return Language.Deu;
                case 4:
                    return Language.Ita;
                case 5:
                    return Language.Rus;
                case 6:
                    return Language.Unkown;// "chi_sim";
                case 7:
                    return Language.Unkown;// "chi_tra";
                case 8:
                    return Language.Unkown;// "ara";
                case 9:
                    return Language.Unkown;// "jpn";
                case 10:
                    return Language.Unkown;// "grc";
                case 11:
                    return Language.Por;
                case 12:
                    return Language.Kor;
                case 13:
                    return Language.Nld;
                case 14:
                    return Language.Pol;
                case 15:
                    return Language.Unkown;// "hin";
                case 16:
                    return Language.Unkown;// "epo_alt";
                case 17:
                    return Language.Ukr;
                case 18:
                    return Language.Tur;
                case 19:
                    return Language.Tha;
                case 20:
                    return Language.Tgl;
                case 21:
                    return Language.Tel;
                case 22:
                    return Language.Tam;
                case 23:
                    return Language.Swe;
                case 24:
                    return Language.Swa;
            }
            return lang;
        }
 

    
    }

  
}