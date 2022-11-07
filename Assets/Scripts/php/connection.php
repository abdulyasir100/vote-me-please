<?php
$server = "localhost";
$username = "id9425136_root";
$password = "rahasia";
$database ="id9425136_leaderboard";

$conn = new mysqli($server,$username,$password,$database);
if(!$conn){
  die("Connection Failed .". mysqli_connect_error());
}
?>
