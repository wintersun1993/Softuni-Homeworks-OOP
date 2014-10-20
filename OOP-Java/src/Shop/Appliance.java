package Shop;

import Shop.Utils.AgeRestriction;

public class Appliance extends ElectronicsProduct {

	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction, guaranteePeriod);
	}
	
	@Override
	public double getPrice(){
		if(this.quantity<50){
			return this.price*1.05;
		}
		return this.price;
	}

	@Override
	public String toString() {
		return "Appliance [Price=" + getPrice() + "]";
	}
	
}
