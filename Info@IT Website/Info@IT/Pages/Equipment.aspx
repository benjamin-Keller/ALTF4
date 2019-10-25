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
				
                <div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey; ">
					<div onclick="openFlatButtonEquipment()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonEquipment" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageAdd"  Text="Add Equipment"></asp:button>
                    </div>
                    <div id="updateButtonEquipment" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageUpdate" Text="Update Equipment" ></asp:button>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

					<div style="position:relative; top:0; height: 50%; width:100%;">
                        <label style="position:absolute; left:220px; top: 0px; width: 128px;">Description:</label>
                        <label style="position:absolute; left:420px; top: 0px; width: 128px;">Venue:</label>
                        <label style="position:absolute; left:620px; top: 0px; width: 128px;">Equipment Type:</label>
                          
						<asp:TextBox runat="server" ID="txtDescription" style="position:absolute; left:220px; top: 24px; width: 128px;"/>
                        <asp:DropDownList runat="server" ID="cmbVenue" style="position:absolute; left:420px; top: 24px; width: 128px;"/>
                        <asp:DropDownList runat="server" ID="cmbEquipType" style="position:absolute; left:620px; top: 24px; width: 128px;"/>
					</div>

                  
					
					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgEquipment" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgEquipment_Load1" OnSelectedIndexChanged="dgEquipment_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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