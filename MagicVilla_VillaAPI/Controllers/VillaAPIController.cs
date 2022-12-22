using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]  //can use api/[controller] here instead
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO> 
            {
                new VillaDTO {Id=1, Name="Pool View"},
                new VillaDTO {Id=2, Name="Beach View"}
            };
        }
    }
}
