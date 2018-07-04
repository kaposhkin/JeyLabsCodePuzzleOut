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
	public class IsoscelesTriangleParserTests
	{
		[TestMethod]
		public void ShouldParseIsoscelesTriangleCommand()
		{
			// Arrange
			string inputStrig = "Draw an isosceles triangle with a height of 200 and a width of 100";

			// Act
			var parser = new IsoscelesTriangleParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(3, points.Count);
			CollectionAssert.Contains(points, new Point(0, 200));
			CollectionAssert.Contains(points, new Point(100, 200));
			CollectionAssert.Contains(points, new Point(50, 0));
		}
	}
}
