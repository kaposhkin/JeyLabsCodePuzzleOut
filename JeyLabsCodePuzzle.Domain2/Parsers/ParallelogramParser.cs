using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-parallelogram-command
	/// </summary>
	public class ParallelogramParser : ParserBase<Polygon>
	{
		public override string ShapeName => "parallelogram";

		public override Polygon ParseInternal()
		{
			Polygon res = null;
			if (IsShapeNameCorrect())
			{
				if (true)
				{
					if (TryParseWidth(out var width) && TryParseHeight(out var height) && TryParseAngle(out var angle))
					{
						List<Point> points = ShapeGeometryCalculator.CalcPointsForParallelogram(width, height, angle);
						res = new Polygon(points);
					}
				}
			}

			return res;
		}
	}
}
