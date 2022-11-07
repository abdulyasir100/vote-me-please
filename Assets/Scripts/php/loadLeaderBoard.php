<?php
include "connection.php";
$query = "SELECT ROW_NUMBER() OVER (ORDER BY u.follower DESC) as rank,u.idLogo as logo, u.username from user u";
  $result = mysqli_query($conn,$query) or die("QUERY FAILED". mysqli_error($conn));
$num_results = mysqli_num_rows($result);
for ($i=0; $i < $num_results; $i++) {
  $row = mysqli_fetch_array($result);
  echo $row['rank']."+".$row['username']."+".$row['logo'];
  if($i != $num_results - 1){
    echo ",";
  }
}
