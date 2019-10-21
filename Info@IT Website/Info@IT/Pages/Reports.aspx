<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Info_IT.Pages.Reports" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Reports | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
    <script src="../Script/Scripts.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	
		<div class="contentWrapperReport">
			<div class="centerPHReport">
				<!-- Filling in blank space -->
	<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey" >
				<div style="height: 100%; " class="sidebarReport">
					
                    <div onclick="reportEquipment()" class="manage_Style">
                        Equipment
                    </div>

                    <div id="reportEquipment"  style="display:none">

                    </div>

                    <div onclick="reportVenue()" class="manage_Style">
                            Venue
                        </div>

                    <div id="reportVenue" style="display:none">
                        

                       <div style="position:relative; float:right; top:0; height: 50%; width:100%;">
                            <label style = "position:absolute; left:220px; width:auto; top: 0px;">Description</label>
                            <label style = "position:absolute; left:420px; top:0px; width:124px">Capacity</label>
                            <label style = "position:absolute; left :560px; top:0px; width:126px">DoorNumber</label>
                            <label style = "position:absolute; left :750px; top: 0px;">BuildingBlocks</label>
                            <label style = "position:absolute; left :910px; top: 0px;">Building</label>
       
                             <asp:TextBox runat="server" ID="txtDescription"  style="position:absolute; left:220px; top: 20px;" /> 
                             <asp:TextBox runat="server" ID="txtCapacity" style="position:absolute; left:415px; top: 20px; width: 119px;"/>
                             <asp:TextBox runat="server" ID="txtDoorNumber" style="position:absolute; left:559px; top: 20px; width: 167px;"/> 
                             <asp:DropDownList ID="cmbBuildingBlocks" runat="server"  style="position:absolute; left:750px; width: 110px; height: 25px; top: 20px;"/>
                             <asp:DropDownList ID ="cmbBuilding" runat ="server" style="position:absolute; left:910px; width: 113px; height: 25px; top: 20px;"/>
                       </div>
					        <!-- DataGrid -->
					        <div style="position:relative; top:35px; left: 225px; height: 50%; background-color: darkgrey">
						        <asp:DataGrid runat="server" ID="dgVenue" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" >
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


                    <div onclick="reportDepartment()" class="manage_Style">
                           Department
                        </div>

                    <div id="reportDepartment" style="display:none">

					    <div style="position:relative; top:0; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px; width:auto">Name:</label>
						    <label style="position:absolute; left:420px">Building:</label>
						    <label style="position:absolute; left:550px; width:126px; top: 0px;">Contact Person:</label>
						    <label style="position:absolute; left:750px; top: 0px; width: 124px;">Contact Number:</label>
						    <label style="position:absolute; left:950px; top: 0px; width: 127px;">Email Address:</label><br />

						    <asp:TextBox runat="server" ID="txtName" style="position:absolute; left:220px"/>
						    <asp:DropDownList runat="server" ID="DropDownList1"  style="position:absolute; left:415px; width: 110px; height: 22px"/>
						    <asp:TextBox runat="server" ID="txtContactPerson"  style="position:absolute; left:550px"/>
						    <asp:TextBox runat="server" ID="txtContactNo"  style="position:absolute; left:750px"/>
						    <asp:TextBox runat="server" ID="txtEmailAddress"  style="position:absolute; left:950px"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgDepartment" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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

                    <div onclick="reportRequest()" class="manage_Style">
                            Request
                        </div>

                    <div id="reportRequest" style="display:none">

                    </div>

                    <div onclick="reportTutorRequest()" class="manage_Style">
                            Tutor Request
                        </div>

                    <div id="reportTutorRequest" style="display:none">

                    </div>

                    <div onclick="reportInspection()" class="manage_Style">
                            Inspection
                        </div>

                    <div id="reportInspection" style="display:none">

                    </div>

                    <div onclick="reportTaskType()" class="manage_Style">
                            Task Type
                        </div>

                    <div id="reportTaskType" style="display:none">

                    </div>

                    <div onclick="reportStudent()" class="manage_Style">
                            Student
                        </div>

                    <div id="reportStudent" style="display:none">

                    </div>

                    <div onclick="reportStaff()" class="manage_Style">
                            Staff
                        </div>

                    <div id="reportStaff" style="display:none">

                    </div>

                    </div>

				</div>
        </div>
                </div>

		
</asp:Content>