<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="TutorRequest.aspx.cs" Inherits="Info_IT.Pages.TutorRequest" %>
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
                    <div  id="addButtonTutorRequest" class="manageAdd" >
						<asp:button runat="server" class="manage" style="padding-top:0px" OnClick ="btnManageAdd" Text="Add Tutor Request"></asp:button>
					</div>
                    <div id="updateButtonTutorRequest" class="manageAdd_Style">
						
						<asp:button runat="server" class="manage"   style="padding-top:0px" OnClick="btnManageUpdate" Text="Update Tutor Request"></asp:button>
					</div>
	         </div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">
                    <div style ="position:relative ; top:0 ; height: 50% ; width:100%;">
                        
						<label style="position:absolute; left:220px">Description:</label>
						<label style="position:absolute; left:950px; width:126px; top: 0px;">Date:</label>
						<label style="position:absolute; left:550px; top: 0px; width: 124px;">ModuleDescriptions:</label>
						<label style="position:absolute; left:750px; top: 0px; width: 127px;">VenueDescription:</label>
                        <label style="position:absolute; left:220px; top: 55px; width: 127px;">Start Time:</label>
                        <label style="position:absolute; left:400px; top: 55px; width: 127px;">End Time:</label>
                        <label style="position:absolute; left:400px; top: 0px; width: 130px;">Status:</label><br />


                        <asp:DropDownList runat="server" ID="cmbRequestCode"  style="position:absolute; left:220px; width: 110px; height: 22px"/>
                        <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:950px; top: 25px;"/>
                        <asp:DropDownList runat="server" ID="cmbModuleCode"  style="position:absolute; left:550px; width: 130px; height: 22px"/>
                        <asp:DropDownList runat="server" ID="cmbVenueCode"  style="position:absolute; left:750px; width: 124px; height: 22px"/>
                        <asp:DropDownList runat="server" ID ="cmbStartTime" style="position:absolute; left:220px;top: 75px; width: 124px; height: 22px">
                            <asp:ListItem>08:00:00</asp:ListItem>
                            <asp:ListItem>08:30:00</asp:ListItem>
                            <asp:ListItem>09:00:00</asp:ListItem>
                            <asp:ListItem>09:30:00</asp:ListItem>
                            <asp:ListItem>10:00:00</asp:ListItem>
                            <asp:ListItem>10:30:00</asp:ListItem>
                            <asp:ListItem>11:00:00</asp:ListItem>
                            <asp:ListItem>11:30:00</asp:ListItem>
                            <asp:ListItem>12:00:00</asp:ListItem>
                            <asp:ListItem>12:30:00</asp:ListItem>
                            <asp:ListItem>13:00:00</asp:ListItem>
                            <asp:ListItem>13:30:00</asp:ListItem>
                            <asp:ListItem>14:00:00</asp:ListItem>
                            <asp:ListItem>14:30:00</asp:ListItem>
                            <asp:ListItem>15:00:00</asp:ListItem>
                            <asp:ListItem>15:30:00</asp:ListItem>
                            <asp:ListItem>16:00:00</asp:ListItem>
                            <asp:ListItem>16:30:00</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList runat ="server" ID="cmbEndTime" style="position:absolute; left:400px; top: 75px; width: 124px; height: 22px">
                            <asp:ListItem>08:00:00</asp:ListItem>
                            <asp:ListItem>08:30:00</asp:ListItem>
                            <asp:ListItem>09:00:00</asp:ListItem>
                            <asp:ListItem>09:30:00</asp:ListItem>
                            <asp:ListItem>10:00:00</asp:ListItem>
                            <asp:ListItem>10:30:00</asp:ListItem>
                            <asp:ListItem>11:00:00</asp:ListItem>
                            <asp:ListItem>11:30:00</asp:ListItem>
                            <asp:ListItem>12:00:00</asp:ListItem>
                            <asp:ListItem>12:30:00</asp:ListItem>
                            <asp:ListItem>13:00:00</asp:ListItem>
                            <asp:ListItem>13:30:00</asp:ListItem>
                            <asp:ListItem>14:00:00</asp:ListItem>
                            <asp:ListItem>14:30:00</asp:ListItem>
                            <asp:ListItem>15:00:00</asp:ListItem>
                            <asp:ListItem>15:30:00</asp:ListItem>
                            <asp:ListItem>16:00:00</asp:ListItem>
                            <asp:ListItem>16:30:00</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList runat="server" ID="cmbStatus"  style="position:absolute; left:400px; width: 110px; height: 22px">
                            <asp:ListItem>Pending</asp:ListItem>
                            <asp:ListItem>In Progress</asp:ListItem>
                            <asp:ListItem>Completed</asp:ListItem>
                            <asp:ListItem>Cancelled</asp:ListItem>
                        </asp:DropDownList>
                    </div>

					
					<!-- DataGrid -->
					<div style="position:relative; top:230px; left: 220px; background-color: darkgrey; height: 50%">
						<asp:DataGrid runat="server" ID="dgTutorRequest" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgTutorRequest_Load1" OnSelectedIndexChanged="dgTutorRequest_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanged="dgTutorRequest_PageIndexChanged">
							<AlternatingItemStyle BackColor="White" ForeColor="#284775" />
							<Columns>
								<asp:ButtonColumn CommandName="Select" Text="Select"></asp:ButtonColumn>
							</Columns>
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