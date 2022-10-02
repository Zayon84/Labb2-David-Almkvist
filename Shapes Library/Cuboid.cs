﻿using System;
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
        private bool _isCube;

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
            //set; 
        }

        public override float Volume => _size.X * _size.Y * _size.Z;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override float Area => ((_size.X * _size.Y) + (_size.Y * _size.Z) + (_size.Z * _size.X) )* 2;

        public override string ToString()
        {
            return base.ToString() + $" @({Center.X}, {Center.Y}, {Center.Z}) : w = {_size.X} h = {_size.Y} l = {_size.Z}";
        }
    }
}
