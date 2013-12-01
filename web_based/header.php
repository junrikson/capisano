<?php
function declareHeader($arg){
	$arg;
	echo '<!DOCTYPE html>
	<html lang="en">
	<head>
	<title>Capisano - '.$arg.'</title>
	<meta charset="utf-8">
	<link rel="icon" href="./images/favicon.ico" type="image/x-icon" />
    <link rel="stylesheet" href="css/reset.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/layout.css" type="text/css" media="screen">
	<script src="js/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script src="js/cufon-yui.js" type="text/javascript"></script>
    <script src="js/cufon-replace.js" type="text/javascript"></script> 
    <script src="js/Dynalight_400.font.js" type="text/javascript"></script>
    <script src="js/FF-cash.js" type="text/javascript"></script>  
	';
if($arg == "Home"){
	echo '<script src="js/tms-0.3.js" type="text/javascript"></script>
    <script src="js/tms_presets.js" type="text/javascript"></script>
    <script src="js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="js/jquery.equalheights.js" type="text/javascript"></script> ';
}
elseif($arg == "Menu"){
	echo '<script src="js/jquery.equalheights.js" type="text/javascript"></script>    
    <script src="js/slider.js" type="text/javascript"></script>    
    <script src="js/jquery.bxSlider.js" type="text/javascript"></script>';
}
elseif($arg == "Catalogue"){
	echo '<script src="js/jquery.prettyPhoto.js" type="text/javascript"></script> 
    <script src="js/hover-image.js" type="text/javascript"></script>
    <script src="js/jquery.easing.1.3.js" type="text/javascript"></script>  
    <script src="js/slider2.js" type="text/javascript"></script>    
    <script src="js/jquery.bxSlider.js" type="text/javascript"></script> ';
}	     
	echo '<!--[if lt IE 8]>
    <div style="clear: both; text-align:center; position: relative;">
        <a href="http://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
        	<img src="http://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." />
        </a>
    </div>
	<![endif]-->
    <!--[if lt IE 9]>
   		<script type="text/javascript" src="js/html5.js"></script>
	<![endif]-->
</head>';

if($arg == "Home"){
	echo '<body id="page1">';
}
elseif($arg == "Menu"){
	echo '<body id="page2">';
}
elseif($arg == "Catalogue"){
	echo '<body id="page3">';
}
elseif($arg == "Shipping"){
	echo '<body id="page4">';
}
elseif($arg == "FAQ"){
	echo '<body id="page5">';
}
elseif($arg == "Contact"){
	echo '<body id="page6">';
}
echo '<!--==============================header=================================-->
    <header>
    	<div class="row-top">
        	<div class="main">
            	<div class="wrapper">
                	<h1><a href="index.html">Capisano - <span>( Catering Pilih Pesan Online dengan SMS Gateway )</span></a></h1>
                    <nav>
                    <div id = "cssmenu">
                        <ul>';
						
if($arg == "Home"){
	echo '<li class="active"><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ</a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
elseif($arg == "Menu"){
	echo '<li><a href="index.php">Home</a></li>
	<li class="active"><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ </a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
elseif($arg == "Catalogue"){
	echo '<li><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li class="active"><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ </a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
elseif($arg == "Shipping"){
	echo '<li><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li class="active"><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ </a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
elseif($arg == "FAQ"){
	echo '<li><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li class="active"><a href="index.php?menu=FAQ">FAQ </a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
elseif($arg == "Contact"){
	echo '<li><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ </a></li>
	<li class="active"><a href="index.php?menu=Contact">Contact</a></li>';
}
else{
	echo '<li><a href="index.php">Home</a></li>
	<li><a href="index.php?menu=Menu">Menu</a></li>
	<li><a href="index.php?menu=Catalogue">Catalogue</a></li>
	<li><a href="index.php?menu=Shipping">Shipping</a></li>
	<li><a href="index.php?menu=FAQ">FAQ </a></li>
	<li><a href="index.php?menu=Contact">Contact</a></li>';
}
if(!cek()){
							echo '<li class="has-sub last"><a href="#"><span>Account</span></a>
      							<ul>
         						<li><a href="index.php?menu=Login"><span>Login</span></a></li>
         						<li><a href="index.php?menu=Register"><span>Daftar</span></a></li><hr/>
         						<li class="last"><a href="index.php?menu=Forgot"><span>Lupa Password?</span></a></li>';
}
else{
							echo '<li class="has-sub last"><a href="#"><span>'.$_SESSION['username'].'</span></a>
      							<ul>
								<li><a href="index.php?payment=1"><span>Payments List</span></a></li>
								<li><a href="index.php?order=1"><span>Orders List</span></a></li><hr/>
         						<li class="last"><a href="login.php?action=logout"><span>Logout</span></a></li>';	
}
 echo '     							</ul>
   							</li>
                        </ul><br>	
                        </div>				
                    </nav>
                </div>
            </div>
        </div>
        <div class="row-bot">
        	<div class="row-bot-bg">
            	<div class="main">
                	<h2>Capisano ~ <span>Pilihan Tepat Untuk Selera Anda</span></h2>';
					
if($arg == "Home"){
	echo '<div class="slider-wrapper">
                        <div class="slider">
                            <ul class="items">
                                <li>
                                    <img src="images/slider-img1.jpg" alt="" />
                                </li>
                                <li>
                                    <img src="images/slider-img2.jpg" alt="" />
                                </li>
                                <li>
                                    <img src="images/slider-img3.jpg" alt="" />
                                </li>
                            </ul>
                        </div>
                    </div>';
}

          echo '</div>
            </div>
        </div>
    </header>';
}
?>
  
    