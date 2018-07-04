using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2
{
	/// <summary>
	/// Default implementation of a factory of command parsers' palette
	/// </summary>
	public class ParsersPaletteFactoryDefault : IParsersPaletteFactory
	{
		public IEnumerable<IParser> GetParsers()
		{
			// TODO Implement using reflection or DI

			var parsers = new List<IParser>();
			parsers.Add(new CircleParser());
			parsers.Add(new SquareParser());
			parsers.Add(new RectangleParser());
			parsers.Add(new OvalParser());
			parsers.Add(new IsoscelesTriangleParser());
			parsers.Add(new ScaleneTriangleParser());
			parsers.Add(new EquilateralTriangleParser());
			parsers.Add(new PentagonParser());
			parsers.Add(new HexagonParser());
			parsers.Add(new HeptagonParser());
			parsers.Add(new OctagonParser());
			parsers.Add(new ParallelogramParser());

			return parsers;
		}
	}
}
