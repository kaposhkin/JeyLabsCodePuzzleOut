using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class OvalParserTests
	{
		[TestMethod]
		public void ShouldParseSquareCommand()
		{
			// Arrange
			string inputStrig = "Draw an oval with an x-axis radius of 50 and a y-axis radius of 170";

			// Act
			var parser = new OvalParser();
			Oval res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			Assert.AreEqual(50, res.XRadius);
			Assert.AreEqual(170, res.YRadius);
		}
	}
}
