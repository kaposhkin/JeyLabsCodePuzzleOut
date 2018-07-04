using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class OctagonParserTests
	{
		[TestMethod]
		public void ShouldParseHexagonCommand()
		{
			// Arrange
			string inputStrig = "Draw an octagon with a side length of 400";

			// Act
			var parser = new OctagonParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(8, points.Count);
			Assert.IsTrue(TestsHelper.CheckDistance(points[0], points[1], 400, 1));
		}
	}
}
