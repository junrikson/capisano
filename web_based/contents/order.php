<?php
function item($arg){
	$username = $_SESSION['username'];
	if($arg == '1'){
		echo '<!--==============================content================================-->
    		<section id="content"><div class="ic"></div>
        		<div class="main">
            		<div class="container"><br>';
		dbConnect();
		$result = mysql_query("SELECT auto, code, name, price, qty, total, status FROM daftarorder where username='$username'") or error( mysql_error() );
		echo '<table border="1" align="center">
		<tr><th valign="middle" align="center" height="30px">Order ID</th><th valign="middle" align="center">Item Code</th><th valign="middle" align="center">Item Name</th><th valign="middle" align="center">Price</th><th valign="middle" align="center">Qty</th><th valign="middle" align="center">Total</th><th valign="middle" align="center">Status</th><th valign="middle" align="center">Command</th>
		</tr>';
		if (mysql_num_rows($result) > 0) 
			while($row = mysql_fetch_row($result)){
				echo '<tr>
				<td width="100px" valign="middle" align="center">'.$row[0].'</td>
				<td width="100px" valign="middle" align="center">'.$row[1].'</td>
				<td width="100px" valign="middle" align="center">'.$row[2].'</td>
				<td width="100px" valign="middle" align="center">'.$row[3].'</td>
				<td width="100px" valign="middle" align="center">'.$row[4].'</td>
				<td width="100px" valign="middle" align="center">'.$row[5].'</td>';
				if($row[6] == "Y"){
					echo '<td width="100px" valign="middle" align="center">APPROVED</td>
					<td width="100px" align="center"><form action="./index.php?payment='.$row[0].'" method="post" id="payment"><input type="submit" id="submit" value="Pay"></form></td>';
				}
				elseif($row[6] == "P"){
					echo '<td width="100px" valign="middle" align="center">PAID</td>
					<td width="100px" align="center"><input type="submit" id="submit" value="Paid"></td>';
				}
				else{
					echo '<td width="100px" valign="middle" align="center">PENDING</td>
					<td width="100px" align="center"><input type="submit" id="submit" value="Edit"></td>';
				}
				echo '</tr>';
			}
		echo '</table></div>
        		</div>
    		</section>';
	}
	else{
		dbConnect();
		$result = mysql_query("SELECT code, name, price FROM daftaritem where code='$arg'") or error( mysql_error() );
		if (mysql_num_rows($result) > 0) 
			$row = mysql_fetch_row($result);
		echo '<!--==============================content================================-->
    		<section id="content"><div class="ic"></div>
        		<div class="main">
            		<div class="container"><br>
					<form id="order" action="./process/process_order.php" method="post"><table border="0" align="center">
					<tr>
						<td align="right" width="250"><strong>Item Code :</strong></td>
						<td align="left" width="500">&nbsp;<input id="code" type="text" name="code" value="'.$row[0].'" readOnly="true"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Item Name :</strong></td>
						<td align="left">&nbsp;<input id="name" type="text" name="name" value="'.$row[1].'" readOnly="true"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Images :</strong></td>
						<td align="left">&nbsp;<img src="images/default.jpg" alt="" width="200px" height="200px"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Price :</strong></td>
						<td align="left">&nbsp;<input id="price" type="text" name="price" value="'.$row[2].'" readOnly="true"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Qty :</strong></td>
						<td align="left">&nbsp;<input id="qty" type="text" name="qty" value="1"><br/><br/><br/><br/></td>						
					</tr>
					<tr><td></td><td><input type="submit" id="submit" value="Submit"></td></tr>
					</table></form>
					</div>
        		</div>
    		</section>';
	}
}
?>

				
            
    