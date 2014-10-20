package Shop;

import Shop.Utils.AgeRestriction;
import Shop.Utils.PurchaseManager;

public class TestShop {

	public static void main(String[] args) {
		FoodProduct cigarettes=new FoodProduct("Marlboro",20,10,AgeRestriction.ADULT,"2014-10-06");
		
		Computer pravetz=new Computer("Pravetz",100,1020,AgeRestriction.NONE,24);
		Computer pentium=new Computer("Pentium",100,0,AgeRestriction.NONE,24);
		
		Customer petko=new Customer("Petko",16,100);
		Customer ivan=new Customer("Ivan",22,1000);
		Customer stoyan=new Customer("Stoyan",10,25);
		
		PurchaseManager.processPurchase(petko, cigarettes);//this will throw CustomerRestrictionException as age restriction is ADULT
		
		System.out.println("Ivan's Balance before purchase: "+ivan.getBalance());
		System.out.println("Cigarettes Quantity before purchase: "+cigarettes.getQuantity());
		PurchaseManager.processPurchase(ivan, cigarettes);// this will reduce the balance of ivan and the quantity of cigarettes.
		System.out.println("Ivan's Balance after purchase: "+ivan.getBalance());
		System.out.println("Cigarettes Quantity after purchase: "+cigarettes.getQuantity());
		
		PurchaseManager.processPurchase(stoyan, pentium);//this will throw OutOfQuantityException as pentium quantity is 0.
		
		PurchaseManager.processPurchase(stoyan,pravetz);//this will throw CustomerOutOfBalance exception.
		
		
		
	}
}
