using System;
using System.Net;
using System.Web;
using System.IO;
using System.Web.Configuration;
using RasterEdge.XDoc.HTML5Viewer;
using RasterEdge.Imaging.Basic;
using RasterEdge.XDoc.HTML5Viewer.Enum;
using RasterEdge.Imaging.Basic.Core;
using RasterEdge.XDoc.PDF;
using RasterEdge.Imaging.MSWordDocx;
using RasterEdge.Imaging.Basic.Codec;



public partial class _Default : System.Web.UI.Page
{
    public string MsgToClient = "";
    public string cacheFolder = WebConfigurationManager.AppSettings.Get("cacheFolder");
    public string resourceFolder = WebConfigurationManager.AppSettings.Get("resourceFolder");
    protected void Page_Load(object sender, EventArgs e)
    {
        RequestServerceHandler();
    }

    private void RequestServerceHandler()
    {
        string command = Request.Form["RECommand"];
        if (command == null || command.Equals(""))
        {
            if (Request.Files.Count > 0)
                LoadFileFromUpload();
            else if (Request.Form["src"] != null)
                LoadFileFromOnline();
            else
                LoadFileFromUrl();      
        }
        else if (command.Equals("FileSave"))
        {
            ProcessUserDefinedFileSave();
        }
        else if (command.Equals("userDefined"))
        {
            ProcessUserDefinedFileLoad();  
        }
    }

    public void LoadFileFromUpload()
    {
        REWebDocument webDoc = REDocumentControl.CreateWebDocFromUpload(Request);
        REDocumentControl.ResponseToClient(webDoc.MsgToClient, Response); 
    }

    public void LoadFileFromOnline()
    {
        string src = Request.Form["src"];
        REWebDocument webDoc = REDocumentControl.CreateWebDocFromOnLine(src, "");
        REDocumentControl.ResponseToClient(webDoc.MsgToClient, Response);
    }

    public void LoadFileFromUrl()
    {
        string file = Request.QueryString["file"];
        string src = Request.QueryString["src"];
        if (file != null && file != "")
            LoadFileFromCustomizedUrl(file);
        else if (src != null && src != "")
            LoadFileFromPublicAccessibleUrl(src);
    }

    public void LoadFileFromCustomizedUrl(string file)
    {
        string path = REDocumentControl.GetAbsolutePath(file);
        REWebDocument webDoc = REDocumentControl.CreateWebDocFromServer(path);
        MsgToClient = webDoc.MsgToClient;
    }

    public void LoadFileFromPublicAccessibleUrl(string src)
    {
        REWebDocument webDoc = REDocumentControl.CreateWebDocFromOnLine(src, "");
        MsgToClient = webDoc.MsgToClient;
    }

    public void ProcessUserDefinedFileSave()
    {
        string savePath = REDocumentControl.GetSaveFileRelativePath(Request);
        //byte[] array = REDocumentControl.GetSaveFileByteArray(Request);
        //Stream stream = REDocumentControl.GetSaveFileStream(Request);
        REDocumentControl.ResponseToClient(savePath, Response);
    }

    public void ProcessUserDefinedFileLoad()
    {
        string fileName = Request.Form["FileName"];
        string path = REDocumentControl.GetAbsolutePath(fileName);
        REWebDocument webDoc = REDocumentControl.CreateWebDocFromServer(path);
        REDocumentControl.ResponseToClient(webDoc.MsgToClient, Response);
    }
}
