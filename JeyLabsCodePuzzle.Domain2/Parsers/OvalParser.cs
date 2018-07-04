using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-oval-command
	/// </summary>
	public class OvalParser : ParserBase<Oval>
	{
		public override string ShapeName => "oval";
		public override Oval ParseInternal()
		{
			Oval res = null;
			if (IsShapeNameCorrect())
			{
				if (TryParseXRadius(out var xRadius) && TryParseYRadius(out var yRadius))
				{
					res = new Oval(xRadius, yRadius);
				}
			}
			return res;
		}
	}
}
