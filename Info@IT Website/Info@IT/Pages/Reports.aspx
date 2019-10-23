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

                        <div onclick="reportVenue()" class="manage_Style">
                            Venue
                        </div>

                        <div onclick="reportDepartment()" class="manage_Style">
                            Department
                        </div>

                        <div onclick="reportRequest()" class="manage_Style">
                            Request
                        </div>

                        <div onclick="reportTutorRequest()" class="manage_Style">
                            Tutor Request
                        </div>

                        <div onclick="reportInspection()" class="manage_Style">
                            Inspection
                        </div>

                        <div onclick="reportStudent()" class="manage_Style">
                            Student
                        </div>

                        <div onclick="reportStaff()" class="manage_Style">
                            Staff
                        </div>

                    </div>

				</div>

                <%--Begining of right side--%>

                    <div id="reportStaff" style="display:none">

                    </div>

                    <div id="reportStudent" style="display:none">

                        <div style="position:relative; top:0; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px; top: 0px; width: 128px;">Student Number:</label>
						    <label style="position:absolute; left:420px">Name:</label>
						    <label style="position:absolute; left:620px">Surname:</label>
						    <label style="position:absolute; left:820px; top: 0px; width: 162px;">Email Address:</label><br />

						    <asp:TextBox runat="server" ID="txtStudentNumber" style="position:absolute; left:220px"/>
						    <asp:TextBox runat="server" ID="TextBox3" style="position:absolute; left:420px"/>
						    <asp:TextBox runat="server" ID="txtSurname"  style="position:absolute; left:620px"/>
						    <asp:TextBox runat="server" ID="TextBox4"  style="position:absolute; left:820px; top: 23px; width: 162px;"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgStudent" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
                
                    <div id="reportInspection" style="display:none">

                    </div>
                
                    <div id="reportTutorRequest" style="display:none">
                        
                        <div style ="position:relative ; top:0 ; height: 50% ; width:100%;">
						    <label style="position:absolute; left:220px; width:auto">RequestCode:</label>
						    <label style="position:absolute; left:400px">Description:</label>
						    <label style="position:absolute; left:550px; width:126px; top: 0px;">Date:</label>
						    <label style="position:absolute; left:695px; top: 0px; width: 124px;">ModuleDescriptions:</label>
						    <label style="position:absolute; left:890px; top: 0px; width: 127px;">VenueDescription:</label>
                            <label style="position:absolute; left:1050px; top: 0px; width: 130px;">Status:</label><br />

                            <asp:DropDownList runat="server" ID="cmbRequestCode"  style="position:absolute; left:220px; width: 110px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbRequestDescription"  style="position:absolute; left:400px; width: 110px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="DropDownList2"  style="position:absolute; left:550px; width: 110px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbModuleCode"  style="position:absolute; left:695px; width: 130px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbVenueCode"  style="position:absolute; left:890px; width: 124px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="DropDownList3"  style="position:absolute; left:1050px; width: 110px; height: 22px"/>
                        </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:50px; left: 220px; background-color: darkgrey; height: 50%">
						    <asp:DataGrid runat="server" ID="dgTutorRequest" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" >
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
                
                    <div id="reportRequest" style="display:none">
                        
					    <div style="position:relative; top:0; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px">Description:</label>
						    <label style="position:absolute; left:520px">Staff:</label>
						    <label style="position:absolute; left:820px">Student:</label>
						    <label style="position:absolute; left:1120px; width:192px">Task Type:</label>
                            <label style="position:absolute; left:1120px; top: 72px;">Date:</label>
                            <label style="position:absolute; left:220px; top: 72px;">Time:</label>
                            <label style="position:absolute; left:520px; width:192px; top: 72px;">Assigned Staff:</label>
                            <label style="position:absolute; left:820px; top: 72px;">Status:</label><br />
                        
						    <asp:TextBox runat="server" ID="TextBox2" style="position:absolute; width:192px; left:220px"/>
						    <asp:DropDownList runat="server" ID="cmbStaff" style="position:absolute; width:192px; left:520px"/>
						    <asp:DropDownList runat="server" ID="cmbStudentCode"  style="position:absolute; width:192px; left:820px"/>
						    <asp:DropDownList runat="server" ID="cmbTaskTypeCode"  style="position:absolute; width:192px; left:1120px"/>
                            <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:1120px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbTime" style="position:absolute; left:220px; width:192px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbAssignedStaffCode"  style="position:absolute; width:192px; left:520px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbStatus"  style="position:absolute; left:820px; width:192px; top: 96px;"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:300px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgRequest" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgRequest_Load1" OnSelectedIndexChanged="dgRequest_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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
                
                    <div id="reportEquipment"  style="display:none">

                        <div style="position:relative; top:0; height: 50%; width:100%;">
                            <label style="position:absolute; left:220px; top: 0px; width: 128px;">Description:</label>
                            <label style="position:absolute; left:420px; top: 0px; width: 128px;">Venue:</label>
                            <label style="position:absolute; left:620px; top: 0px; width: 128px;">Equipment Type:</label>
                          
						    <asp:TextBox runat="server" ID="TextBox1" style="position:absolute; left:220px; top: 24px; width: 128px;"/>
                            <asp:DropDownList runat="server" ID="cmbVenue" style="position:absolute; left:420px; top: 24px; width: 128px;"/>
                            <asp:DropDownList runat="server" ID="cmbEquipType" style="position:absolute; left:620px; top: 24px; width: 128px;"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgEquipment" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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

                <%--end of right side--%>

        </div>
                </div>

		
</asp:Content>