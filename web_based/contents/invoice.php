<?php		
if(array_key_exists('id', $_GET)){
	$id = $_GET['id'];
}
else{
	$id = "0";
}

require("../config.php");
dbConnect();
$result = mysql_query("SELECT auto, orderid, name, price, qty, total, bankname, sender, comments, status, timestamp, username FROM daftarpayment where auto='$id'") or error( mysql_error() );
if (mysql_num_rows($result) > 0){
$row = mysql_fetch_row($result);

if($row[9] == "Y"){
	$status = "PAID";
}
elseif($row[9] == "P"){
	$status = "PAID";
}
else{
	$status = "PENDING";
}

echo '<!DOCTYPE html>
<html lang="en">
  <head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>Capisano - Invoice #'.$id.'</title>

    <link href="invoice.css" rel="stylesheet">

  </head>

  <body>

<div class="wrapper">


<table class="header"><tr><td width="50%" nowrap>

<h1>Capisano</h1>
</td><td width="50%" align="center">

<font class="paid">'.$status.'</font><br />
Bank Transfer<br />
('.$row[10].')

</td></tr></table>



<table class="items"><tr><td width="50%">

<div class="addressbox">

<strong>Invoiced To</strong><br />
'.$row[11].'
</div>

</td><td width="50%">

<div class="addressbox">

<strong>Pay To</strong><br />
'.$row[6].'</div>

</td></tr></table>

<div class="row">
<span class="title">Invoice #'.$id.'</span><br />
Invoice Date: '.$row[10].'<br />
Due Date: '.$row[10].'
</div>

<table class="items">
    <tr class="title textcenter">
        <td width="70%">Description</td>
        <td width="30%">Amount</td>
    </tr>
    <tr>
        <td>'.$row[2].'</td>
        <td class="textcenter">Rp '.$row[5].' IDR</td>
    </tr>
    <tr class="title">
        <td class="textright">Sub Total:</td>
        <td class="textcenter">Rp '.$row[5].' IDR</td>
    </tr>
            <tr class="title">
        <td class="textright">Credit:</td>
        <td class="textcenter">Rp0,00IDR</td>
    </tr>
    <tr class="title">
        <td class="textright">Total:</td>
        <td class="textcenter">Rp '.$row[5].' IDR</td>
    </tr>
</table>


<div class="row">
<span class="subtitle">Transactions</span>
</div>

<table class="items">
    <tr class="title textcenter">
        <td width="30%">Transaction Date</td>
        <td width="25%">Gateway</td>
        <td width="25%">Transaction ID</td>
        <td width="20%">Amount</td>
    </tr>
    <tr>
        <td class="textcenter">'.$row[10].'</td>
        <td class="textcenter"> '.$row[6].'</td>
        <td class="textcenter">'.$row[8].'</td>
        <td class="textcenter">Rp'.$row[5].'IDR</td>
    </tr>
    <tr>
        <td class="textcenter">'.$row[10].'</td>
        <td class="textcenter">Bank Transfer</td>
        <td class="textcenter"></td>
        <td class="textcenter">Rp'.$row[5].'IDR</td>
    </tr>
    <tr class="title">
        <td class="textright" colspan="3">Balance:</td>
        <td class="textcenter">Rp0,00IDR</td>
    </tr>
</table>



</div>

<p align="center"><a href="javascript:window.close()">Close Window</a></p>

</body>
</html>';
}
?>