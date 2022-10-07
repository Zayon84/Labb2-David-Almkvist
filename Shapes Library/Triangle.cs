using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Triangle : Shapes2D
    {
        private Vector2 _point1;
        private Vector2 _point2;
        private Vector2 _point3;

        public Triangle(Vector2 point1, Vector2 point2, Vector2 point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public override float Circumference => CountDistans(_point1, _point2) + CountDistans(_point1, _point3) + CountDistans(_point3, _point2);

        public override Vector3 Center => throw new NotImplementedException();

        //public override float Area => throw new NotImplementedException();
        public override float Area => 20.3f;                                                                // Place HOlder number

        public override string ToString()
        {
            // PLACEHOLDERS                                                                                                 // TODO: fix proper values
            Vector2 tempCenter = new Vector2(8.1f, 7.1f);
            return base.ToString() + $"({tempCenter.X:f1} , {tempCenter.Y:f1})\t\t: p1({_point1.X:f1} {_point1.Y:f1}), p2({_point2.X:f1} {_point2.Y:f1}), p3({_point3.X:f1} {_point3.Y:f1}) ¤¤ C = {Circumference}";
        }

        private float CountDistans(Vector2 point1, Vector2 point2)
        {
            Vector2 distance = point1 - point2;
            return distance.Length();
        }

        private float GetMyArea()
        {
            float a = CountDistans(_point1, _point2);
            float b = CountDistans(_point1, _point3);
            float c = CountDistans(_point3, _point2);

            if (a > b)
            {

            }
            return 0;
        }
    }
}
