<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>


<!DOCTYPE HTML>
<html>

<head>
<title>Wikisys Technology CRM - Login</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Glance Design Dashboard Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>

<!-- Bootstrap Core CSS -->
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />

<!-- Custom CSS -->
<link href="css/style.css" rel='stylesheet' type='text/css' />

<!-- font-awesome icons CSS-->
<link href="css/font-awesome.css" rel="stylesheet"> 
<!-- //font-awesome icons CSS-->

 <!-- side nav css file -->
 <link href='css/SidebarNav.min.css' media='all' rel='stylesheet' type='text/css'/>
 <!-- side nav css file -->
 
 <!-- js-->
<script src="js/jquery-1.11.1.min.js"></script>
<script src="js/modernizr.custom.js"></script>

<!--webfonts-->
<link href="http://fonts.googleapis.com/css?family=PT+Sans:400,400i,700,700i&amp;subset=cyrillic,cyrillic-ext,latin-ext" rel="stylesheet">
<!--//webfonts-->
 
<!-- Metis Menu -->
<script src="js/metisMenu.min.js"></script>
<script src="js/custom.js"></script>
<link href="css/custom.css" rel="stylesheet">
<!--//Metis Menu -->

</head> 

<body>
    	
    <form runat="server" id="form1">

		<div id="page-wrapper">
			<div class="main-page login-page" style="width:25%;">
				<h2 class="title1" style="background-color:#76B947; border:none;">WBM - Login </h2>
				<div class="widget-shadow">
					<div class="login-body">
                            <asp:TextBox runat="server" TextMode="Email" ID="txtemail" placeholder="Enter your email" />
                            <asp:TextBox runat="server" TextMode="Password" ID="txtpassword" placeholder="Enter your password" />
							<div class="forgot-grid">
								<div class="forgot">
									<a href="#">forgot password?</a>
								</div>
								<div class="clearfix"> </div>
							</div>
                            <hr />
                        <asp:Button Text="Login"  runat="server" ID="btn_login" OnClick="btn_login_Click" />
							<div class="registration">
								Don't have an account ?
								<a class="" href="signup.html">
									Create an account
								</a>
							</div>
					</div>
				</div>
				
			</div>
		</div>



		<!--footer-->
		<div class="footer">
		   <p>&copy; Wikisys Technology Pvt Ltd. All Rights Reserved | Design by <a href="https://wikisystech.com/" target="_blank">Wikisys Technology</a></p>		</div>
        <!--//footer-->
	</div>
							</form>

	
	<!--scrolling js-->
	<script src="js/jquery.nicescroll.js"></script>
	<script src="js/scripts.js"></script>
	<!--//scrolling js-->
	
	<!-- Bootstrap Core JavaScript -->
   <script src="js/bootstrap.js"> </script>
	<!-- //Bootstrap Core JavaScript -->
   
</body>

</html>