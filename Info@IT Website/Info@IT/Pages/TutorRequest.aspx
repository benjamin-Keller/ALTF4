﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="TutorRequest.aspx.cs" Inherits="Info_IT.Pages.TutorRequest" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Tutor Request | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonTutorRequest()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonTutorRequest" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Tutor Request</p>
					</div>
                    <div id="updateButtonTutorRequest" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Tutor Request</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					
					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; background-color: darkgrey; width: 231px;">
						<asp:DataGrid runat="server" ID="dgTutorRequest" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgTutorRequest_Load1" OnSelectedIndexChanged="dgTutorRequest_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanged="dgTutorRequest_PageIndexChanged">
							<AlternatingItemStyle BackColor="White" ForeColor="#284775" />
							<EditItemStyle BackColor="#999999" />
							<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
							<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
							<SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
						</asp:DataGrid>
                </div>
			</div>
    </div>
</asp:Content>