<?php
session_start();
require("../config.php");
$code = mysql_real_escape_string($_POST['code']);
$name = mysql_real_escape_string($_POST['name']);
$price = $_POST['price'];
$qty = $_POST['qty'];
$total = $price * $qty;
$username = $_SESSION['username'];

dbConnect();
mysql_query( "INSERT INTO daftarorder ( username, code, name, price, qty, total ) Values ( '$username', '$code', '$name', '$price', '$qty', '$total' )" ) or error( mysql_error() );

header( "Location: ../index.php?order=1" );
?>