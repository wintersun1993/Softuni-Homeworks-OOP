<?php
/**
 * Created by PhpStorm.
 * User: Boyan
 * Date: 14-10-21
 * Time: 22:41
 */

class EReservationException extends Exception {
    function __construct(){
        parent::__construct("Those dates are already reserved");
    }
} 