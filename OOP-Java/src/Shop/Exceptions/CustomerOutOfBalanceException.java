package Shop.Exceptions;

public class CustomerOutOfBalanceException extends ProductsException {

	public CustomerOutOfBalanceException() {
		super("We're sorry! You do not have enough money to buy this.");
	}

}
