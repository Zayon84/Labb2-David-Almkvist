using System.Numerics;

namespace Shapes_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        //public static Shape GenerateShape()
        //{
        //    //Shape shape = new Shape();        // TODO: not really but something
        //    //return new Shape();
        //}

        public static void GenerateShape()
        {
            //Shape shape = new Shape();        // TODO: not really but something
            //return new Shape();
        }
    }

}