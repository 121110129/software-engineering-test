<%@ Control Language="C#" AutoEventWireup="true" CodeFile="head.ascx.cs" Inherits="Web_head" %>
<%@ Register Src="~/Web/weatherWidget.ascx" TagPrefix="uc1" TagName="weatherWidget" %>

<!-- Bootstrap -->
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
<link href="css/mystyle.css" rel="stylesheet" type="text/css" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--[if lt IE 9]>
     <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
     <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!-- start plugins -->
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/bootstrap.js"></script>
<!----font-Awesome----->
<link rel="stylesheet" href="fonts/css/font-awesome.min.css"/>
<!----font-Awesome----->

<div class="header_bg">
        <div class="container">
	        <div class="row header" style="padding:0px;">
		        <div class="logo navbar-left">
                    <a href="index.aspx"><img src="../images/logo.jpg" class="pull-left" style="max-width:100px;max-height:100px;"/></a>
                    <div class="pull-right" style="margin-left:10px;">
                        <h1 class="content_right pull-top" style="margin:0px;margin-right:20px;margin-top:10px;"><a href="index.aspx" style="font-family:'Microsoft YaHei UI';font-weight:500;color:black">极致141</a></h1>
                        <h1 class="content_right pull-bottom" style="margin:0px;margin-bottom:10px;margin-right:20px;"><a href="index.aspx" style="font-family:'Microsoft YaHei UI';font-weight:500;color:black;font-style:italic;text-transform:capitalize;font-size:medium">Supreme service one for one</a></h1>
                    </div>
		        </div>
		       <div style="float:right">
                   <uc1:weatherWidget runat="server" ID="weatherWidget" />
		       </div>
		        <div class="clearfix"></div>
	        </div>
        </div>
    </div>