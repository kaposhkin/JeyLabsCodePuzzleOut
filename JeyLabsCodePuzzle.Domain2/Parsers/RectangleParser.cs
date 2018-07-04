using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-rectangle-command
	/// </summary>
	public class RectangleParser : ParserBase<Rectangle>
	{
		public override string ShapeName => "rectangle";

		public override Rectangle ParseInternal()
		{
			Rectangle res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseWidth(out var width) && TryParseHeight(out var height))
				{
					res = new Rectangle(width, height);
				}
			}
			return res;
		}
	}
}
