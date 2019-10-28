<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Venue.aspx.cs" Inherits="Info_IT.Pages.Venue" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Venue | Info@IT HelpDesk Web-System</asp:Content>

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
					<div onclick="openFlatButtonVenue()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonVenue" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageAdd"  Text="Add Venue"></asp:button>
                    </div>
                    <div id="updateButtonVenue" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px" OnClick="btnManageUpdate" Text="Update Venue" ></asp:button>
					</div>
					</div>
				</div>

				<!-- Content -->
           <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

               <div style="position:relative; top:0; height: 50%; width:100%;">
                   <label style = "position:absolute; left:220px;">Description</label>
                   <label style = "position:absolute; left:400px;">Capacity</label>
                   <label style = "position:absolute; left:580px;">Door Number</label>
                   <label style = "position:absolute; left:760px;">Building Blocks</label>
                   <label style = "position:absolute; left:940px;">Building</label>

                   <br />
       
                   <asp:TextBox runat="server" ID="txtDescription"  style="position:absolute; left:220px; width: 150px;" /> 
                   <asp:TextBox runat="server" ID="txtCapacity" style="position:absolute; left:400px; width: 150px;"/>
                   <asp:TextBox runat="server" ID="txtDoorNumber" style="position:absolute; left:580px; width: 150px;"/> 
                   <asp:DropDownList ID="cmbBuildingBlocks" runat="server"  style="position:absolute; left:760px; width: 150px; height: 21px"/>
                   <asp:DropDownList ID ="cmbBuilding" runat ="server" style="position:absolute; left:940px; width: 150px; width: 150px; height: 21px"/>
               </div>
                    <%--<div style="position:relative; top:-2147483648%; height: 50%; background-color: darkgrey; left: 1px;"></div>--%>

			   <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>
				   
						<!-- DataGrid -->
						<div style="position:relative; top:65px; left: 220px; height: 50%; background-color: darkgrey">
							<asp:DataGrid runat="server" ID="dgVenue" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgVenue_Load1" OnSelectedIndexChanged="dgVenue_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanged="dgVenue_PageIndexChanged">
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