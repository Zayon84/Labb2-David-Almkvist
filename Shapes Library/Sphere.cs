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

        public float Radius { get => _radius; }

        public override float Volume => (4 * MathF.PI * Radius * Radius * Radius) / 3;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public override float Area => 4 * Radius * Radius * MathF.PI;

        public override string ToString()
        {
            return base.ToString() + $"({Center.X}, {Center.Y}, {Center.Z})\t: r = {Radius}";
        }
    }
}
