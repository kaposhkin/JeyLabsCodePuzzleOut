
using System;
using System.Collections.Generic;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	public class Circle : IShape
	{
		public int Radius { get; }
		public string Name => "circle";
		public int Width => 2 * Radius;
		public int Height => 2 * Radius;
		public int X => Radius;
		public int Y => Radius;

		public Circle(int radius)
		{
			Radius = radius;
		}

	}
}
