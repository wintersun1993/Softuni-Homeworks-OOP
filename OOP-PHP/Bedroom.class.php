<?php
/**
 * Created by PhpStorm.
 * User: Boyan
 * Date: 14-10-21
 * Time: 21:42
 */

class Bedroom extends Room {
    function __construct($roomNumber)
    {
        parent::__construct($roomNumber);
        $this->extras=["TV","AirConditioner","Refrigerator","BathTub","Minibar"];
        $this->beds=2;
        $this->hasBalcony=true;
        $this->hasRestroom=true;
        $this->price=300;
        $this->roomType=RoomTypes::gold;
    }
}