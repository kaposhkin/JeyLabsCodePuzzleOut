using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Parser for draw-octagon-command
	/// </summary>
	public class OctagonParser : RegularPolygonParser
	{
		public override int SidesCount => 8;

		public override string ShapeName => "octagon";


	}
}
