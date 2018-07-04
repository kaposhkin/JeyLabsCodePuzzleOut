using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeyLabsCodePuzzle.Domain2;
using Microsoft.AspNetCore.Mvc;

namespace JeyLabsCodePuzzle.WebApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShapeGeneratorController : ControllerBase
	{
		private readonly IShapeGenerator shapeGenerator;

		public ShapeGeneratorController(IShapeGenerator shapeGenerator)
		{
			this.shapeGenerator = shapeGenerator;
		}

		[HttpGet("{command}")]
		public IActionResult Get(string command)
		{
			if (string.IsNullOrEmpty(command))
				return BadRequest("The command was empty");

			var shape = shapeGenerator.ParseCommand(command);

			if (shape == null)
				return BadRequest("Failed to understand the command");

			return Ok(shape);
		}
	}
}