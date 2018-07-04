using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2
{
	public static class ShapeGeometryCalculator
	{
		/// <summary>
		/// Calculates base points for isosceles triangle
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		public static List<Point> CalcPointsForIsoscelesTriangle(int width, int height)
		{
			List<Point> res = new List<Point>();
			res.Add(new Point(0, height));
			res.Add(new Point(width, height));
			res.Add(new Point(width / 2, 0));

			return res;
		}

		/// <summary>
		/// Calculates base points for scalene triangle
		/// </summary>
		/// <param name="firstSideLength"></param>
		/// <param name="secondSideLength"></param>
		/// <param name="angle"></param>
		/// <returns></returns>
		public static List<Point> CalcPointsForScaleneTriangle(int firstSideLength, int secondSideLength, int angle)
		{
			List<Point> res = new List<Point>();

			int x = Convert.ToInt32(firstSideLength * Math.Cos(DegreeToRadian(angle)));
			int y = Convert.ToInt32(firstSideLength * Math.Sin(DegreeToRadian(angle)));
			int dx = (x < 0) ? -x : 0;
			int dy = (y < 0) ? -y : 0;

			res.Add(new Point(dx, y + dy));
			res.Add(new Point(secondSideLength + dx, y + dy));
			res.Add(new Point(x + dx, dy));

			return res;
		}

		/// <summary>
		/// Calculates base points for equilateral triangle
		/// </summary>
		/// <param name="sideLength"></param>
		/// <returns></returns>
		public static List<Point> CalcPointsForEquilateralTriangle(int sideLength)
		{
			return CalcPointsForScaleneTriangle(sideLength, sideLength, 60);
		}

		/// <summary>
		/// Calculates base points for regular poligon
		/// </summary>
		/// <param name="numberOfSides"></param>
		/// <param name="sideLength"></param>
		/// <returns></returns>
		public static List<Point> CalcPointsForRegularPoligon(int numberOfSides, int sideLength)
		{
			List<Point> res = new List<Point>();

			double radius = ((double)sideLength / 2) / (Math.Sin(Math.PI / numberOfSides));

			int delta = Convert.ToInt32(Math.Ceiling(radius));
			for (int k = 0; k < numberOfSides; k++)
			{
				int x = Convert.ToInt32(radius * Math.Cos((double)2 * k * Math.PI / numberOfSides));
				int y = Convert.ToInt32(radius * Math.Sin((double)2 * k * Math.PI / numberOfSides));
				res.Add(new Point(delta + x, delta + y));
			}

			return res;
		}

		/// <summary>
		/// Calculates base points for parallelogram
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="angle"></param>
		/// <returns></returns>
		public static List<Point> CalcPointsForParallelogram(int width, int height, int angle)
		{
			List<Point> res = new List<Point>();

			int x = Convert.ToInt32((double)height / Math.Tan(DegreeToRadian(angle)));
			int dx = (x < 0) ? -x : 0;

			res.Add(new Point(dx, height));
			res.Add(new Point(dx + x, 0));
			res.Add(new Point(dx + x + width, 0));
			res.Add(new Point(dx + width, height));

			return res;
		}

		/// <summary>
		/// Converts angle from degree to radian
		/// </summary>
		/// <param name="angle"></param>
		/// <returns></returns>
		private static double DegreeToRadian(double angle)
		{
			return Math.PI * angle / 180.0;
		}
	}
}
