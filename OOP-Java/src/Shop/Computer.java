package Shop;

import Shop.Utils.AgeRestriction;

public class Computer extends ElectronicsProduct {

	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction, guaranteePeriod);
	}

	@Override
	public double getPrice(){
		if(this.quantity>=1000){
			return this.price*0.95;
		}
		else if(this.quantity<50){
			return this.price*1.05;
		}
		return this.price;
	}

	@Override
	public String toString() {
		return "Computer [Price=" + getPrice() + "]";
	}
	
}
