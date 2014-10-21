<?php
require_once("Room.class.php");
require_once("Reservation.class.php");

class BookingManager {
    static function bookRoom($room,$reservation){
        if(isset($room) && isset($reservation)){
            $room->addReservation($reservation);
            echo "Room <strong>".$room->getRoomNumber()."</strong> successfully booked for <strong>"
                .$reservation->getGuest()->getFirstName()." ".$reservation->getGuest()->getLastName()
                ."</strong> from <time>".$reservation->getStartDate()."</time> to <time>".$reservation->getEndDate()."</time>!";
        }
        else{
            trigger_error("Wrong input data");
        }
    }
}

//Room <strong>1408</strong> successfully booked for <strong>Svetlin Nakov</strong> from <time>24.10.2014</time> to <time>26.10.2014</time>!Room <strong>1408</strong> successfully booked for <strong>Svetlin Nakov</strong> from <time>24.10.2014</time> to <time>26.10.2014</time>!