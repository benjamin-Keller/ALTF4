<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Info_IT.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | Info@IT HelpDesk Web-System</title>
    <link href="css/Master.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       <div id="content-scroll-wrap">
			<div id="content-scroll" style="table-layout: auto;">
				<table class="content">
					<tr>
						<td colspan="1" class="contentHeader">
					
							<div id="Logo">
								<img src="../Images/@.png" class="At" />
							</div>
							<div class="centerText">
								<h1 style="font-family: 'Segoe UI'; color: white; font-size: 60px;">Info@IT HelpDesk Web-System</h1>
							</div>
						</td>
					</tr>
					<tr>
						<td class="menu" style="background-color: white">
                            <div style="font-size:xx-large; position:relative; top:100px; left:calc((100vw/2 - 200px)">
								<div class="modal" tabindex="-1" role="dialog">
								  <div class="modal-dialog" role="document">
									<div class="modal-content">
									  <div class="modal-body">
										<p>Modal body text goes here.</p>
									  </div>
									  
									</div>
								  </div>
								</div>

								<div class="panel panel-default " style="width:400px;">
								  <div class="panel-heading"><asp:Label Font-Size="XX-Large" Font-Bold="true" runat="server" Text="Login:" /></div>
								  <div class="panel-body"><div class="input-group">
								  <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
								  <asp:TextBox runat="server" id="txtUsername" type="text" class="form-control" name="username" placeholder="Username" Width="300px" AutoCompleteType="none" />
								</div>
								<div class="input-group">
								  <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
								  <asp:TextBox runat="server" id="txtPassword" type="text" class="form-control" name="password" placeholder="Password" Width="300px" AutoCompleteType="none" />
								</div>
                                <asp:Button Font-Size="Large" runat="server" ID="btnSubmit" Text="Login" OnClick="btnSubmit_Click" CssClass="btn btn-primary" /><br />
                                <asp:Label ForeColor="Red" runat="server" ID="lblError" Text ="Incorrect Username and Password." Visible="false" Font-Size="Medium" /></div>
								</div>

								 <div class="form-group">

									<br />
									
                                </div>
								
							
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
						<td colspan="1" class="contentFooter">
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
