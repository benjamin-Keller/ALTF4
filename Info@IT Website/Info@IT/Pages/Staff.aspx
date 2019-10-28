<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Info_IT.Pages.Staff" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Staff | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
	<script src="../Script/Scripts.js"></script>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
	         <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	         <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
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
                    <div id="addButtonStaff" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageAdd"  Text="Add Staff"></asp:button>
                    </div>
                    <div id="updateButtonStaff" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageUpdate" Text="Update Staff" ></asp:button>
					</div>
				</div>


				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px;">
                    
                    <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>
                    <div style="position:relative; top:0; height: 50%; width:100%;">
						
                        <label style="position:absolute; left:220px; width:150px;">Staff Number:</label>
						<label style="position:absolute; left:400px; width:150px;">First Name:</label>
						<label style="position:absolute; left:580px; width:150px;">Last Name:</label>
						<label style="position:absolute; left:760px; width:150px;">Email Address:</label>
						<label style="position:absolute; left:940px; width:150px;">Contact Number:</label>
                        
                        <br />

						<asp:TextBox runat="server" ID="txtStaffNo" style="position:absolute; left:220px; width:150px;"/>
						<asp:TextBox runat="server" ID="txtFirstName"  style="position:absolute; left:400px; width:150px;"/>
						<asp:TextBox runat="server" ID="txtLastName"  style="position:absolute; left:580px; width:150px;"/>
						<asp:TextBox runat="server" ID="txtEmail"  style="position:absolute; left:760px; width:150px;" />
						<asp:TextBox runat="server" ID="txtContactNumber"  style="position:absolute; left:940px; width:150px;"/>
                        
                        <br />
                        
                        <label style="position:absolute; left:220px; width:150px;">Staff Type:</label>
                        <label style="position:absolute; left:400px; width:150px;">Department Code:</label>
                        <label style="position:absolute; left:580px; width:150px;">Username:</label>
                        <label style="position:absolute; left:760px; width:150px;">Password:</label>
                        <label style="position:absolute; left:940px; width:150px;">Active Status:</label>
                        
                        <br />
                        
                        <asp:DropDownList runat="server" ID="cmbStaffType" style="position:absolute; left:220px; width:150px; height:21px">
                            <asp:ListItem>ICT</asp:ListItem>
                            <asp:ListItem>Info@IT</asp:ListItem>
                            <asp:ListItem>Student Assistant</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList  runat="server" ID="cmbDepartmentCode" style="position:absolute; left:400px; width:150px; height:21px"/>
                        <asp:TextBox runat="server" ID="txtUsername" style="position:absolute; left:580px; width:150px;"/>
                        <asp:TextBox runat="server" ID="txtPassword" style="position:absolute; left:760px; width:150px;"/>
                        <asp:DropDownList runat="server" ID="cmbActiveStatus" style="position:absolute; left:940px; width:150px; height:21px">
                            <asp:ListItem>True</asp:ListItem>
                            <asp:ListItem>False</asp:ListItem>
                        </asp:DropDownList>
					
                    </div>
					

					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgStaff" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgStaff_Load1" OnSelectedIndexChanged="dgStaff_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
    </div>
</asp:Content>