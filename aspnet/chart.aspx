<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chart.aspx.cs" Inherits="aspnet.chart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Input</title>
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="ui/jqx/css/jqx.base.css" rel="stylesheet" type="text/css" media="all"/>
    <link href="ui/jqx/css/jqx.bootstrap.css" rel="stylesheet" type="text/css" media="all"/>
    
    <script type="text/javascript" src="ui/jqx/script/jquery-1.12.4.min.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxcore.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdata.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxdraw.js"></script>
    <script type="text/javascript" src="ui/jqx/js/jqxchart.core.js"></script>  
 
    <script>
        var connectString = "Data Source=wnl;Initial Catalog=eldb;User ID=sa;Password=Sa12345@";

        function f_load() {
            $("#demo .content").remove();
            $('#demo').append('<div class="content" />');
           $('#demo .content').load('apps/chart.html');
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

        <div>
            <h1>Widget Chart</h1>
        </div>
        
         <div id="demo">
               <div class="content">

               </div>
         </div>

        
    </form>
</body>
</html>