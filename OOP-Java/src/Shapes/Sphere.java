package Shapes;

public class Sphere extends SpaceShape {
	private double radius;
	public Sphere(Vertex3D[] verteces3d, double radius) {
		super(verteces3d);
		this.radius=radius;
	}
	
	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}

	@Override
	public double getVolume() {
		return ((4/3)*Math.PI)*(this.radius*this.radius*this.radius);
	}

	@Override
	public double getArea() {
		return 4.0*Math.PI*(this.radius*this.radius);
	}

	@Override
	public String toString() {
		return "Sphere [radius=" + radius + ", getVolume()=" + getVolume()
				+ ", getArea()=" + getArea() +"]";
	}
}
