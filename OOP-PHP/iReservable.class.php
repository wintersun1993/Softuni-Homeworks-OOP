<?php
/**
 * Created by PhpStorm.
 * User: Boyan
 * Date: 14-10-21
 * Time: 20:41
 */

interface iReservable {
    function addReservation($reservation);
    function removeReservation($reservation);
} 