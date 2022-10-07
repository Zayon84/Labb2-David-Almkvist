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
        //private bool _isCube;

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

        public bool IsCube 
        {
            get { return (_size.X == _size.Y) && _size.X == _size.Z ? true : false; }
        }

        public override float Volume => _size.X * _size.Y * _size.Z;

        public override Vector3 Center => _center;

        public override float Area => ((_size.X * _size.Y) + (_size.Y * _size.Z) + (_size.Z * _size.X) )* 2;

        public override string ToString()
        {
            string shapeString = IsCube ? "Cube\t@" : base.ToString();

            return shapeString + $"({Center.X:f1} , {Center.Y:f1}, {Center.Z:f1})\t: w = {_size.X:f1}, h = {_size.Y:f1}, l = {_size.Z:f1} -- V = {Volume}";
        }
    }
}
