using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Library
{
    public class Rectangle : Shapes2D
    {
        private Vector3 _center;
        private Vector2 _size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new Vector3(center.X, center.Y, 0);
            _size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            _center = new Vector3(center.X, center.Y, 0);
            _size = new Vector2(width, width);
        }
            
        public bool IsSquare
        {
            get { return _size.X == _size.Y ? true: false; }
        }

        public override float Circumference => _size.X * 2 + _size.Y * 2;

        public override Vector3 Center => _center;

        public override float Area => _size.X * _size.Y;

        public override string ToString()
        {
            string shapeString = IsSquare ? "Square\t@" : base.ToString();
            return shapeString + $"({Center.X:f1} , {Center.Y:f1})\t\t: w = {_size.X:f1} h = {_size.Y:f1}" ;
        }
    }
}
