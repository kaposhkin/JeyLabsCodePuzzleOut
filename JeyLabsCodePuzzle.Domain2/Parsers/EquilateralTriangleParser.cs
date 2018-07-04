using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-equilateral-triangle-command
	/// </summary>
	public class EquilateralTriangleParser : ParserBase<Polygon>
	{
		public override string ShapeName => "equilateral triangle";

		public override Polygon ParseInternal()
		{
			Polygon res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseSideLength(out var sideLength))
				{
					List<Point> points = ShapeGeometryCalculator.CalcPointsForEquilateralTriangle(sideLength);
					res = new Polygon(points);
				}
			}
			return res;
		}
	}
}
