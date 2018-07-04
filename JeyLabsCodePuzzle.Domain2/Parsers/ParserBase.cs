using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Parsers
{
	/// <summary>
	/// Base class for a parser
	/// </summary>
	/// <typeparam name="TShape"></typeparam>
	public abstract class ParserBase<TShape> : IParser where TShape : IShape
	{
		protected string inputString;

		private static readonly Regex circleRadiusRegexExpr = new Regex(@"(\bradius of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex sideLengthRegexExpr = new Regex(@"(\bside length of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex firstSideLengthRegexExpr = new Regex(@"(\bfirst side length of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex secondSideLengthRegexExpr = new Regex(@"(\bsecond side length of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex widthRegexExpr = new Regex(@"(\bwidth of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex heightRegexExpr = new Regex(@"(\bheight of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex xRadiusRegexExpr = new Regex(@"(\bx-axis radius of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex yRadiusRegexExpr = new Regex(@"(\by-axis radius of\ )(.+) ", RegexOptions.Compiled);
		private static readonly Regex angleRegexExpr = new Regex(@"(\bangle of\ )(.+) ", RegexOptions.Compiled);


		public abstract string ShapeName { get; }

		protected void SetInputString(string inputString)
		{
			if (string.IsNullOrEmpty(inputString))
				throw new ArgumentNullException($"InputString can not be empty");

			var inStr = inputString
				.Replace('.', ' ')
				.Replace(',', ' ')
				.ToLower();

			// Clean multiple white-spaces
			inStr = Regex.Replace(inStr, @"\s+", " ");

			this.inputString = inStr + " ";
		}

		public TShape Parse(string inputString)
		{
			// Here we use Template Method Pattern

			SetInputString(inputString);

			return ParseInternal();
		}

		IShape IParser.Parse(string inputString)
		{
			return Parse(inputString);
		}

		public abstract TShape ParseInternal();

		protected bool IsShapeNameCorrect()
		{
			return this.inputString.Contains(ShapeName.ToLower());
		}

		protected bool TryParseRadius(out int radius)
		{
			return TryParseParameter(circleRadiusRegexExpr, out radius);
		}

		protected bool TryParseWidth(out int width)
		{
			return TryParseParameter(widthRegexExpr, out width);
		}

		protected bool TryParseHeight(out int height)
		{
			return TryParseParameter(heightRegexExpr, out height);
		}

		protected bool TryParseSideLength(out int sideLength)
		{
			return TryParseParameter(sideLengthRegexExpr, out sideLength);
		}

		protected bool TryParseFirstSideLength(out int sideLength)
		{
			return TryParseParameter(firstSideLengthRegexExpr, out sideLength);
		}

		protected bool TryParseSecondSideLength(out int sideLength)
		{
			return TryParseParameter(secondSideLengthRegexExpr, out sideLength);
		}

		protected bool TryParseXRadius(out int xRadius)
		{
			return TryParseParameter(xRadiusRegexExpr, out xRadius);
		}

		protected bool TryParseYRadius(out int yRadius)
		{
			return TryParseParameter(yRadiusRegexExpr, out yRadius);
		}

		protected bool TryParseAngle(out int angle)
		{
			return TryParseParameter(angleRegexExpr, out angle);
		}


		private bool TryParseParameter(Regex regexExpression, out int parameter)
		{
			bool res = false;
			parameter = 0;

			var match = regexExpression.Match(inputString);
			if (match.Success)
			{
				int lastGroupIndex = match.Groups.Count - 1;
				var values = match.Groups[lastGroupIndex].Value.Split(' ');
				if (values.Any())
				{
					res = Int32.TryParse(values.First(), out parameter);
				}
			}

			return res;
		}
	}
}
