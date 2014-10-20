package Shop;

import Shop.Interfaces.Buyable;
import Shop.Utils.AgeRestriction;

public abstract class Product implements Buyable {
	protected String name;
	protected double price;
	protected int quantity;
	protected AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity, AgeRestriction ageRestriction) {
		super();
		this.name = name;
		this.price = price;
		this.quantity = quantity;
		this.ageRestriction = ageRestriction;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}
	@Override
	public String toString() {
		return "Product [getName()=" + getName() + ", getPrice()=" + getPrice()
				+ ", getQuantity()=" + getQuantity() + ", getAgeRestriction()="
				+ getAgeRestriction() + "]";
	}
}
