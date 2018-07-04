using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-isosceles-triangle-command
	/// </summary>
	public class IsoscelesTriangleParser : ParserBase<Polygon>
	{
		public override string ShapeName => "isosceles triangle";

		public override Polygon ParseInternal()
		{
			Polygon res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseWidth(out var width) && TryParseHeight(out var height))
				{
					List<Point> points = ShapeGeometryCalculator.CalcPointsForIsoscelesTriangle(width, height);
					res = new Polygon(points);
				}
			}
			return res;
		}
	}
}
