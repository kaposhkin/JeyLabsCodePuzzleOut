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
	public class HeptagonParserTests
	{
		[TestMethod]
		public void ShouldParseHexagonCommand()
		{
			// Arrange
			string inputStrig = "Draw a heptagon with a side length of 270";

			// Act
			var parser = new HeptagonParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(7, points.Count);
			Assert.IsTrue(TestsHelper.CheckDistance(points[0], points[1], 270, 1));
		}
	}
}
