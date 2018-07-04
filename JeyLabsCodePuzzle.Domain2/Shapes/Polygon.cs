using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	public class Polygon : IShape
	{
		public IEnumerable<Point> Points { get; private set; }
		public string Name => "polygon";
		public int Width { get; private set; }
		public int Height { get; private set; }

		public Polygon(IEnumerable<Point> points)
		{
			this.Points = points;

			CalculateWidthAndHeight();
		}

		private void CalculateWidthAndHeight()
		{
			Width = this.Points.Max(p => p.X);
			Height = this.Points.Max(p => p.Y);
		}

		public string GetPointsString()
		{
			var res = string.Concat(this.Points.Select(p => $"{p.X},{p.Y} "));
			return res;
		}
	}
}
