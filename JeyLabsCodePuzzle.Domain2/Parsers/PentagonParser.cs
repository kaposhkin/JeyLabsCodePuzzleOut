using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-pentagon-command
	/// </summary>
	public class PentagonParser : RegularPolygonParser
	{
		public override int SidesCount => 5;

		public override string ShapeName => "pentagon";
	}
}
