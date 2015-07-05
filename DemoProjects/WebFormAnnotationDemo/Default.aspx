<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" EnableViewState="False" EnableSessionState="False" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta name="viewport"  content="initial-scale=1.0; maximum-scale=1.0;" />
<title></title>
<script src="RasterEdge_Resource_Files/Javascript/jquery.js" type="text/javascript"></script>
<script src="RasterEdge_Resource_Files/Javascript/RasterEdge.js" type="text/javascript"></script>
<script src="RasterEdge_Resource_Files/Javascript/customViewer.js" type="text/javascript"></script>
<link rel="stylesheet" href="RasterEdge_Resource_Files/css/RasterEdge.css" type="text/css"/>
<link rel="stylesheet" href="RasterEdge_Resource_Files/css/jquery-ui.css" type="text/css"/>
<script type="text/javascript"> 
    _msgToClient = "<%=MsgToClient%>";
    _cacheFolder = "<%=cacheFolder%>";
    _resourceFolder = "<%=resourceFolder%>";
    _viewer = new RasterEdgeViewer({
        _serverUrl: "/RasterEdge_Resource_Files/WebHandler.ashx", 
        _defaultPage: "Default.aspx", 
        //0 represent png, 1 represent svg
        _pdfViewer: 1,
        _wordViewer: 1,
        _excelViewer:1,
	    _pptViewer:1,
        
        //Set width and height of the webViewer(pixel)
        _viewerWidth: 1024, 
        _viewerHeight: 730, 
    });   
    
    //add Tab "File"(RE)
    var _tabFile = new ToolbarTab("File");
