<?php
if(array_key_exists('menu', $_GET)){
	$menu = $_GET['menu'];
}
else{
	$menu = "Home";
}
require("login.php");
require("header.php");
declareHeader($menu);
require("content.php");
declareContent($menu);
require("footer.php");
?>