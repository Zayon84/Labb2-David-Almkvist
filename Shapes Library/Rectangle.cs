using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Rectangle : Shapes2D
    {
        private Vector2 _center;
        private Vector2 _size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center = center;
            _size = new Vector2(width, width);
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
