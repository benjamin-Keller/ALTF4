<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Info_IT.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Master.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div id="content-scroll-wrap">
			<div id="content-scroll" style="table-layout: auto; border-spacing: 50px;">
				<table class="content">
					<tr>
						<td colspan="2" class="contentHeader">
					
							<div id="Logo">
								<a href="Default.aspx"><img src="../Images/@.png" class="At" /></a>
							</div>
							<div class="centerText">
								<h1 class="title">
									Info@IT HelpDesk Web-System
									
								</h1>
							</div>
						</td>
					</tr>
					<tr>
						<td class="menu" style="background-color: white">
                            <div style="font-size:xx-large; position:relative; top:100px; left:150px">
                                <asp:Label Font-Size="XX-Large" Font-Bold="true" runat="server" Text="Login:" /><br />
                                <asp:Label runat="server" Text="Username:" />
                                <asp:TextBox Font-Size="X-Large" runat ="server" ID="txtUsername" /> <br />
                                <asp:Label runat="server" Text="Password:" />
                                <asp:TextBox Font-Size="X-Large" TextMode="Password" runat ="server" ID="txtPassword" /> <br />
                                <asp:Button Font-Size="X-Large" runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" /><br />
                                <asp:Label ForeColor="Red" runat="server" ID="lblError" Text ="Incorrect Username and Password." Visible="false" />
                            </div>
						</td>
						<%--<td class="contentMain">
							
							<div class="contentWrapper" style="height: 100%;">
								<div>
									
									<!-- Here is where your code goes FROM the other pages !-->
									<!--asp:ContentPlaceHolder runat="server" ID="BodyContent"></!--asp:ContentPlaceHolder> !-->
								</div>
							</div>
						</td>--%>
					</tr>
					<tr>
						<td colspan="2" class="contentFooter">
							<b>
								Made by ALTF4
							</b>
						</td>
					</tr>
				</table>
			</div>
		</div>
    </form>
</body>
</html>
