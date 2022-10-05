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
        private Vector2 _center;
        private Vector2 _size;
        //private bool _isSquare;

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
            
        public bool IsSquare
        {
            get { return _size.X == _size.Y ? true: false; }
            //set { _isSquare = value; }                        // DO we need this ?
        }

        public override float Circumference => _size.X * 2 + _size.Y * 2;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override float Area => _size.X * _size.Y;

        public override string ToString()
        {
            string shapeString = IsSquare ? "Square\t@" : base.ToString();
            return shapeString + $"({Center.X}, {Center.Y})\t\t: w = {_size.X} h = {_size.Y}" ;
        }
    }
}
