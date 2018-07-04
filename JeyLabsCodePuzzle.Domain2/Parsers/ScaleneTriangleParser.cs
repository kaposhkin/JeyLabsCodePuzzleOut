using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-scalene-triangle-command
	/// </summary>
	public class ScaleneTriangleParser : ParserBase<Polygon>
	{
		public override string ShapeName => "scalene triangle";

		public override Polygon ParseInternal()
		{
			Polygon res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseFirstSideLength(out var firstSideLength) && TryParseSecondSideLength(out var secondSideLength) && TryParseAngle(out var angle))
				{
					List<Point> points = ShapeGeometryCalculator.CalcPointsForScaleneTriangle(firstSideLength, secondSideLength, angle);
					res = new Polygon(points);
				}
			}
			return res;
		}
	}
}
