<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Info_IT.Pages.Default" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Default | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<!-- You program in here -->
	<div class="contentWrapperReport" style="text-align:center;vertical-align:middle; min-width:100%; padding:2px">
        <div style="position:relative; top:20%; left:120%; text-align:center; font-size:xx-large; vertical-align:middle; background-color: #0064c8; color:white; font:bold">
        <asp:Label runat="server" ID="Welcome" Text="Welcome!" /><br /><br />
        <asp:Label runat="server" ID="lblRole" /><br /><br />
        <asp:Label runat="server" ID="Label1" Text="Please use the Navigation bar on<br />the left to navigate the website.<br /><br />Log out via the button in the<br />top-right." />
        </div>
	</div>
</asp:Content>