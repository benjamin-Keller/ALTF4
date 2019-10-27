<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Info_IT.Pages.Login" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Login | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<!-- You program in here -->
	<div class="centerText">
		<asp:Label runat="server" Text="Username" />
        <asp:TextBox runat="server" ID="txtUsername" Text="Username" /><br />
        <asp:Label runat="server" Text="Password" />
        <asp:TextBox runat="server" ID="txtPassword" Text="Password" />
	</div>
</asp:Content>