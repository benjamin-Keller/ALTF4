<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Info_IT.Pages.Student" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Student | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonStudent()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonStudent" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px;height:inherit;background-color: #696969;border:none" OnClick="btnManageAdd"  Text="Add Student"></asp:button>
                    </div>
                    <div id="updateButtonStudent" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px;height:inherit;background-color: #696969;border:none" OnClick="btnManageUpdate" Text="Update Student" ></asp:button>
					</div>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

                    <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					<div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; width: 150px;">Student Number:</label>
						<label style="position:absolute; left:400px">Name:</label>
						<label style="position:absolute; left:580px">Surname:</label>
						<label style="position:absolute; left:760px; width: 150px;">Email Address:</label>
                        
                        <br />

						<asp:TextBox runat="server" ID="txtStudentNumber" style="position:absolute; left:220px; width: 150px;"/>
						<asp:TextBox runat="server" ID="txtName" style="position:absolute; left:400px; width: 150px;"/>
						<asp:TextBox runat="server" ID="txtSurname"  style="position:absolute; left:580px; width: 150px;"/>
						<asp:TextBox runat="server" ID="txtEmailAddress"  style="position:absolute; left:760px; width: 150px;"/>
					</div>

                        <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>

					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgStudent" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgStudent_Load1" OnSelectedIndexChanged="dgStudent_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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