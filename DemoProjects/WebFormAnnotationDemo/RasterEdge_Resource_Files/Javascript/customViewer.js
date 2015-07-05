//Two important global variables
//_fid:Uniquely identifies of the current file on the server side
//_fileName:The current file name

//important JS function
//getServerHandlerUrl():return path of  the handler
//getCurrentAspx():return path of the default page.(Default.aspx)
//GetJsonDoc(): return jsonDoc which includes all information of current file as well as annotations.


//Id:Uniquely identified[Id can be used to change the style... ]
//JSEvent:Click the icon to trigger the JSEvent
//JsonData:Transmission parameters
//ServerHandler:function on the server side calls
//JSCallBack:After the server response call this function at client

//[[Note:jsonDoc includes all information of Annotations, you can call GetJsonDoc() to get jsonDoc]]
//Tab File
//upload:{Id:re_func_upload,JSEvent:ShowUploadDialog(),JsonData:null,ServerHandler:LoadFileFromUpload(),JSCallback:ParameterDocumentLoad(response)};
//print:{Id:re_func_print,JSEvent:ShowDialog("print"),JsonData:{fid,fileName,JsonDoc},ServerHandler:PrintFile,JSCallback:OpenSpecifiedFile(response)};
//save:{Id:re_func_save,JSEvent:ShowDialog("save"),JsonData:{fid,fileName,JsonDoc},ServerHandler:SaveFile,JSCallback:};
//convert:{Id:re_func_convert,JSEvent:ShowDialog("convert"),JsonData:{fid,fileName,_scaleValue,jsonDoc}};
//full:{Id:re_func_full}

//Tab Annotation
//text:{Id:re_func_text}
//freeHand:{Id:re_func_freeHand}
//highLight:{Id:re_func_highlight}
//rectangle:{Id:re_func_rectangle}
//filledRectangle:{Id:re_func_filledRectangle}
//ellipse:{Id:re_func_ellipse}
//rubberStamp:{Id:re_func_rubberStamp}
//PolygonLines:{Id:PolygonLines}
//polygon:{Id:re_func_line}
//line:{Id:PolygonLines}
//arrow:{Id:re_func_arrow}
//OutLineAppearence:{Id:OutLine}
//FillAppearence:{Id:Fill}
//TextAppearence:{Id:Text}
//delete:{Id:re_func_deleteAnnotation}


//Tab Custom[for example: Sample Files]
var tiffClickEvent = function()
{
    showLoading();
    var options = {
        type: "POST",
        url: getCurrentAspx(),
        async:false,
        data: {RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/tiff/demo_1.TIF"}, 
        success: function(response) {
             ParameterDocumentLoad(response);
        },
        error: function() {  
            LoadErrorHandle();
        }  
    }	
    $.ajax(options);
}

function customClickEvent()
{
    showLoading();
    var options = {
        type: "POST",
        url: getCurrentAspx(),
        async:false,
        data: {RECommand:"userDefined",FileName:"/RasterEdge_Demo_Docs/dicom/demo_1.dcm"}, 
        success: function(response) {
            ParameterDocumentLoad(response);
        },
        error: function() {  
            LoadErrorHandle();
        }  
    }	
    $.ajax(options);
}
var dcmHtmlDom = "<div id='_dicom' style='float:left;' Onclick='customClickEvent();'></div>";
