using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class RectangleParserTests
	{
		[TestMethod]
		public void ShouldParseRectangleCommand()
		{
			// Arrange
			string inputStrig = "Draw a rectangle  with a width of 250 and a height of 400.";

			// Act
			var parser = new RectangleParser();
			Rectangle res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			Assert.AreEqual(250, res.Width);
			Assert.AreEqual(400, res.Height);
		}
	}
}
