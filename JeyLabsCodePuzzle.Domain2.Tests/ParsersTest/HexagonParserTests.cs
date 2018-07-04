using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class HexagonParserTests
	{
		[TestMethod]
		public void ShouldParseHexagonCommand()
		{
			// Arrange
			string inputStrig = "Draw a hexagon with a side length of 220";

			// Act
			var parser = new HexagonParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(6, points.Count);
			Assert.IsTrue(TestsHelper.CheckDistance(points[0], points[1], 220, 1));
		}
	}
}
