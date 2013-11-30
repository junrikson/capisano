<?php
$dbHost = "localhost";                              // Database host
$dbName = "capisano";                                  // Database name
$dbUser = "capisano";                                   // Database user
$dbPasswd = "capisano";     
$username = ""; 
$password = "";                                // Database password
    
function dbConnect(){
	global $dbHost, $dbUser, $dbPasswd, $dbName;
	mysql_connect( $dbHost, $dbUser, $dbPasswd ) or error( mysql_error() );
	mysql_select_db( $dbName );
}

function error( $error ){
	echo "<p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\">&nbsp;</p>\n";
    echo "<div align=\"center\">\n";
    echo "<center>\n";
    echo "<table border=\"1\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: collapse\" bordercolor=\"#FF0000\" width=\"533\" id=\"AutoNumber1\">\n";
    echo " <tr>\n";
    echo " <td bgcolor=\"#FFFFFF\">\n";
    echo " <p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\"><b>\n";
    echo " <font face=\"Arial\" size=\"5\">Error !!!</font></b></p>\n";
    echo " <p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\">&nbsp;</p>\n";
    echo " <p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\"><b>\n";
    echo " <font color=\"#FF0000\">$error</font></b></p>\n";
    echo " <p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\">&nbsp;</p>\n";
    echo " <p align=\"center\" style=\"margin-top: 0; margin-bottom: 0\">\n";
    echo " <a href=\"javascript:history.back()\">back</a></td>\n";
    echo " </tr>\n";
    echo "</table>\n";
    echo "</center>\n";
    echo "</div>\n";
	exit;
}
?>

