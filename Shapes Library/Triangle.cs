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

        public override float Circumference => throw new NotImplementedException();

        public override Vector3 Center => throw new NotImplementedException();

        public override float Area => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
