<?php
session_start();
require("config.php");
if(array_key_exists('action', $_GET)){
	$action = $_GET['action'];
	if($action == "login"){
		$username = $_POST['username'];
		$password = $_POST['password'];

		if ( $username == "" ) error( "Silahkan Isi Username dengan benar !!!" );
		if ( $password == "" ) error( "Password kosong, apakah anda lupa ???" );

		dbConnect();
		$result = mysql_query( "SELECT phone FROM daftarcustomer WHERE (phone='$username' or email='$username') AND password = '$password'" ) or error( mysql_error() );
	
		if( mysql_num_rows( $result ) == 0 ) 
			error( "Maaf, username atau password anda Salah !!! " );
		else{	
			$row = mysql_fetch_row($result);
			$_SESSION['username'] = $row[0];
			header( "Location: index.php" );
		}
	}
	else	
		$_SESSION['username'] = false;
		header( "Location: index.php" );
}

function cek(){
if(empty($_SESSION['username']))
	return false;
elseif($_SESSION['username'] == false)
	return false;
else
	return true;
}
?>



