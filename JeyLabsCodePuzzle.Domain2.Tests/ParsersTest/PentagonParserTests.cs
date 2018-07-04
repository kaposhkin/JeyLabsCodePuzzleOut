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
	public class PentagonParserTests
	{
		[TestMethod]
		public void ShouldParsePentagonCommand()
		{
			// Arrange
			string inputStrig = "Draw a pentagon with a side length of 350";

			// Act
			var parser = new PentagonParser();
			Polygon res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			var points = res.Points.ToList();
			Assert.AreEqual(5, points.Count);
			Assert.IsTrue(TestsHelper.CheckDistance(points[0], points[1], 350, 1));
		}
	}
}
