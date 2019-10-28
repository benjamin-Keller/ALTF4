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
                    <div id="addButtonInspection" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageAdd"  Text="Add Inspection"></asp:button>
                    </div>
                    <div id="updateButtonInspection" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageUpdate" Text="Update Inspection" ></asp:button>
					</div>
				</div>


				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px;">
                    
                    <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>

                    <div style="position:relative; top:0; height: 50%; width:100%;">

						<label style="position:absolute; left:220px; width:150px" >Venue:</label>
						<label style="position:absolute; left:400px; width:150px">Staff Code:</label>
						<label style="position:absolute; left:580px; width:150px">Inspection Time:</label>
						<label style="position:absolute; left:760px; width:150px">Comment:</label><br/>
                        
						<asp:DropDownList runat="server" ID="cmbVenue" style="position:absolute; left:220px;width:150px;"/>
						<asp:DropDownList runat="server" ID="cmbStaffCode"  style="position:absolute; left:400px; width: 150px;"/>
						<asp:TextBox runat="server" ID="txtInspectTime"  style="position:absolute; left:580px;width:150px"/>
						<asp:TextBox runat="server" ID="txtComment"  style="position:absolute; left:760px; width: 150px;"/><br/>

                        <label style="position:absolute; left:220px; width:150px">Inspection Date:</label><br/>
                        <asp:Calendar runat="server" ID="calInspectDate" selectionmode="DayWeekMonth" style="position:absolute; left:220px;"/><br/>
					</div>
					
					<!-- DataGrid -->
					<div style="position:relative; top:200px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgInspection" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgInspection_Load1" OnSelectedIndexChanged="dgInspection_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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