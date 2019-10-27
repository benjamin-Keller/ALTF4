<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="TaskType.aspx.cs" Inherits="Info_IT.Pages.TaskType" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Task Type | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonTaskType()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div  id="addButtonTaskType" class="manageAdd" >
						
                        <asp:button runat="server" class="manage" style="padding-top:0px; width: 200px;background-color:grey" OnClick="btnManageAdd" Text="Add TaskType"></asp:button>
					</div>
                    <div id="updateButtonTaskType" class="manageAdd_Style">		
						<asp:button runat="server" class="manage" style="padding-top:0px; width: 200px;background-color:grey" OnClick="btnManageUpdate" Text="Update TaskType"></asp:button>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">
                    <div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; width:56px; top:0px">Name:</label>

                        <asp:TextBox runat="server" ID="txtName" style="position:absolute; left:219px ; height:22px; top: 22px;"/>
                    </div>

					<asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>

					<!-- DataGrid -->
					<div style="position:relative; top:62px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgTaskType" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgTaskType_Load1" OnSelectedIndexChanged="dgTaskType_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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