<?php
include "connection.php";
$follower = "";
$username = "";

if(isset($_GET['follower']) && isset($_GET['username'])){
  $follower = $_GET['follower'];
  $username = $_GET['username'];
  $image = $_GET['logo'];

  $query = "SELECT u.username FROM user u WHERE u.username = '$username'";
  $result = mysqli_query($conn,$query)or die("QUERY FAILED". mysqli_error($conn));
  $num_results = mysqli_num_rows($result);
  if($num_results > 0){
  $query = "UPDATE user SET follower = $follower WHERE username = '$username'";
  $result = mysqli_query($conn,$query)or die("QUERY FAILED". mysqli_error($conn));
  }else{
    $query = "INSERT INTO user(username,follower,logo) VALUES('$username','$follower','$image')";
    $result = mysqli_query($conn,$query)or die("QUERY FAILED". mysqli_error($conn));

  }
}


?>
