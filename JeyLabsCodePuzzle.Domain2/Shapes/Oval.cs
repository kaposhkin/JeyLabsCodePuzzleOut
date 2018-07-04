using System;
using System.Collections.Generic;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	public class Oval : IShape
	{
		public int XRadius { get; }
		public int YRadius { get; }
		public string Name => "oval";
		public int Width => 2 * XRadius;
		public int Height => 2 * YRadius;
		public int X => XRadius;
		public int Y => YRadius;

		public Oval(int xRadius, int yRadius)
		{
			XRadius = xRadius;
			YRadius = yRadius;
		}
	}
}
