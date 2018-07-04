using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class SquareParserTests
	{
		[TestMethod]
		public void ShouldParseSquareCommand()
		{
			// Arrange
			string inputStrig = "Draw a square with a side length of 200 and...";

			// Act
			var parser = new SquareParser();
			Square res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			Assert.AreEqual(200, res.SideLength);
		}
	}
}
