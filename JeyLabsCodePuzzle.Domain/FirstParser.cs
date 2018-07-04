using System;
using System.Text.RegularExpressions;

namespace JeyLabsCodePuzzle.Domain
{
	public class FirstParser
	{
		//private static readonly Regex regexExpr = new Regex(@"\((?<PointX>[0-9-]+),(?<PointY>[0-9-]+)\)", RegexOptions.Compiled);
		private static readonly Regex regexExpr = new Regex(@"\(\bradius\ )(.+) ", RegexOptions.Compiled);

		public void TryParse()
		{
			string inputString = "Draw a circle with a radius of 100";

			var match = regexExpr.Match(inputString);
			if (match.Success)
			{

			}
		}
	}
}
