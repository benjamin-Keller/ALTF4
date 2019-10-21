<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Request.aspx.cs" Inherits="Info_IT.Pages.Request" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Request | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonRequest()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonRequest" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Request</p>
					</div>
                    <div id="updateButtonRequest" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Request</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					<div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px">Description:</label>
						<label style="position:absolute; left:520px">Staff:</label>
						<label style="position:absolute; left:820px">Student:</label>
						<label style="position:absolute; left:1120px; width:192px">Task Type:</label>
                        <label style="position:absolute; left:1120px; top: 72px;">Date:</label>
                        <label style="position:absolute; left:220px; top: 72px;">Time:</label>
                        <label style="position:absolute; left:520px; width:192px; top: 72px;">Assigned Staff:</label>
                        <label style="position:absolute; left:820px; top: 72px;">Status:</label><br />
                        
						<asp:TextBox runat="server" ID="txtDescription" style="position:absolute; width:192px; left:220px"/>
						<asp:DropDownList runat="server" ID="cmbStaff" style="position:absolute; width:192px; left:520px"/>
						<asp:DropDownList runat="server" ID="cmbStudentCode"  style="position:absolute; width:192px; left:820px"/>
						<asp:DropDownList runat="server" ID="cmbTaskTypeCode"  style="position:absolute; width:192px; left:1120px"/>
                        <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:1120px; top: 96px;"/>
						<asp:DropDownList runat="server" ID="cmbTime" style="position:absolute; left:220px; width:192px; top: 96px;"/>
						<asp:DropDownList runat="server" ID="cmbAssignedStaffCode"  style="position:absolute; width:192px; left:520px; top: 96px;"/>
						<asp:DropDownList runat="server" ID="cmbStatus"  style="position:absolute; left:820px; width:192px; top: 96px;"/>
					</div>

					<!-- DataGrid -->
					<div style="position:relative; top:300px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgRequest" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgRequest_Load1" OnSelectedIndexChanged="dgRequest_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
        </div>
</asp:Content>