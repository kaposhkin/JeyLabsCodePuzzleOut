using System;
using System.Collections.Generic;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	public class Rectangle : IShape
	{
		public string Name => "rectangle";
		public int Width { get; private set; }

		public int Height { get; private set; }

		public Rectangle(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}
	}
}
