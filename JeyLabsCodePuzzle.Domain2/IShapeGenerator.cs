using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.Domain2
{
	/// <summary>
	/// Interface for a Shape Generator
	/// </summary>
	public interface IShapeGenerator
	{
		IShape ParseCommand(string command);
	}
}