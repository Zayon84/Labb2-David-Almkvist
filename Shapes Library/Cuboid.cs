using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private Vector3 _size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3(width, width, width);
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
