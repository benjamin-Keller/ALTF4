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

                        <div onclick="reportInspectionDetails()" class="manage_Style">
                            Inspection Details
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
						<div style="position:relative; top:0px; height: 50%; width:100%;">
							<label style="position:absolute; left:220px; width:150px;">Staff Type:</label>
							<label style="position:absolute; left:400px; width:150px;">Department Code:</label>
							<label style="position:absolute; left:580px; width:150px;">Active Status:</label><br />
                        
							<asp:DropDownList runat="server" ID="cmbStaffTypeStaff" style="position:absolute; left:220px; width:150px; height:21px"/>
							<asp:DropDownList  runat="server" ID="cmbDepartmentCodeStaff" style="position:absolute; left:400px; width:150px; height:21px"/>
							<asp:DropDownList runat="server" ID="cmbActiveStatusStaff" style="position:absolute; left:580px; width:150px; height:21px"/>
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

                        <div style="position:relative; top:0; height: 50%; width:100%;">
						    <label style="position:absolute; left:220px;width:100px" >Venue:</label>
						    <label style="position:absolute; left:400px;width:150px">Staff Code:</label>
                            <label style="position:absolute; left:580px;width:150px">Inspection Date:</label><br />

						    <asp:DropDownList runat="server" ID="cmbVenueInspection" style="position:absolute;left:220px;width:110px;height:22px"/>
						    <asp:DropDownList runat="server" ID="cmbStaffCodeInspection"  style="position:absolute;left:400px; width: 110px; height: 22px;"/>
                            <asp:Calendar runat="server" ID="calInspectDate" selectionmode="DayWeekMonth" style="position:absolute; left:580px;"/>
					    </div>
					
					    <!-- DataGrid -->
					    <div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						    <asp:DataGrid runat="server" ID="dgInspection" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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

                    <div id="reportInspectionDetails" style="display:none">

                        <div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; width:192px">Inspection Code:</label>
						<label style="position:absolute; left:400px; width:192px">Equipment Code:</label>
						<label style="position:absolute; left:580px; width:192px">Staff Member:</label>
                        <label style="position:absolute; left:760px; width:192px">Status:</label>
                        
						<asp:DropDownList runat="server" ID="cmbInspectionCodeInspectionDetails" style="position:absolute; width:128px; height: 21px; left:220px; top: 24px"/>
						<asp:DropDownList runat="server" ID="cmbEquipmentInspectionDetails" style="position:absolute; width:128px; height: 21px; left:400px; top: 24px"/>
						<asp:DropDownList runat="server" ID="cmbStaffMemberInspectionDetails"  style="position:absolute; width:128px; height: 21px; left:580px; top: 24px"/>
                        <asp:DropDownList runat="server" ID="cmbStatusInspectionDetails" style="position:absolute; width:128px; height: 21px; left:760px; top: 24px"/>
					</div>

					<!-- DataGrid -->
					<div style="position:relative; top:75px; left: 220px; height: 50%; background-color: darkgrey">
                        <asp:DataGrid runat="server" ID="dgInspectionDetails" style="width:100%; height:50%; vertical-align:middle;" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
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

                    </div>
                
                    <div id="reportTutorRequest" style="display:none">
                        
                        <div style ="position:relative ; top:10px ; height: 50% ; width:100%;">
						    <label style="position:absolute; left:220px; width:150px; top: 0px;">Date:</label>
						    <label style="position:absolute; left:480px; top: 0px; width: 150px;">Module Descriptions:</label>
						    <label style="position:absolute; left:660px; top: 0px; width: 150px;">Venue Description:</label>
                            <label style="position:absolute; left:840px; top: 0px; width: 150px;">Status:</label>
                            
                            <br />
							
                            <asp:Calendar runat="server" ID="dateTutorRequest" selectionmode="DayWeekMonth" style="position:absolute; left:220px;"/>
                            <asp:DropDownList runat="server" ID="cmbModuleCodeTutorRequest"  style="position:absolute; left:480px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbVenueCodeTutorRequest"  style="position:absolute; left:660px; width: 150px; height: 22px"/>
                            <asp:DropDownList runat="server" ID="cmbStatusTutorRequest"  style="position:absolute; left:840px; width: 150px; height: 22px"/>
                        </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:240px; left: 220px; background-color: darkgrey; height: 50%">
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
						    <label style="position:absolute; left:220px">Staff:</label>
						    <label style="position:absolute; left:400px">Student:</label>
						    <label style="position:absolute; left:580px; width:192px">Task Type:</label>
                            <label style="position:absolute; left:750px;">Date:</label>
                            <label style="position:absolute; left:220px; top: 72px;">Time:</label>
                            <label style="position:absolute; left:400px; top: 72px;">Assigned Staff:</label>
                            <label style="position:absolute; left:580px; top: 72px;">Status:</label>
                            
                            <br />
                        
						    <asp:DropDownList runat="server" ID="cmbStaffRequest" style="position:absolute; width:150px; left:220px"/>
						    <asp:DropDownList runat="server" ID="cmbStudentCodeRequest"  style="position:absolute; width:150px; left:400px"/>
						    <asp:DropDownList runat="server" ID="cmbTaskTypeCodeRequest"  style="position:absolute; width:150px; left:580px"/>
                            <asp:Calendar runat="server" ID="dateRequest" style="position:absolute; left:750px;"/>
						    <asp:DropDownList runat="server" ID="cmbTimeRequest" style="position:absolute; left:220px; width:150px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbAssignedStaffCodeRequest"  style="position:absolute; width:150px; left:400px; top: 96px;"/>
						    <asp:DropDownList runat="server" ID="cmbStatusRequest"  style="position:absolute; left:580px; width:150px; top: 96px;"/>
					    </div>

					    <!-- DataGrid -->
					    <div style="position:relative; top:220px; left: 220px; height: 50%; background-color: darkgrey">
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
                            <label style="position:absolute; left:220px; top: 0px; width: 150px;">Venue:</label>
                            <label style="position:absolute; left:400px; top: 0px; width: 150px;">Equipment Type:</label>
                          
                            <asp:DropDownList runat="server" ID="cmbVenueEquipment" style="position:absolute; left:220px; top: 24px; width: 150px;"/>
                            <asp:DropDownList runat="server" ID="cmbEquipTypeEquipment" style="position:absolute; left:400px; top: 24px; width: 150px;"/>
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
                            <label style = "position:absolute; left :220px; top: 0px;">BuildingBlocks</label>
                            <label style = "position:absolute; left :400px; top: 0px;">Building</label>
       
                            <asp:DropDownList ID="cmbBuildingBlocksVenue" runat="server" OnSelectedIndexChanged="cmbBuildingBlocksVenue_SelectedIndexChanged" AutoPostBack="true" style="position:absolute; left:220px; width: 110px; height: 25px; top: 20px;"/>
                            <asp:DropDownList ID ="cmbBuildingVenue" runat ="server" style="position:absolute; left:400px; width: 113px; height: 25px; top: 20px;"/>
                            
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
						<asp:ScriptManager runat="server" EnablePartialRendering="true"></asp:ScriptManager>
                        <asp:UpdatePanel runat="server" ID="department">
                            <ContentTemplate>
					            <div style="position:relative; top:10px; height: 50%; width:100%;">
						            <label style="position:absolute; left:220px">Building:</label>
                            
                                    <br />
							
						            <asp:DropDownList runat="server" ID="cmbBuildingDepartment" OnSelectedIndexChanged="cmbBuildingDepartment_SelectedIndexChanged" style="position:absolute; left:220px; width: 150px; height: 22px" AutoPostBack="True" />
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
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </div>

                <%--end of right side--%>

        </div>

		
</asp:Content>