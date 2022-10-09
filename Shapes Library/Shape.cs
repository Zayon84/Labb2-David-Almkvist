using System.Numerics;

public enum ShapeForm
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
        static Random rand = new Random();
        static int randomSizeRange = 100;

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Shape myShape;
            ShapeForm myShapeForm = (ShapeForm)rand.Next(Enum.GetNames(typeof(ShapeForm)).Length);

            myShape = myShapeForm switch
            {
                ShapeForm.Circle => new Circle(new Vector2(RandomizeFloat(), RandomizeFloat()), RandomizeFloat()),
                ShapeForm.Rectangle => new Rectangle(new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Square => new Rectangle(new Vector2(RandomizeFloat(), RandomizeFloat()), RandomizeFloat()),
                ShapeForm.Triangle => new Triangle(new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Sphere => new Sphere(new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat()), RandomizeFloat()),
                ShapeForm.Cuboid => new Cuboid(new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat()), new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Cube => new Cuboid(new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat()), RandomizeFloat())
            };

            return myShape;
        }

        public static Shape GenerateShape(Vector3 center)
        {
            Shape shape = new Circle(new Vector2(center.X,center.Y),5);

            Shape myShape;
            ShapeForm myShapeForm = (ShapeForm)rand.Next(Enum.GetNames(typeof(ShapeForm)).Length);

            myShape = myShapeForm switch
            {
                ShapeForm.Circle => new Circle(new Vector2(center.X, center.Y), RandomizeFloat()),
                ShapeForm.Rectangle => new Rectangle(new Vector2(center.X, center.Y), new Vector2(RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Square => new Rectangle(new Vector2(center.X,center.Y), RandomizeFloat()),
                ShapeForm.Triangle => new Triangle(new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat()), new Vector2(RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Sphere => new Sphere(new Vector3(center.X,center.Y,center.Z), RandomizeFloat()),
                ShapeForm.Cuboid => new Cuboid(new Vector3(center.X, center.Y, center.Z), new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat())),
                ShapeForm.Cube => new Cuboid(new Vector3(center.X, center.Y, center.Z), RandomizeFloat())
            };

            return shape;
        }

        static float RandomizeFloat()
        {
            return (float)rand.NextSingle() * randomSizeRange;
        }

        public override string ToString()
        {
            string shapeString = base.ToString().Remove(0, (base.ToString().IndexOf(".") + 1));

            return  shapeString + "\t@";
        }
    }
}


