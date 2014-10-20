package Shapes;

public class Triangle extends PlaneShape {
	
	private double sideA;
	private double sideB;
	private double sideC;
	private Vertex pointA;
	private Vertex pointB;
	private Vertex pointC;

	public Triangle(Vertex[] verteces2d) {
		super(verteces2d);
		this.pointA = verteces2d[0];
		this.pointB = verteces2d[1];
		this.pointC = verteces2d[2];
	}

	public double getSideA() {
		return Vertex.getDistance(pointA, pointB);
	}

	public double getSideB() {
		return Vertex.getDistance(pointB, pointC);
	}

	public double getSideC() {
		return Vertex.getDistance(pointA, pointC);
	}

	@Override
	public double getArea() {
		double perimeter = this.getPerimeter();
		return Math.sqrt(perimeter * (perimeter - this.sideA)
				* (perimeter - this.sideB) * (perimeter - this.sideC));
	}

	@Override
	public double getPerimeter() {
		return this.getSideA() + getSideB() + getSideC();
	}
	

	@Override
	public String toString() {
		return "Triangle [getSideA()=" + getSideA() + ", getSideB()="
				+ getSideB() + ", getSideC()=" + getSideC() + ", getArea()="
				+ getArea() + ", getPerimeter()=" + getPerimeter() + "]";
	}
}
