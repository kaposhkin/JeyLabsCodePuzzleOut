using System;
using System.Collections.Generic;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	public class Square : IShape
	{
		public int SideLength { get; }
		public string Name => "square";
		public int Width => SideLength;
		public int Height => SideLength;

		public Square(int sideLength)
		{
			SideLength = sideLength;
		}
	}
}
