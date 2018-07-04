using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-heptagone-command
	/// </summary>
	public class HeptagonParser : RegularPolygonParser
	{
		public override int SidesCount => 7;

		public override string ShapeName => "heptagon";
	}
}
