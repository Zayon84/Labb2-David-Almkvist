using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Circle : Shapes2D
    {
        private Vector2 _center;
        private float _radius;

        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
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
