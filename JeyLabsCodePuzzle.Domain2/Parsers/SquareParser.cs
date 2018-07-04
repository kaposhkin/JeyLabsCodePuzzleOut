using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-square-command
	/// </summary>
	public class SquareParser : ParserBase<Square>
	{
		public override string ShapeName => "square";

		public override Square ParseInternal()
		{
			Square res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseSideLength(out var sideLength))
				{
					res = new Square(sideLength);
				}
			}
			return res;
		}
	}
}
