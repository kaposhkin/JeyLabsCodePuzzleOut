using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-hexagon-command
	/// </summary>
	public class HexagonParser : RegularPolygonParser
	{
		public override int SidesCount => 6;

		public override string ShapeName => "hexagon";
	}
}
