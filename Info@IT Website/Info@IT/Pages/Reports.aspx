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
	            <div style="position:absolute; min-height: 100%; width: 200px; left: 0px; top:0; padding-bottom: 2px; background-color: grey" >
				    <div style="height: 100%;" class="sidebarReport">
					
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

                    <div id="reportStaff" style="display:none;">220 400 580 760 940 1100
						<div style="position:relative; top:10px; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px; width:150px;">Staff Number:</label>
							<label style="position:absolute; left:400px; width:150px;">First Name:</label>
							<label style="position:absolute; left:580px; width:150px;">Last Name:</label>
							<label style="position:absolute; left:760px; width:150px;">Email Address:</label>
							<label style="position:absolute; left:940px; width:150px;">Contact Number:</label><br />

							<asp:TextBox runat="server" ID="txtStaffNo" style="position:absolute; left:220px; width:150px;"/>
							<asp:TextBox runat="server" ID="txtFirstName"  style="position:absolute; left:400px; width:150px;"/>
							<asp:TextBox runat="server" ID="txtLastName"  style="position:absolute; left:580px; width:150px;"/>
							<asp:TextBox runat="server" ID="txtEmail"  style="position:absolute; left:760px; width:150px;" />
							<asp:TextBox runat="server" ID="txtContactNumber"  style="position:absolute; left:940px; width:150px;"/><br />
                        
							<label style="position:absolute; left:220px; width:150px;">Staff Type:</label>
							<label style="position:absolute; left:400px; width:150px;">Department Code:</label>
							<label style="position:absolute; left:580px; width:150px;">Username:</label>
							<label style="position:absolute; left:760px; width:150px;">Password:</label>
							<label style="position:absolute; left:940px; width:150px;">Active Status:</label><br />
                        
							<asp:DropDownList runat="server" ID="cmbStaffType" style="position:absolute; left:220px; width:150px; height:21px"/>
							<asp:DropDownList  runat="server" ID="cmbDepartmentCode" style="position:absolute; left:420px; width:150px; height:21px"/>
							<asp:TextBox runat="server" ID="txtUsername" style="position:absolute; left:620px; width:150px;"/>
							<asp:TextBox runat="server" ID="txtPassword" style="position:absolute; left:820px; width:150px;"/>
							<asp:DropDownList runat="server" ID="cmbActiveStatus" style="position:absolute; left:1020px; width:150px; height:21px"/>
                        </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:60px; left: 220px; background-color: darkgrey; height: 50%">
						    <asp:DataGrid runat="server" ID="dgStaff" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" >
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

                    <div id="reportStudent" style="display:none">

                        <div style="position:relative; top:10px; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px; top: 0px; width: 128px;">Student Number:</label>
						    <label style="position:absolute; left:400px">Name:</label>
						    <label style="position:absolute; left:580px">Surname:</label>
						    <label style="position:absolute; left:760px; top: 0px; width: 162px;">Email Address:</label>
                            
                            <br />

						    <asp:TextBox runat="server" ID="txtStudentNumber" style="position:absolute; left:220px; width: 150px"/>
						    <asp:TextBox runat="server" ID="TextBox3" style="position:absolute; left:400px; width: 150px"/>
						    <asp:TextBox runat="server" ID="txtSurname"  style="position:absolute; left:580px; width: 150px"/>
						    <asp:TextBox runat="server" ID="TextBox4"  style="position:absolute; left:760px; top: 23px; width: 150px;"/>
                            <br />
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:45px; left: 220px; height: 50%; background-color: darkgrey">
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
                        
                        <div style ="position:relative ; top:10px ; height: 50% ; width:100%;">
						    <label style="position:absolute; left:220px; width:150px">RequestCode:</label>
						    <label style="position:absolute; left:400px">Description:</label>
						    <label style="position:absolute; left:580px; width:150px; top: 0px;">Date:</label>
						    <label style="position:absolute; left:760px; top: 0px; width: 150px;">ModuleDescriptions:</label>
						    <label style="position:absolute; left:940px; top: 0px; width: 150px;">VenueDescription:</label>
                            <label style="position:absolute; left:1100px; top: 0px; width: 150px;">Status:</label><br />
							
                            <asp:DropDownList runat="server" ID="cmbRequestCode"  style="position:absolute; left:220px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbRequestDescription"  style="position:absolute; left:400px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="DropDownList2"  style="position:absolute; left:580px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbModuleCode"  style="position:absolute; left:760px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbVenueCode"  style="position:absolute; left:940px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="DropDownList3"  style="position:absolute; left:1100px; width: 150px; height: 22px"/>
                        </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:60px; left: 220px; background-color: darkgrey; height: 50%">
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
                        
					    <div style="position:relative; top:10px; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px">Description:</label>
						    <label style="position:absolute; left:400px">Staff:</label>
						    <label style="position:absolute; left:580px">Student:</label>
						    <label style="position:absolute; left:760px; width:192px">Task Type:</label>
                            <label style="position:absolute; left:940px;">Date:</label>
                            <label style="position:absolute; left:220px; top: 72px;">Time:</label>
                            <label style="position:absolute; left:400px; top: 72px;">Assigned Staff:</label>
                            <label style="position:absolute; left:580px; top: 72px;">Status:</label><br />
                        
						    <asp:TextBox runat="server" ID="TextBox2" style="position:absolute; width:150px; left:220px"/>
						    <asp:DropDownList runat="server" ID="cmbStaff" style="position:absolute; width:150px; left:400px"/>
						    <asp:DropDownList runat="server" ID="cmbStudentCode"  style="position:absolute; width:150px; left:580px"/>
						    <asp:DropDownList runat="server" ID="cmbTaskTypeCode"  style="position:absolute; width:150px; left:760px"/>
                            <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:940px;"/>
						    <asp:DropDownList runat="server" ID="cmbTime" style="position:absolute; left:220px; width:150px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbAssignedStaffCode"  style="position:absolute; width:150px; left:400px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbStatus"  style="position:absolute; left:580px; width:150px; top: 96px;"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:120px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgRequest" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="8" Font-Size="Medium">
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

                        <div style="position:relative; top:10px; height: 50%; width:100%;">
                            <label style="position:absolute; left:220px; top: 0px; width: 150px;">Description:</label>
                            <label style="position:absolute; left:400px; top: 0px; width: 150px;">Venue:</label>
                            <label style="position:absolute; left:580px; top: 0px; width: 150px;">Equipment Type:</label>
                          
						    <asp:TextBox runat="server" ID="TextBox1" style="position:absolute; left:220px; top: 24px; width: 150px;"/>
                            <asp:DropDownList runat="server" ID="cmbVenue" style="position:absolute; left:400px; top: 24px; width: 150px;"/>
                            <asp:DropDownList runat="server" ID="cmbEquipType" style="position:absolute; left:580px; top: 24px; width: 150px;"/>
					    </div>
						<br />
					    <!-- DataGrid -->
					    <div style="position:relative; top:60px; left: 220px; height: 50%; background-color: darkgrey">
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

                        <div style="position:relative; float:right; top:10px; height: 50%; width:100%;">
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
                        <br />
					    <!-- DataGrid -->
					    <div style="position:relative; top:60px; left: 220px; height: 50%; background-color: darkgrey">
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
						
					    <div style="position:relative; top:10px; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px; width:auto">Name:</label>
						    <label style="position:absolute; left:400px">Building:</label>
						    <label style="position:absolute; left:580px; width:150px; top: 0px;">Contact Person:</label>
						    <label style="position:absolute; left:760px; top: 0px; width: 150px;">Contact Number:</label>
						    <label style="position:absolute; left:940px; top: 0px; width: 150px;">Email Address:</label><br />
							
						    <asp:TextBox runat="server" ID="txtName" style="position:absolute; left:220px; width: 150px"/>
						    <asp:DropDownList runat="server" ID="DropDownList1"  style="position:absolute; left:400px; width: 150px; height: 22px"/>
						    <asp:TextBox runat="server" ID="txtContactPerson"  style="position:absolute; left:580px; width: 150px"/>
						    <asp:TextBox runat="server" ID="txtContactNo" style="position:absolute; left:760px; width: 150px"/>
						    <asp:TextBox runat="server" ID="txtEmailAddress"  style="position:absolute; left:940px; width: 150px"/>
					    </div>
						<br />
					    <!-- DataGrid -->
					    <div style="position:relative; top:40px; left: 220px; height: 50%; background-color: darkgrey">
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