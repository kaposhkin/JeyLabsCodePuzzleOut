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
	public class EquilateralTriangleParserTests
	{
		[TestMethod]
		public void ShouldParseEquilateralTriangleCommand()
		{
			// Arrange
			string inputStrig = "Draw an equilateral triangle with a side length of 200";

			// Act
			var parser = new EquilateralTriangleParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(3, points.Count);
			CollectionAssert.Contains(points, new Point(0, 173));
			CollectionAssert.Contains(points, new Point(200, 173));
			CollectionAssert.Contains(points, new Point(100, 0));
		}
	}
}
