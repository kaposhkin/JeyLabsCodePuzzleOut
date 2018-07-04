using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class ParallelogramParserTests
	{
		[TestMethod]
		public void ShouldParseHexagonCommand()
		{
			// Arrange
			string inputStrig = "Draw a parallelogram with a width of 250 and a height of 150 and an angle of 30 degrees.";

			// Act
			var parser = new ParallelogramParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(4, points.Count);
		}
	}
}