//    var CommandSet = new CommandSet(new Array("upload","openOnlineDoc","print","save","convert","ocr"));
//    _tabFile.addCommandSet(CommandSet);
    _tabFile.addCommand(new RECommand("upload"));
    _tabFile.addCommand(new RECommand("openOnlineDoc"));
    _tabFile.addCommand(new RECommand("print"));
    _tabFile.addCommand(new RECommand("save"));
    _tabFile.addCommand(new RECommand("convert"));
    _tabFile.addCommand(new RECommand("ocr"));
    _viewerTopToolbar.addTab(_tabFile);
    
    //add Tab "Annotation"
    var _tabAnnotations = new ToolbarTab("Annotation");
    //TextFont:Arial/Calibri/Verdana
    //TextStyle:bold/italic/underline/line-through
    //TextColor:Hexadecimal color can be used
    //Transparency:1 on behalf of saturated, 0 represents completely transparent 
    _tabAnnotations.addCommand(new CommandAnnotation("text",new AnnoStyle({OutLineWidth:3.0,OutLineColor:"#000000",FillColor: "#FFFFFF", TextColor: "#000000", TextFont: "Arial", TextSize: 18,TextStyle :new Array(),Transparency:0.8})));
    _tabAnnotations.addCommand(new CommandAnnotation("freeHand",new AnnoStyle({OutLineColor: "#ff0000", OutLineWidth: 5.0 ,Transparency:1})));
    _tabAnnotations.addCommand(new CommandAnnotation("highLight",new AnnoStyle({FillColor: "#ffff00",OutLineWidth:3.0,OutLineColor:"#ffff00",Transparency:0.6})));
    _tabAnnotations.addCommand(new CommandAnnotation("rectangle",new AnnoStyle({OutLineColor: "#000000", OutLineWidth: 0.0, FillColor: "#000000", Transparency: 1})));
    _tabAnnotations.addCommand(new CommandAnnotation("ellipse",new AnnoStyle({FillColor: "Orange",OutLineWidth:3.0,OutLineColor:"Orange",Transparency:0.4})));
    _tabAnnotations.addCommand(new CommandAnnotation("rubberStamp",new AnnoStyle({FillColor:"OrangeRed",OutLineWidth:9.0,ShowedText: "Approved",TextFont: "Calibri",TextStyle: new Array("bold"),Transparency:1})));
    _tabAnnotations.addCommand(new CommandAnnotation("polygonLines",new AnnoStyle({OutLineColor: "Red", OutLineWidth: 5.0,Transparency:1})));
    _tabAnnotations.addCommand(new CommandAnnotation("polygon",new AnnoStyle({OutLineColor: "OrangeRed", OutLineWidth: 3.0, FillColor: "OrangeRed",Transparency:0.4})));
    _tabAnnotations.addCommand(new CommandAnnotation("line",new AnnoStyle({OutLineColor: "Red", OutLineWidth: 7.0,Transparency:1})));
    _tabAnnotations.addCommand(new CommandAnnotation("arrow",new AnnoStyle({OutLineWidth: 9.0, FillColor: "Red",Transparency:1}))); 
    
    var commentsProcess = new CommandSet(new Array("delete","loadComments","saveComments"));
    _tabAnnotations.addCommandSet(commentsProcess);
    _viewerTopToolbar.addTab(_tabAnnotations);
    
    //add Tab "Signature"
    var _tabSignature = new ToolbarTab("Signature");
    _tabSignature.addCommand(new RECommand("signManager"));
    _tabSignature.addCommand(new RECommand("Freehand"));
    _tabSignature.addCommand(new RECommand("Text"));
    _tabSignature.addCommand(new RECommand("Date"));
    _tabSignature.addCommand(new RECommand("commentsProcess"));
    _tabSignature.addCommandSet(commentsProcess);
    _viewerTopToolbar.addTab(_tabSignature);
    
    //add Tab "Redact"
    var _tabRedact = new ToolbarTab("Redact");
    var CommandSet = new CommandSet(new Array("rectRedact","textRedact"));
    _tabRedact.addCommandSet(CommandSet);
    _tabRedact.addCommandSet(commentsProcess);
    _viewerTopToolbar.addTab(_tabRedact);
    
    //add Tab "Sample Files"
    var _tabDemoFiles = new ToolbarTab("Sample Files");
    
    //Scenario 1:ID and events take RE default
    var _userCmdDemoPdf = new UserCommand("pdf");
    _userCmdDemoPdf.addCSS(new customStyle({background:"url('RasterEdge_Resource_Files/images/demo.png') no-repeat 0px 0px",width:"31px",height:"40px",marginRight:"15px"}));
    _userCmdDemoPdf.addParameter(new customCmd({RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/pdf/demo_1.pdf"}));
    _tabDemoFiles.addCommand(_userCmdDemoPdf);
    
    var _userCmdDemoWord = new UserCommand("word");
    _userCmdDemoWord.addCSS(new customStyle({background:"url('RasterEdge_Resource_Files/images/demo.png') no-repeat -37px 0px",width:"31px",height:"40px",marginRight:"15px"}));
    _userCmdDemoWord.addParameter(new customCmd({RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/word/demo_1.docx"}));
    _tabDemoFiles.addCommand(_userCmdDemoWord);
    
     var _userCmdDemoExcel= new UserCommand("excel");
    _userCmdDemoExcel.addCSS(new customStyle({background:"url('RasterEdge_Resource_Files/images/demo.png') no-repeat -73px 0px",width:"31px",height:"40px",marginRight:"15px"}));
    _userCmdDemoExcel.addParameter(new customCmd({RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/excel/demo_1.xlsx"}));
    _tabDemoFiles.addCommand(_userCmdDemoExcel);
    
     var _userCmdDemoPPT = new UserCommand("ppt");
    _userCmdDemoPPT.addCSS(new customStyle({background:"url('RasterEdge_Resource_Files/images/ppt.png') no-repeat 0px 0px",width:"31px",height:"40px",marginRight:"15px"}));
    _userCmdDemoPPT.addParameter(new customCmd({RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/ppt/demo_1.pptx"}));
    _tabDemoFiles.addCommand(_userCmdDemoPPT);
    
    //Scenario 2:Custom ID and Event. But you should define the event in customViewer.js and define style in RasterEdge.css.
    var _userCmdDemoTiff = new UserCommand("tiff");
    _userCmdDemoTiff.addId("_tiff");
    _userCmdDemoTiff.addEvent(tiffClickEvent);
    _tabDemoFiles.addCommand(_userCmdDemoTiff);
    
    //Scenario 3:In addition to the div element,If you need button,input,checkbox......,you can call addHtmlDOM().
    //excelHtmlDom defined in customViewer.js
    var _userCmdDemoDicom = new UserCommand("dicom");
    _userCmdDemoDicom.addHtmlDOM(dcmHtmlDom);
    _tabDemoFiles.addCommand(_userCmdDemoDicom);
    
    _viewerTopToolbar.addTab(_tabDemoFiles);
</script>

</head>
<body id=""> 
        <div class="re_header">
	        <div class="re_header_content">
                &nbsp;<a class="re_header_logo" href="http://www.rasteredge.com/"><img src="RasterEdge_Resource_Files/images/RE_logo.jpg" title="www.rasteredge.com" width="206" height="38" border="0" alt="www.rasteredge.com"/></a>
		        <div class="re_header_title">HTML Document Viewer with Annotations</div>
		        <a class="re_header_download" href="http://www.rasteredge.com/dotnet-imaging/eval_download.php"><img src="RasterEdge_Resource_Files/images/RE_wt_download.jpg" width="206" height="60" alt="" border="0"/></a>
	        </div>
        </div>
        
        <div class="re_container">        
	        <div class="re_func_toolbar"></div>
            <div class="re_content"></div>  	
        </div>
        
        <div class="re_footer" >
		    RasterEdge.com is professional provider of document, content and imaging solutions, available for ASP.NET AJAX, Windows Forms. We are dedicated to provide powerful & profession imaging controls and components for capturing, viewing, processing, converting, compressing and storing images, documents and more. 
		    <span>&copy;2000-2015 RasterEdge.com</span>
        </div>  
</body> 
</html>
