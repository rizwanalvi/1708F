	<?php 
if(isset($_POST['submit'])){
    $to = "humnaimran1995@gmail.com"; 
	$Subject = "New Message Received";
	
    $from = $_POST['email']; 
    $Name = $_POST['Name'];
    $LastName = $_POST['LastName'];
	$BloodGroup = $_POST['BloodGroup'];
    $PlaceBirth = $_POST['PlaceBirth'];
	$CNIC = $_POST['CNIC'];
    $Nationality = $_POST['Nationality'];
	$Religion = $_POST['Religion'];
    $Languages = $_POST['Languages'];
	$selected_radio = $_POST['gender'];
	$selected_radio = $_POST['MartialStatus'];
	
	$Address = $_POST['Address'];
    $PermenantAddress = $_POST['PermenantAddress'];
	$phoneNumber = $_POST['phoneNumber'];
    $email = $_POST['email'];
	
	$qualification = $_POST['qualification'];
	$Name = $_POST['Name'];
	$Address = $_POST['Address'];
	$phoneNumber = $_POST['phoneNumber'];
	$fax = $_POST['fax'];
	$email = $_POST['email'];
	$website = $_POST['website'];
	
	$career_objective = $_POST['career_objective'];
	
	$achievements_information = $_POST['achievements_information'];
	
	$suggestion = $_POST['suggestion'];
	
	
	
	
	
	
    $subject = "YPPF | Forms";
    $subject2 = "Copy of your YPPF | Forms";
    $message = $Name . " " . $LastName . " " . $BloodGroup . " " .$PlaceBirth . " " .$CNIC . " " .$Nationality . " " .$Religion . " " .$Languages . " " .$selected_radio . " " .$selected_radio . " " .$Address . " " .$PermenantAddress . " " .$phoneNumber . " "
				 .$email . " " .$qualification . " " .$Name . " ".$Address . " " .$phoneNumber . " " .$fax . " " .$email . " " .$website . " " .$career_objective . " " .$achievements_information . " "
				 .$suggestion . " ". "\n\n" . $_POST['message'];
    $message2 = "Here is a copy of your Forms " . $Name . " " . $LastName . " " . $BloodGroup . " " .$PlaceBirth . " " .$CNIC . " " .$Nationality . " " .$Religion . " " .$Languages . " " .$selected_radio . " " .$selected_radio . " " .$Address . " " .$PermenantAddress . " " .$phoneNumber . " "
				 .$email . " " .$qualification . " " .$Name . " ".$Address . " " .$phoneNumber . " " .$fax . " " .$email . " " .$website . " " .$career_objective . " " .$achievements_information . " "
				 .$suggestion . " ". "\n\n" . $_POST['message'];

    $headers = "From:" . $from;
    $headers2 = "From:" . $to;
	
     mail($to,$subject,$message,$headers);
    mail($from,$subject2,$message2,$headers2);// sends a copy of the message to the sender
    echo "Mail Sent. Thank you " . $Name . ", we will contact you shortly.";
    // You can also use header('Location: thank_you.php'); to redirect to another page.
    }
?>
	
	
	
<?php 
//$errorMSG = "";

// NAME
//if (empty($_POST["name"])) {
  //  $errorMSG = "Name is required ";
//} else {
   // $name = $_POST["name"];
//}

// EMAIL
//if (empty($_POST["email"])) {
  //  $errorMSG .= "Email is required ";
//} else {
  //  $email = $_POST["email"];
//}

// MSG SUBJECT
//if (empty($_POST["msg_subject"])) {
  //  $errorMSG .= "Subject is required ";
//} else {
   // $msg_subject = $_POST["msg_subject"];
//}


// MESSAGE
//if (empty($_POST["message"])) {
  //  $errorMSG .= "Message is required ";
//} else {
  //  $message = $_POST["message"];
//}


//$EmailTo = "hello@yoursite.com";
//$Subject = "New Message Received";

// prepare email body text
//$Body = "";
//$Body .= "Name: ";
//$Body .= $name;
//$Body .= "\n";
//$Body .= "Email: ";
//$Body .= $email;
//$Body .= "\n";
//$Body .= "Subject: ";
//$Body .= $msg_subject;
//$Body .= "\n";
//$Body .= "Message: ";
//$Body .= $message;
//$Body .= "\n";

// send email
//$success = mail($EmailTo, $Subject, $Body, "From:".$email);

// redirect to success page
//if ($success && $errorMSG == ""){
 //  echo "success";
//}else{
 //   if($errorMSG == ""){
  //      echo "Something went wrong :(";
  //  } else {
   //     echo $errorMSG;
  //  }
//}

?>