<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scheduler.aspx.cs" Inherits="aspnet.scheduler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Input</title>
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="ui/jqx/css/jqx.base.css" rel="stylesheet" type="text/css" media="all"/>
    <link href="ui/jqx/css/jqx.bootstrap.css" rel="stylesheet" type="text/css" media="all"/>
    
    <script type="text/javascript" src="/ui/jqx/script/jquery-1.12.4.min.js"></script>
    
    <script type="text/javascript" src="ui/jqx/js/jqxcore.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxnavigationbar.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxmenu.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdata.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdata.export.js"></script>
    
    <script type="text/javascript" src="ui/jqx/js/jqxbuttons.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxbuttongroup.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxscrollbar.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.selection.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.edit.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.sort.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.filter.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.export.js"></script>  
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.grouping.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.columnsresize.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.columnsreorder.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxgrid.aggregates.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxlistbox.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdropdownlist.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdropdownbutton.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxpanel.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxinput.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxnumberinput.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxcalendar.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdatetimeinput.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxcheckbox.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxradiobutton.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxcombobox.js"></script>
    
    <script type="text/javascript" src="ui/jqx/js/jqxvalidator.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxtabs.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxresponsivepanel.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxtooltip.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxribbon.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxwindow.js"></script> 
    <script type="text/javascript" src="ui/jqx/js/jqxlayout.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdraw.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxchart.core.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxcolorpicker.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxpopover.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxsortable.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdate.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxsplitter.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxscheduler.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxscheduler.api.js"></script>
    <script type="text/javascript" src="ui/jqx/globalization/globalize.js"></script>
    <script type="text/javascript" src="ui/jqx/globalization/globalize.culture.de-DE.js"></script>
   
    
    <script>
        var connectString = "Data Source=wnl;Initial Catalog=eldb;User ID=sa;Password=Sa12345@";

        function f_load() {
            $("#demo_sch .content").remove();
            $('#demo_sch').append('<div class="content" />');
            $('#demo_sch .content').load('apps/sch.html');
        }
                
        $(document).ready(function () {
            f_load();
                   
        });
       
    </script>
</head>
<body>
       <form id="form1" runat="server">
        
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
             <Services>
                 <asp:ServiceReference Path="~/services/shares/mas.svc" />

            </Services>
        </asp:ScriptManager>

     
        <div style="margin-top:5px; "> 
             <h1>Widget Schedule</h1>
          
            <div style="padding:20px;">
                <div id="demo_sch"  style="float:left; position:relative; margin-left:5px; margin-right:5px; clear:both;" >
                    <div  class="content">
                    </div>
                   
                </div>
                <br />
          
               
            </div>
       </div>
            
   
    </form>
</body>
</html>

