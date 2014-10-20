package Shapes;
import Shapes.Interfaces.*;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable,AreaMeasurable {
	
	private Vertex[] verteces2D;

	public PlaneShape(Vertex[] verteces2d) {
		super();
		this.verteces2D = verteces2d;
	}
	
	public Vertex[] getVerteces2D() {
		return verteces2D;
	}

	@Override
	public abstract double getArea();

	@Override
	public abstract double getPerimeter();
}
