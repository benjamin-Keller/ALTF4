<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Department.aspx.cs" Inherits="Info_IT.Pages.Department" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Department | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
    <script type="text/javascript" src="../Script/Scripts.js">
        
    </script>
    
    
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<%--<h2>Department.aspx</h2>--%>

    <div class="contentWrapperReport">
			<div>
				<!-- Side Nav -->
                
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="openFlatButtonDepartment()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonDepartment" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageAdd"  Text="Add Department"></asp:button>
                    </div>
                    <div id="updateButtonDepartment" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="BtnManageUpdate_Click" Text="Update Department" ></asp:button>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">
                     <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>

                    <div style="background-color:red;color:white; display:none" id="lblError"><label>Error try again</label></div>
					<div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; width:auto">Name:</label>
						<label style="position:absolute; left:420px">Building:</label>
						<label style="position:absolute; left:550px; width:126px; top: 0px;">Contact Person:</label>
						<label style="position:absolute; left:750px; top: 0px; width: 124px;">Contact Number:</label>
						<label style="position:absolute; left:950px; top: 0px; width: 127px;">Email Address:</label><br />

						<asp:TextBox runat="server" ID="txtName" style="position:absolute; left:220px"/>
						<asp:DropDownList runat="server" ID="cmbBuilding"  style="position:absolute; left:415px; width: 110px; height: 22px"/>
						<asp:TextBox runat="server" ID="txtContactPerson"  style="position:absolute; left:550px"/>
						<asp:TextBox runat="server" ID="txtContactNo"  style="position:absolute; left:750px"/>
						<asp:TextBox runat="server" ID="txtEmailAddress"  style="position:absolute; left:950px"/>
					</div>

                   

					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgDepartment" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgDepartment_Load1" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnSelectedIndexChanged="dgDepartment_SelectedIndexChanged" OnEditCommand="dgDepartment_EditCommand">
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