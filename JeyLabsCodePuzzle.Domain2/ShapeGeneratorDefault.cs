using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2
{
	/// <summary>
	/// Base implementation of a Shape Generator
	/// </summary>
	public class ShapeGeneratorDefault : IShapeGenerator
	{
		private readonly IParsersPaletteFactory parsersPaletteFactory;

		public ShapeGeneratorDefault(IParsersPaletteFactory parsersPaletteFactory)
		{
			this.parsersPaletteFactory = parsersPaletteFactory;
		}

		public IShape ParseCommand(string command)
		{
			var parsers = parsersPaletteFactory.GetParsers();
			foreach (var parser in parsers)
			{
				var shape = parser.Parse(command);
				if (shape != null)
					return shape;
			}

			return null;
		}
	}
}
