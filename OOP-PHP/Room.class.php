<?php
abstract class Room implements iReservable
{
    protected $reservations=[];
    protected $extras=[];
    protected $roomType;
    protected $hasRestroom;
    protected $hasBalcony;
    protected $beds;
    protected $roomNumber;
    protected $price;
    private $restGUI="no";
    private $balconyGUI="no";

    function __construct($roomNumber)
    {
        $this->roomNumber = $roomNumber;
    }

    public function setBeds($beds)
    {
        $this->beds = $beds;
    }

    public function getBeds()
    {
        return $this->beds;
    }

    public function setExtras($extras)
    {
        $this->extras = $extras;
    }

    public function getExtras()
    {
        return $this->extras;
    }

    public function setHasBalcony($hasBalcony)
    {
        $this->hasBalcony = $hasBalcony;
    }

    public function getHasBalcony()
    {
        return $this->hasBalcony;
    }

    public function setHasRestroom($hasRestroom)
    {
        $this->hasRestroom = $hasRestroom;
    }

    public function getHasRestroom()
    {
        return $this->hasRestroom;
    }

    public function setPrice($price)
    {
        $this->price = $price;
    }

    public function getPrice()
    {
        return $this->price;
    }

    public function setReservations($reservations)
    {
        $this->reservations = $reservations;
    }

    public function getReservations()
    {
        return $this->reservations;
    }

    public function setRoomNumber($roomNumber)
    {
        $this->roomNumber = $roomNumber;
    }

    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    public function setRoomType($roomType)
    {
        $this->roomType = $roomType;
    }

    public function getRoomType()
    {
        return $this->roomType;
    }

    function addReservation($reservation){
        $this->reservations[]=$reservation;
    }
    function removeReservation($reservation){
        unset($reservation,$this->reservations);
    }


    function __toString()
    {
        if($this->hasRestroom==true){
            $this->restGUI="yes";
        }
        if($this->hasBalcony==true){
            $this->balconyGUI="yes";
        }
        return 'Room Type:'.$this->roomType . "\r\n" .
               'Room Price:'.$this->price . "\r\n" .
               'Room Extras:'.implode(" and ",$this->extras) . "\r\n" .
               'Room Reservations:'.implode(", ",$this->getReservations()) . "\r\n" .
               'Balcony:'.$this->balconyGUI . "\r\n" .
               'Restroom:'.$this->restGUI . "\r\n" .
               'Room Number:'.$this->roomNumber . "\r\n";


    }


} 