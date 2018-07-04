using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Tests
{
	class TestsHelper
	{
		public static bool CheckDistance(Point p1, Point p2, int expectedValue, int roundingError)
		{
			double distane = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
			return distane >= expectedValue - roundingError && distane <= expectedValue + roundingError;
		}
	}
}
