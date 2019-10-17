<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Equipment.aspx.cs" Inherits="Info_IT.Pages.Equipment" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Equipment | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonEquipment()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonEquipment" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Equipment</p>
					</div>
                    <div id="updateButtonEquipment" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Equipment</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					

                </div>
			</div>
    </div>
</asp:Content>