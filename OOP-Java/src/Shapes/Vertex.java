package Shapes;

public class Vertex {
	private double x;
	private double y;
	
	public Vertex(double x, double y) {
		super();
		this.x = x;
		this.y = y;
	}

	public double getX() {
		return x;
	}

	public void setX(double x) {
		this.x = x;
	}

	public double getY() {
		return y;
	}

	public void setY(double y) {
		this.y = y;
	}
	
	public static double getDistance(Vertex vertOne,Vertex vertTwo){
		return Math.sqrt(((vertOne.x - vertOne.y) * (vertOne.x - vertOne.y)) +
				  ((vertTwo.x * vertTwo.y) * (vertTwo.x * vertTwo.y)));
	}
}
