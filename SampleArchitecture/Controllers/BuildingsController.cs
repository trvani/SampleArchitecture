using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SampleArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : Controller
    {
        private readonly IBuildingService _buildingService;
        public BuildingsController(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }
        [HttpGet]
        public IActionResult GetAllBuildings()
        {
            var buildings = _buildingService.GetBuildings();
            return Ok(buildings);
        }
    }
}
