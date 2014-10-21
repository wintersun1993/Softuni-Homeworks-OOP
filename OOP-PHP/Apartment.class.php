<?php
/**
 * Created by PhpStorm.
 * User: Boyan
 * Date: 14-10-21
 * Time: 21:44
 */

class Apartment extends Room {
    function __construct($roomNumber)
    {
        parent::__construct($roomNumber);
        $this->extras=["TV","AirConditioner","free wi-fi","kitchen box","refrigerator","BathTub"];
        $this->beds=4;
        $this->hasBalcony=true;
        $this->hasRestroom=true;
        $this->price=500;
        $this->roomType=RoomTypes::diamond;
    }


} 