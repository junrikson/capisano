<?php
if(array_key_exists('menu', $_GET)){
	$menu = $_GET['menu'];
}
else{
	$menu = "Home";
}

require("login.php");

require("header.php");
if(array_key_exists('order', $_GET)){
	declareHeader("order");
}
elseif(array_key_exists('payment', $_GET)){
	declareHeader("payment");
}
else
	declareHeader($menu);
	
require("content.php");
if(array_key_exists('order', $_GET)){
	$order = $_GET['order'];
	require("./contents/order.php");
	item($order);
}
elseif(array_key_exists('payment', $_GET)){
	$payment = $_GET['payment'];
	require("./contents/payment.php");
	payment($payment);
}
else
	declareContent($menu);

require("footer.php");
?>