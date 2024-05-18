﻿namespace Shapes
{
    public abstract class Shape
    {
        public double Area { get; protected set; }
        public abstract void FindArea();
    }
}

