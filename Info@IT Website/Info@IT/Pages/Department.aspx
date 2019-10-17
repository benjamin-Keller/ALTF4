<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Info_IT.Pages.Department" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Department | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
    <script type="text/javascript" src="../Script/Scripts.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<%--<h2>Department.aspx</h2>--%>

    <div class="contentWrapperReport">
			<div>
				<!-- Filling in blank space -->
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="openFlatButtonDepartment()" style="background-color: black; height: 52px; padding-top: 1px">
						<%--<ul class="sidebarReport">
							<li><a href="Default.aspx">Manage</a></li>
						</ul>--%>
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonDepartment" style="background-color: black; height: 52px; padding-top: 1px; display: none">
						
						<p class="manage" style="padding-top: 0px">Add Department</p>
					</div>
				</div>
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					<div style="position:relative; top:0; height: 50%; width:100%; background-color: blue;">
						<label style="position:absolute; left:220px; width:auto">Name:</label>
						<label style="position:absolute; left:420px">Building:</label>
						<label style="position:absolute; left:550px; width:126px; top: 0px;">Contact Person:</label>
						<label style="position:absolute; left:750px; top: 0px; width: 124px;">Contact Number:</label>
						<label style="position:absolute; left:950px; top: 0px; width: 127px;">Email Address:</label><br />

						<asp:TextBox runat="server" ID="txtName" style="position:absolute; left:220px"/>
						<asp:DropDownList runat="server" ID="cmbBuilding"  style="position:absolute; left:415px; width: 110px; height: 22px"/>
						<asp:TextBox runat="server" ID="txtContactPerson"  style="position:absolute; left:550px"/>
						<asp:TextBox runat="server" ID="txtContactNo"  style="position:absolute; left:750px"/>
						<asp:TextBox runat="server" ID="txtEmailAddress"  style="position:absolute; left:950px"/>
					</div>

					<div style="position:relative; top:50%; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgDepartment" style="width:50%; height:50%; vertical-align:middle;"/>
					</div>

                </div>
			</div>
    </div>
</asp:Content>