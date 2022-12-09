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

        public override Vector3 Center =>  CalculateCenter();

        private Vector3 CalculateCenter()
        {
            float xpos = (_point1.X + _point2.X + _point3.X) / 3;
            float ypos = (_point1.Y + _point2.Y + _point3.Y) / 3;
            Vector3 mycenter = new Vector3(xpos, ypos, 0);
            return mycenter;
        }
        public override float Area => CalculateTriangleArea(); 

        public override string ToString()
        {                                                                                          // TODO: fix proper values
            Vector2 tempCenter = new Vector2(Center.X, Center.Y);
            return base.ToString() + $"({tempCenter.X:f1} , {tempCenter.Y:f1})\t\t: " +
                $"p1({_point1.X:f1} {_point1.Y:f1}), " +
                $"p2({_point2.X:f1} {_point2.Y:f1}), " +
                $"p3({_point3.X:f1} {_point3.Y:f1})";
        }

        private float CountDistans(Vector2 point1, Vector2 point2)
        {
            Vector2 distance = point1 - point2;
            return distance.Length();
        }

        private float CalculateTriangleArea()
        {
            float[] pointsDistans = { CountDistans(_point1, _point2), CountDistans(_point1, _point3), CountDistans(_point3, _point2) };
            Array.Sort(pointsDistans);
            return (pointsDistans[0] * pointsDistans[1]) / 2;
        }
    }
}
