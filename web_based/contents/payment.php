<?php
function payment($arg){
	$username = $_SESSION['username'];
	if($arg == '1'){
		echo '<!--==============================content================================-->
    		<section id="content"><div class="ic"></div>
        		<div class="main">
            		<div class="container"><br>';
		dbConnect();
		$result = mysql_query("SELECT auto, orderid, name, price, qty, total, bankname, sender, comments, status FROM daftarpayment where username='$username'") or error( mysql_error() );
		echo '<table border="1" align="center">
		<tr><th valign="middle" align="center" height="30px">Payment ID</th>
		<th valign="middle" align="center">Order ID</th>
		<th valign="middle" align="center">Item Name</th>
		<th valign="middle" align="center">Price</th>
		<th valign="middle" align="center">Qty</th>
		<th valign="middle" align="center">Total</th>
		<th valign="middle" align="center">Bank Name</th>
		<th valign="middle" align="center">Sender</th>
		<th valign="middle" align="center">Comments</th>
		<th valign="middle" align="center">Status</th>
		</tr>';
		if (mysql_num_rows($result) > 0) {
			while($row = mysql_fetch_row($result)){
				echo '<tr>
				<td width="100px" valign="middle" align="center">'.$row[0].'</td>
				<td width="100px" valign="middle" align="center">'.$row[1].'</td>
				<td width="100px" valign="middle" align="center">'.$row[2].'</td>
				<td width="100px" valign="middle" align="center">'.$row[3].'</td>
				<td width="100px" valign="middle" align="center">'.$row[4].'</td>
				<td width="100px" valign="middle" align="center">'.$row[5].'</td>
				<td width="100px" valign="middle" align="center">'.$row[6].'</td>
				<td width="100px" valign="middle" align="center">'.$row[7].'</td>
				<td width="100px" valign="middle" align="center">'.$row[8].'</td>';
				if($row[9] == "Y"){
					echo '<td width="100px" align="center"><input type="submit" id="submit" value="Paid"></td>';
				}
				elseif($row[9] == "P"){
					echo '<td width="100px" align="center"><input type="submit" id="submit" value="Paid"></td>';
				}
				else{
					echo '<td width="100px" align="center"><input type="submit" id="submit" value="Pending"></td>';
				}
				echo '</tr>';
			}
		}
		echo '</table></div>
        		</div>
    		</section>';
	}
	else{
		dbConnect();
		$result = mysql_query("SELECT auto, name, price, qty, total FROM daftarorder where auto='$arg'") or error( mysql_error() );
		if (mysql_num_rows($result) > 0) 
			$row = mysql_fetch_row($result);
		echo '<!--==============================content================================-->
    		<section id="content"><div class="ic"></div>
        		<div class="main">
            		<div class="container"><br>
					<form id="order" action="./process/process_payment.php" method="post"><table border="0" align="center">
					<tr>
						<td align="right" width="250"><strong>Order ID :</strong></td>
						<td align="left" width="500">&nbsp;<input id="orderid" type="text" name="orderid" value="'.$row[0].'" readOnly="true"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Item Name :</strong></td>
						<td align="left">&nbsp;<input id="name" type="text" name="name" value="'.$row[1].'" readOnly="true"><br/><br/></td>
					</tr>					
					<tr>
						<td align="right"><strong>Price :</strong></td>
						<td align="left">&nbsp;<input id="price" type="text" name="price" value="'.$row[2].'" readOnly="true"><br/><br/></td>
					</tr>
					<tr>
						<td align="right"><strong>Qty :</strong></td>
						<td align="left">&nbsp;<input id="qty" type="text" name="qty" value="'.$row[3].'" readOnly="true"><br/><br/></td>						
					</tr>
					<tr>
						<td align="right"><strong>Total :</strong></td>
						<td align="left">&nbsp;<input id="total" type="text" name="total" value="'.$row[4].'"><br/><br/></td>						
					</tr>
					<tr>
						<td align="right"><strong>Bank Name :</strong></td>
						<td align="left">&nbsp;
						 	<select name="bankname" id="bankname">
                  				<option>BCA - 0123456789</option>
								<option>BNI - 0123456789</option>
								<option>BRI - 0123456789</option>                  	
          	    			</select><br/><br/></td>						
					</tr>
					<tr>
						<td align="right"><strong>Sender :</strong></td>
						<td align="left">&nbsp;<input id="sender" type="text" name="sender" value="Sender"><br/><br/></td>						
					</tr>
					<tr>
						<td align="right"><strong>Comments :</strong></td>
						<td align="left">&nbsp;<input id="comments" type="text" name="comments" value="Comments"><br/><br/><br/><br/></td>						
					</tr>
					<tr><td></td><td><input type="submit" id="submit" value="Submit"></td></tr>
					</table></form>
					</div>
        		</div>
    		</section>';
	}
}
?>

				
            
    