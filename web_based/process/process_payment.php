<?php
session_start();
require("../config.php");
$orderid = mysql_real_escape_string($_POST['orderid']);
$username = $_SESSION['username'];
$name = mysql_real_escape_string($_POST['name']);
$price = $_POST['price'];
$qty = $_POST['qty'];
$total = $_POST['total'];
$bankname = $_POST['bankname'];
$sender = $_POST['sender'];
$comments = $_POST['comments'];

dbConnect();
mysql_query( "INSERT INTO daftarpayment ( orderid, username, name, price, qty, total, bankname, sender, comments ) Values ( '$orderid', '$username', '$name', '$price', '$qty', '$total', '$bankname', '$sender', '$comments' )" ) or error( mysql_error() );

header( "Location: ../index.php?payment=1" );
?>