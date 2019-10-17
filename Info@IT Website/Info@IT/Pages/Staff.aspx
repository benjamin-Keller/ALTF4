<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Info_IT.Pages.Staff" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Staff | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
	<script src="../Script/Scripts.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<div class="contentWrapperReport">
			<div>
				<!-- Side Nav -->
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="openFlatButtonStaff()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonStaff" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Staff</p>
					</div>
                    <div id="updateButtonStaff" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Staff</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					

                </div>
			</div>
    </div>
</asp:Content>