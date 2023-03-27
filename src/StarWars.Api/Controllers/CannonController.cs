using Microsoft.AspNetCore.Mvc;
using StarWars.Domain;
using Swashbuckle.AspNetCore.Annotations;

namespace StarWars.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CannonController : ControllerBase
{
    private readonly ICannonLoader _cannonLoader;

    public CannonController(ICannonLoader cannonLoader)
    {
        _cannonLoader = cannonLoader;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get the maximum cannons availables on the peaks area")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    public IActionResult GetNumberOfCannons([FromQuery] IReadOnlyList<uint> heights)
    {
        try
        {
            ValidateInput.Validate(heights);
            int numberCannons = _cannonLoader.GetCannonCount(heights);

            return Ok(numberCannons);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
