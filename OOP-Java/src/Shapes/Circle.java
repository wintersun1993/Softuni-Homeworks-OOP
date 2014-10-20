package Shapes;

public class Circle extends PlaneShape {
	private double radius;
	
	public Circle(Vertex[] verteces2d,double radius) {
		super(verteces2d);
		this.radius=radius;
	}
	

	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	public double getRadius() {
		return radius;
	}

	@Override
	public double getPerimeter() {
		return 2.0*Math.PI*this.radius;
	}

	@Override
	public double getArea() {
		return this.radius * this.radius*Math.PI;
	}


	@Override
	public String toString() {
		return "Circle [radius=" + radius + ", getPerimeter()=" + getPerimeter() +
				", getArea()=" + getArea() + "]";
	}
}
