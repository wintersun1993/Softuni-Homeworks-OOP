package Shapes;

public class Rectangle extends PlaneShape {
	private double width;
	private double height;
	
	public Rectangle(Vertex[] verteces2d,double width,double height) {
		super(verteces2d);
		this.width=width;
		this.height=height;
	}
	

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double getArea() {
		return this.width*this.height;
	}

	@Override
	public double getPerimeter() {
		return (2 * this.width) + (2 * this.height);
	}

	@Override
	public String toString() {
		return "Rectangle [width=" + width + ", height=" + height
				+", getArea()=" + getArea() + ", getPerimeter()="
				+ getPerimeter()+"]";
	}
	
}
