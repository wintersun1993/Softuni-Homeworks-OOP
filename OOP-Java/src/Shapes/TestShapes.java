package Shapes;

public class TestShapes {

	public static void main(String[] args) {
		Vertex[] vertexRect={new Vertex(2,3)};
		Rectangle firstRect=new Rectangle(vertexRect,10,5);
		System.out.println(firstRect);
		
		Vertex[] vertexCirc={new Vertex(3,3)};
		Circle firstCircle=new Circle(vertexCirc,5);
		System.out.println(firstCircle);
		
		Vertex[] vertexTriangle={new Vertex (3,3),new Vertex(2,2),new Vertex(4,4)};
		Triangle firstTriangle=new Triangle(vertexTriangle);
		System.out.println(firstTriangle);
		
		Vertex3D[] vertexSphere={new Vertex3D(3,4,5)};
		Sphere firstSphere=new Sphere(vertexSphere,10);
		System.out.println(firstSphere);
	}
}
