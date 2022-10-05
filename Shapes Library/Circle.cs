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

        public float Radius { get => _radius ;  }

        public override float Circumference => 2 * MathF.PI * _radius;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override float Area => MathF.PI * _radius * _radius;

        public override string ToString()
        {
            return base.ToString() + $"({Center.X }, {Center.Y})\t\t: r = {Radius}";
        }
    }
}