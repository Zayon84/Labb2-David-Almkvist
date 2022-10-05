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

        public static Shape GenerateShape()
        {
            Shape myShape;
            Random rand = new Random();
            ShapesForm myShapeForm = (ShapesForm)rand.Next(Enum.GetNames(typeof(ShapesForm)).Length);

            myShape = myShapeForm switch
            {
                ShapesForm.Circle => new Circle(new Vector2(5.0f, 2.0f), 3),
                ShapesForm.Rectangle => new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(4.0f, 5.0f)),
                ShapesForm.Square => new Rectangle(new Vector2(3.0f, 4.0f), 5),
                ShapesForm.Triangle => new Triangle(new Vector2(3.0f, 5.0f), new Vector2(7.0f, 3.2f), new Vector2(9.0f, 2.0f)),
                ShapesForm.Sphere => new Sphere(new Vector3(3.0f, 3.0f, 3.0f), 7.0f),
                ShapesForm.Cuboid => new Cuboid(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(3.0f, 2.0f, 4.0f)),
                ShapesForm.Cube => new Cuboid(new Vector3(4.0f, 4.0f, 4.0f), 5.0f)
            };
            return myShape;
        }

        public static Shape GenerateShape2()
        {
            Shape shape = new Circle(new Vector2(2.3f,3.0f),5);

            return shape;
        }

        public override string ToString()
        {
            string shapeString = base.ToString().Remove(0, (base.ToString().IndexOf(".") + 1));

            return  shapeString + "\t@";
        }
    }

}


////ShapesForm myShape = (shShape.GenerateShape();
//int number = 2;
//shapesArray[i] = number switch
//{
//    0 => new Circle(new Vector2(5.0f, 2.0f), 3),
//    1 => new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(4.0f, 5.0f)),
//    2 => new Rectangle(new Vector2(3.0f, 4.0f), 5),
//    3 => new Triangle(new Vector2(3.0f, 5.0f), new Vector2(7.0f, 3.2f), new Vector2(9.0f, 2.0f)),
//    4 => new Sphere(new Vector3(3.0f, 3.0f, 3.0f), 7.0f),
//    5 => new Cuboid(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(3.0f, 2.0f, 4.0f)),
//    6 => new Cuboid(new Vector3(4.0f, 4.0f, 4.0f), 5.0f),

//};