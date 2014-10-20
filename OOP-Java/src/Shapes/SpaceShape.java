package Shapes;

import Shapes.Interfaces.AreaMeasurable;
import Shapes.Interfaces.VolumeMeasurable;

public abstract class SpaceShape implements AreaMeasurable,VolumeMeasurable {
	private Vertex3D[] verteces3d;
	
	public SpaceShape(Vertex3D[] verteces3d) {
		super();
		this.verteces3d = verteces3d;
	}
	
	public Vertex3D[] getVerteces3d() {
		return verteces3d;
	}

	@Override
	public abstract double getVolume();

	@Override
	public abstract double getArea();
}
