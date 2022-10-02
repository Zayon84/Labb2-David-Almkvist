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

        public override float Volume => (4 * MathF.PI * _radius * _radius * _radius) / 3;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override float Area => 4 * _radius * _radius * MathF.PI;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
