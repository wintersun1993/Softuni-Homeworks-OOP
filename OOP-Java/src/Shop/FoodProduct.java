package Shop;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

import Shop.Interfaces.Expirable;
import Shop.Utils.AgeRestriction;

public class FoodProduct extends Product implements Expirable {
	
	Date expirationDate;
	Date currentDate = new Date();
	long difference;
	
	public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, String expirationDate) {
		super(name, price, quantity, ageRestriction);

		SimpleDateFormat simpleFormat = (SimpleDateFormat) DateFormat.getDateInstance();
		simpleFormat.applyPattern("yyyy-MM-dd");
		
		try {
			this.expirationDate = simpleFormat.parse(expirationDate);
		}
		catch (ParseException e) {
			throw new IllegalArgumentException("Wrong date");
		}
	}
	
	public Boolean checkExpire(){
		difference=currentDate.getTime() - expirationDate.getTime();
		difference=TimeUnit.DAYS.convert(difference, TimeUnit.MILLISECONDS);
		if(difference<1){
			return true;
		}
		else{
			return false;
		}
	}
	public double getPrice(){
		difference=currentDate.getTime() - expirationDate.getTime();
		difference=TimeUnit.DAYS.convert(difference, TimeUnit.MILLISECONDS);
		if(difference<15){
			return this.price*0.7;
		}
		else{
			return this.price;
		}
	}

	public Date getExpirationDate() {
		return expirationDate;
	}
	
	public Boolean isExpired(){
		return checkExpire();
	}

	@Override
	public String toString() {
		return "FoodProduct [getPrice()=" + getPrice()
				+ ", getExpirationDate()=" + getExpirationDate() + "]";
	}
	

}
