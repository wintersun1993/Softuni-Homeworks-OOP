package Shop.Exceptions;

public class OutOfQuantityException extends ProductsException {

	public OutOfQuantityException() {
		super("We dont have anymore of this product");
	}
	
}
