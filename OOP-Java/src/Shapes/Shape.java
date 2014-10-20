package Shapes;
import java.util.List;


public abstract class Shape {
	private List<Vertex> verteces;

	public List<Vertex> getVerteces() {
		return verteces;
	}

	public void setVerteces(List<Vertex> verteces) {
		this.verteces = verteces;
	}
	
}
