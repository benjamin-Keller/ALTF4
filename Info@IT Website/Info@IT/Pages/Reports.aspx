<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Info_IT.Pages.Reports" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Reports | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	
		<div class="contentWrapperReport">
			<div class="centerPHReport">
				<!-- Filling in blank space -->
	<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey" />
				<div style="height: 100%;">
					<ul class="sidebarReport">
						<li><a href="Default.aspx">Home</a></li>
						<li><a href="Equipment.aspx">Equipment</a></li>
						<li><a href="Venue.aspx">Venue</a></li>
						<li><a href="Department.aspx">Department</a></li>
						<li><a href="Request.aspx">Request</a></li>
						<li><a href="TutorRequest.aspx">Tutor Request</a></li>
						 <li><a href="Inspection.aspx">Inspection</a></li>
						<li><a href="TaskType.aspx">Task Type</a></li>
						<li><a href="Student.aspx">Student</a></li>
						 <li><a href="Staff.aspx">Staff</a></li>
						<li><a href="Reports.aspx">Reports</a></li>
					</ul>
				</div>
			</div>
		</div>
		
</asp:Content>