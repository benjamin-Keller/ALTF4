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
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey; ">
					<div onclick="openFlatButtonRequest()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonRequest" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageAdd"  Text="Add Request"></asp:button>
                    </div>
                    <div id="updateButtonRequest" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageUpdate" Text="Update Request" ></asp:button>
					</div>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					<div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px">Description:</label>
						<label style="position:absolute; left:400px">Staff:</label>
						<label style="position:absolute; left:580px">Student:</label>
						<label style="position:absolute; left:760px; width:150px">Task Type:</label>       
                        
                        <br />

                        <asp:TextBox runat="server" ID="txtDescription" style="position:absolute; width:150px; left:220px"/>
						<asp:DropDownList runat="server" ID="cmbStaff" style="position:absolute; width:150px; left:400px"/>
						<asp:DropDownList runat="server" ID="cmbStudentCode"  style="position:absolute; width:150px; left:580px"/>
						<asp:DropDownList runat="server" ID="cmbTaskTypeCode"  style="position:absolute; width:150px; left:760px"/>

                        <br /><br />

                        <label style="position:absolute; left:220px;">Time:</label>
                        <label style="position:absolute; left:400px; width:150px;">Assigned Staff:</label>
                        <label style="position:absolute; left:580px;">Status:</label>
                        <label style="position:absolute; left:760px;">Date:</label>

                        <br />
                        
						<asp:DropDownList runat="server" ID="cmbTime" style="position:absolute; left:220px; width:150px;">
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
						<asp:DropDownList runat="server" ID="cmbAssignedStaffCode"  style="position:absolute; left:400px; width:150px;"/>
						<asp:DropDownList runat="server" ID="cmbStatus"  style="position:absolute; left:580px; width:150px;">
                            <asp:ListItem>Pending</asp:ListItem>
                            <asp:ListItem>In Progress</asp:ListItem>
                            <asp:ListItem>Completed</asp:ListItem>
                            <asp:ListItem>Cancelled</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:760px;"/>
					</div>

                    <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>

					<!-- DataGrid -->
					<div style="position:relative; top:300px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgRequest" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgRequest_Load1" OnSelectedIndexChanged="dgRequest_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
                       </ContentTemplate>
				   </asp:UpdatePanel>
			</div>    
    </div>
</asp:Content>