package Shop.Exceptions;

public class CustomerRestrictionException extends ProductsException {

	public CustomerRestrictionException() {
		super("We're sorry! You are not old enough for this product.");
	}

}
