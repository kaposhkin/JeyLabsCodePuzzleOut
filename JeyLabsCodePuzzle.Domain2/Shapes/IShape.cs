using System;
using System.Collections.Generic;
using System.Text;

namespace JeyLabsCodePuzzle.Domain2.Shapes
{
	/// <summary>
	/// Interface that should be implemented by all shapes
	/// </summary>
	public interface IShape
	{
		/// <summary>
		/// Needed for API
		/// </summary>
		string Name { get; }
		int Width { get; }
		int Height { get; }
	}
}
