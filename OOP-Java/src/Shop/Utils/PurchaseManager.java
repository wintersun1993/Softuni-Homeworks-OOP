package Shop.Utils;

import Shop.Customer;
import Shop.Product;
import Shop.Exceptions.*;
public final class PurchaseManager {
	
	public static void processPurchase(Customer customer,Product product){
		try{
			if(product.getQuantity()<1){
				throw new OutOfQuantityException();
			}
			if(customer.getBalance()<product.getPrice()){
				throw new CustomerOutOfBalanceException();
			}
			if((customer.getAge()<18 && product.getAgeRestriction()==AgeRestriction.ADULT) ||
				customer.getAge()<14 && product.getAgeRestriction()==AgeRestriction.TEENAGER){
				throw new CustomerRestrictionException();
			}
			customer.setBalance(customer.getBalance()-product.getPrice());
			product.setQuantity(product.getQuantity()-1);
		}
		catch(OutOfQuantityException ooque){
			System.out.println(ooque.getLocalizedMessage());
		}
		catch(CustomerOutOfBalanceException coobe){
			System.out.println(coobe.getLocalizedMessage());
		}
		catch(CustomerRestrictionException cre){
			System.out.println(cre.getLocalizedMessage());
		}
	}
}
