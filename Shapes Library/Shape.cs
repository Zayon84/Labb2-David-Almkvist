using System.Numerics;

enum ShapesForm
{
    Circle,
    Rectangle,
    Square, 
    Triangle,
    Sphere,
    Cuboid,
    Cube
}

namespace Shapes_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static int GenerateShape()
        {
            ShapesForm myShape = ShapesForm.Circle;
            Random rand = new Random();            
            return (int)myShape;
        }

        public static Shape GenerateShape2()
        {
            Shape shape = new Circle(new Vector2(2,3),5);

            return shape;
        }
    }

}