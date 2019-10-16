<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Venue.aspx.cs" Inherits="Info_IT.Pages.Venue" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Venue | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<h2 style="width: 1px; height: 7px">Venue.aspx</h2>
     
        <div class="contentWrapperReport">
			<div>
				<!-- Filling in blank space -->
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="location.href='Default.aspx;" style="background-color: black; height: 52px; padding-top: 1px">
						<%--<ul class="sidebarReport">
							<li><a href="Default.aspx">Manage</a></li>
						</ul>--%>
						<p class="manage" style="padding-top:10px">Manage</p>
	  </div>
				</div>
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">

               <div style="position:relative; top:-142px; height: 50%; width:100%; background-color: blue; left: 3px;">
                    <label style="position:absolute; left:341px; top: -33px;">Description:</label>
                    <label style="position:absolute; left:558px; top: -38px;">Capacity:</label>
                    <label style="position:absolute; left:751px; top: -60px; width: 109px;">Door Number:</label>
                    <label style="position:absolute; left:952px; top: -68px; height: 53px;">Building Block:</label>
                    <label style="position:absolute; left:1078px; top: -39px; width: 106px;">Building:</label>

       
                     <asp:TextBox runat="server" ID="txtDescription" Width="161px" style="position:absolute; left:338px; top: 4px;" /> 
                     <asp:TextBox runat="server" ID="txtCapacity" style="position:absolute; left:550px"/>
                     <asp:TextBox runat="server" ID="txtDoorNumber" style="position:absolute; left:750px"/> 
                     <asp:DropDownList ID="cmbBuildingBlocks" runat="server"  style="position:absolute; left:949px; width: 110px; height: 19px; top: 0px;"/>
                     <asp:DropDownList ID ="cmbBuilding" runat ="server" style="position:absolute; left:1083px; width: 110px; height: 14px; top: -2px;"/>
               </div>
                    <div style="position:relative; top:50%; height: 50%; background-color: darkgrey">
			   </div>
                </div>
                </div>
        </div>


						<asp:DataGrid runat="server" ID="dgVenue" style="width:50%; height:50%; vertical-align:middle;"/>
			   

</asp:Content>