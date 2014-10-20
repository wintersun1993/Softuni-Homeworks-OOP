package Shapes;

public class Vertex3D extends Vertex {
	private double z;
	
	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.z=z;
	}

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}
}
