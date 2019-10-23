<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Inspection.aspx.cs" Inherits="Info_IT.Pages.Inspection" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Inspection | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonInspection()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonInspection" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Inspection</p>
					</div>
                    <div id="updateButtonInspection" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Inspection</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">
                    <div style="position:relative; top:0; height: 50%; width:100%; background-color: blue;">
						<label style="position:absolute; left:10px; top:-220px;width:100px" >Venue:</label>
						<label style="position:absolute; left:170px; top:-220px;width:150px">Staff Code:</label>
						<label style="position:absolute; left:330px; top:-220px;width:150px">Inspection Time:</label>
						<label style="position:absolute; left:10px; top:-160px;width:150px">Comment:</label>
                        <label style="position:absolute; left:490px; top:-220px;width:150px">Inspection Date:</label><br />

						<asp:DropDownList runat="server" ID="cmbVenue" style="position:absolute; left:10px;top:-190px;width:110px;height:22px"/>
						<asp:DropDownList runat="server" ID="cmbStaffCode"  style="position:absolute; left:170px; width: 110px; height: 22px;top:-190px"/>
						<asp:TextBox runat="server" ID="txtInspectTime"  style="position:absolute; left:330px;top:-190px"/>
						<asp:TextBox runat="server" ID="txtComment"  style="position:absolute; left:10px;top:-130px; width:460px;height:88px"/>
                        <asp:Calendar runat="server" ID="calInspectDate" selectionmode="DayWeekMonth" style="position:absolute; left:490px;top:-190px;"/>
					</div>
					
					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgInspection" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgInspection_Load1" OnSelectedIndexChanged="dgInspection_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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