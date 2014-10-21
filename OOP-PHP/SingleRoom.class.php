<?php

class SingleRoom extends Room {
    function __construct($roomNumber)
    {
        parent::__construct($roomNumber);
        $this->extras=["TV","AirConditioner"];
        $this->beds=1;
        $this->hasBalcony=false;
        $this->hasRestroom=true;
        $this->price=200;
        $this->roomType=RoomTypes::standard;
    }
}