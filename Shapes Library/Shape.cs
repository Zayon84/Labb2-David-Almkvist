using System.Numerics;

enum ShapeForm
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
        static int randomSizeRange = 10;

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Shape myShape;
            ShapeForm myShapeForm = (ShapeForm)rand.Next(Enum.GetNames(typeof(ShapeForm)).Length);

            //myShape = myShapeForm switch
            //{
            //    ShapesForm.Circle => new Circle(new Vector2(5.0f, 2.0f), 3.0f),
            //    ShapesForm.Rectangle => new Rectangle(new Vector2(3.0f, 4.0f), new Vector2(4.0f, 5.0f)),
            //    ShapesForm.Square => new Rectangle(new Vector2(3.0f, 4.0f), 5),
            //    ShapesForm.Triangle => new Triangle(new Vector2(3.0f, 5.0f), new Vector2(7.0f, 3.2f), new Vector2(9.0f, 2.0f)),
            //    ShapesForm.Sphere => new Sphere(new Vector3(3.0f, 3.0f, 3.0f), 7.0f),
            //    ShapesForm.Cuboid => new Cuboid(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(3.0f, 2.0f, 4.0f)),
            //    ShapesForm.Cube => new Cuboid(new Vector3(4.0f, 4.0f, 4.0f), 5.0f)
            //};

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

        public static Shape GenerateShape2()
        {
            Shape shape = new Circle(new Vector2(2.3f,3.0f),5);

            return shape;
        }
        //private Vector3 RandomizeVector3()
        //{

        //    return new Vector3(RandomizeFloat(), RandomizeFloat(), RandomizeFloat());
        //}

        static Vector2 RandomizeVector2()
        {
            return new Vector2( RandomizeFloat(), RandomizeFloat());
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


