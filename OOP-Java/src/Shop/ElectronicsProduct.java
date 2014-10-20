package Shop;

import Shop.Utils.AgeRestriction;

public abstract class ElectronicsProduct extends Product {
	protected int guaranteePeriod;
	
	public ElectronicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction);
		this.guaranteePeriod=guaranteePeriod;
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}
	
}
