<?php
function declareContent($arg){
	if($arg == "Home"){
		require(".\contents\main.php");	
	}
	elseif($arg == "Menu"){
		require(".\contents\menu.php");	
	}
	elseif($arg == "Login"){
		require(".\contents\login.php");	
	}
}
?>