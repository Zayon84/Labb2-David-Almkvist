using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Sphere : Shape3D
    {
        private Vector3 _center;
        private float _radius;

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }

        public override float Volume => throw new NotImplementedException();

        public override Vector3 Center => throw new NotImplementedException();

        public override float Area => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
