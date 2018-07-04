using System.Collections.Generic;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2
{
	/// <summary>
	/// Interface for a factory of command parsers' palette
	/// </summary>
	public interface IParsersPaletteFactory
	{
		/// <summary>
		/// Returns a collection of command parsers
		/// </summary>
		/// <returns></returns>
		IEnumerable<IParser> GetParsers();
	}
}