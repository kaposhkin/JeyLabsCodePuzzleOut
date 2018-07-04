using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Base class for regular polygon such as hexagon or octagon
	/// </summary>
	public abstract class RegularPolygonParser : ParserBase<Polygon>
	{
		public abstract int SidesCount { get; }

		public override Polygon ParseInternal()
		{
			Polygon res = null;
			if (IsShapeNameCorrect())
			{
				if (true)
				{
					if (TryParseSideLength(out var sideLength))
					{
						List<Point> points = ShapeGeometryCalculator.CalcPointsForRegularPoligon(SidesCount, sideLength);
						res = new Polygon(points);
					}
				}
			}

			return res;
		}
	}
}
