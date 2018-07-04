using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-circle-command
	/// </summary>
	public class CircleParser : ParserBase<Circle>
	{
		public override string ShapeName => "circle";

		public override Circle ParseInternal()
		{
			Circle res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseRadius(out var radius))
				{
					res = new Circle(radius);
				}
			}
			return res;
		}
	}
}
