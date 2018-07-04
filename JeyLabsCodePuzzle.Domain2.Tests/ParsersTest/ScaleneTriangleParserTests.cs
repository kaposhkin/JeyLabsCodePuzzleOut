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
	public class ScaleneTriangleParserTests
	{
		[TestMethod]
		public void ShouldParseScaleneTriangleCommand()
		{
			// Arrange
			string inputStrig = "Draw a scalene triangle with a first side length of 300 and a second side length of 200 and an angle of 30 degrees";

			// Act
			var parser = new ScaleneTriangleParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(3, points.Count);
			CollectionAssert.Contains(points, new Point(0, 150));
			CollectionAssert.Contains(points, new Point(200, 150));
			CollectionAssert.Contains(points, new Point(260, 0));
		}
	}
}
