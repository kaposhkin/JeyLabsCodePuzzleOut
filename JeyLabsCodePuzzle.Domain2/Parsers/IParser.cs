using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	public interface IParser
	{
		IShape Parse(string inputString);
	}
}
