<?php

class Reservation {
    private $startDate;
    private $endDate;
    private $guest;

    function __construct($startDate, $endDate, Guest $guest)
    {
        $this->startDate = $startDate;
        $this->endDate = $endDate;
        $this->guest = $guest;
    }

    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }


    public function getEndDate()
    {
        return $this->endDate;
    }

    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    public function getGuest()
    {
        return $this->guest;
    }

    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    public function getStartDate()
    {
        return $this->startDate;
    }



    function __toString()
    {
        return "Start Date: $this->startDate, End Date:$this->endDate ,Guest: $this->guest";
    }


} 