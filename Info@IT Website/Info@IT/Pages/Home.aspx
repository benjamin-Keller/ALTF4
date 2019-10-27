<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Info_IT.Pages.Default" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Default | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<!-- You program in here -->
	<div class="contentWrapperReport" style="text-align:center;vertical-align:middle; min-width:100%; padding:2px">
		<div class="jumbotron jumbotron-fluid" >
			<div class="container" style="width: calc(100vw - 205px);">
				<h1><asp:Label runat="server" ID="Welcome" Text="Welcome!" /></h1>
				<h3><asp:Label runat="server" ID="lblRole" /></h3>
			</div>
		</div>


        <asp:Label Font-Size="Medium" runat="server" ID="Label1" Text="Please use the Navigation bar on<br />the left to navigate the website.<br /><br />Log out via the button in the<br />top-right." />
	</div>
</asp:Content>