using System;
using System.Collections.Generic;
using System.Text;
using JeyLabsCodePuzzle.Domain2.Parsers;
using JeyLabsCodePuzzle.Domain2.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JeyLabsCodePuzzle.Domain2.Tests.ParsersTest
{
	[TestClass]
	public class CircleParserTests
	{
		[TestMethod]
		public void ShouldParseCirleCommand()
		{
			// Arrange
			string inputStrig = "Draw a circle with a radius of 100, ";

			// Act
			var parser = new CircleParser();
			Circle res = parser.Parse(inputStrig);

			// Assert
			Assert.IsNotNull(res);
			Assert.AreEqual(100, res.Radius);
		}
	}
}
