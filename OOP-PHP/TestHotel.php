<?php
function __autoload($className)
{
    require_once("./".$className.".class.php");
}

$singleRoom=new SingleRoom(206);
$bedroom=new Bedroom(306);
$apartment=new Apartment(402);

$firstGuest=new Guest("John","Doe",93202020);

$reservation=new Reservation("24-10-2014","26-10-2014",$firstGuest);

BookingManager::bookRoom($singleRoom,$reservation);
echo "\r\n";

$arrayRooms=[$singleRoom,$apartment,$bedroom];

$filterByBalconies=array_filter($arrayRooms,"checkBalconies");

function checkBalconies(Room $r){
    if($r->getHasBalcony()){
        return true;
    }
    return false;
}

foreach ($filterByBalconies as $fbb) {
    echo "room number:".$fbb->getRoomNumber()." has a balcony \r\n";
}

$filterByBathTubs=array_filter($arrayRooms,"checkBathTubs");

function checkBathTubs(Room $r){
    if(array_search("BathTub",$r->getExtras())){
        return true;
    }
    return false;
}

foreach ($filterByBathTubs as $fbbt) {
    echo "room number:".$fbbt->getRoomNumber()." has a bathtub \r\n";
}
