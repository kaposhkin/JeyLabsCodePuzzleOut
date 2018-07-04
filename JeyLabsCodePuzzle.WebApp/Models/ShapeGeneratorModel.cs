using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JeyLabsCodePuzzle.Domain2.Shapes;

namespace JeyLabsCodePuzzle.WebApp.Models
{
	public class ShapeGeneratorModel
	{
		[Required]
		public string Command { get; set; }

		public IShape Shape { get; set; }
	}
}
