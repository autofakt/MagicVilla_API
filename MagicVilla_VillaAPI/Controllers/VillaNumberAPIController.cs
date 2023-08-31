using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaNumberAPI")]  //can use api/[controller] here instead
    [ApiController]
    public class VillaNumberAPIController : ControllerBase
    {
        private readonly ILogger<VillaNumberAPIController> _logger;
        //public VillaAPIController(ILogger<VillaAPIController> logger)
        //{
        //    _logger = logger;
        //}

        //private readonly ILogging _logger;
        //public VillaAPIController(ILogging logger)
        //{
        //    _logger = logger;
        //}

        protected APIResponse _response;
        private readonly IVillaNumberRepository _repo;
        private readonly IVillaRepository _repoVilla;
        private readonly IMapper _mapper;

        public VillaNumberAPIController(ILogger<VillaNumberAPIController> logger, IVillaNumberRepository repo, IMapper mapper, IVillaRepository repoVilla)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
            _response = new APIResponse();
            _repoVilla = repoVilla;
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetVillaNumbers()
        {
            _logger.LogInformation("Getting All VillaNumbers");
            //_logger.Log("Getting All Villas", "");     custom logger
            try
            {
                IEnumerable<VillaNumber> villaNumberList = await _repo.GetAllAsync();
                var villaNumberDTOList = _mapper.Map<List<VillaNumberDTO>>(villaNumberList);
                _response.StatusCode = System.Net.HttpStatusCode.OK;
                _response.Result = villaNumberDTOList;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{villaNum:int}", Name = "GetVillaNumber")]
        //[ProducesResponseType(200)]  //[ProducesResponseType(200), Type=typeof(VillaDTO))] --> Able to add type for schema
        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int villaNum)
        {
            try
            {
                if (villaNum == 0)
                {
                    //_logger.LogError("Get Villa Error with Id" + id);
                    //_logger.Log("Get Villa Error with Id: " + id, "error");  custom logger
                    _response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest();
                }

                //var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
                var villaNumber = await _repo.GetAsync(u => u.VillaNum == villaNum);
                if (villaNumber == null)
                {
                    _response.StatusCode = System.Net.HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    return NotFound();
                }

                _response.StatusCode = System.Net.HttpStatusCode.OK;
                _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDTO villaNumberCreateDTO)
        {
            try
            {
                //await _db.Villas.FirstOrDefaultAsync(u => u.Name.ToLower() == villaCreateDTO.Name.ToLower()) != null
                if (await _repo.GetAsync(u => u.VillaNum == villaNumberCreateDTO.VillaNum) != null)
                {
                    ModelState.AddModelError("", "VillaNumber already Exists!");
                }

                if (villaNumberCreateDTO == null)
                {
                    return BadRequest(villaNumberCreateDTO);
                }

                if (await _repoVilla.GetAsync(u => u.Id == villaNumberCreateDTO.VillaID) == null)
                {
                    ModelState.AddModelError("CustomError", "VillaId doesnt Exists!");
                    return BadRequest(ModelState);
                }

                VillaNumber model = _mapper.Map<VillaNumber>(villaNumberCreateDTO);
                //await _db.Villas.AddAsync(model);
                //await _db.SaveChangesAsync();
                await _repo.CreateAsync(model);

                //return Ok(villaDTO);
                _response.StatusCode = System.Net.HttpStatusCode.OK;
                _response.Result = model;
                return CreatedAtRoute("GetVillaNumber", new { villaNum = model.VillaNum}, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{villaNum:int}", Name = "DeleteVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> DeleteVilla(int villaNum)
        {
            try
            {
                if (villaNum == 0)
                {
                    return BadRequest();
                }

                // var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
                var villaNumber = await _repo.GetAsync(u => u.VillaNum == villaNum);

                if (villaNumber == null)
                {
                    return NotFound();
                }

                //_db.Villas.Remove(villa);
                //await _db.SaveChangesAsync();
                await _repo.RemoveAsync(villaNumber);
                var villaNumberDTO = _mapper.Map<VillaNumberDTO>(villaNumber);

                _response.StatusCode = System.Net.HttpStatusCode.OK;
                _response.Result = villaNumberDTO;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;

        }

        [HttpPut("{villaNum:int}", Name = "UpdateVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVillaNumber(int villaNum, [FromBody] VillaNumberUpdateDTO villaNumberUpdateDTO)
        {
            try
            {
                if (villaNumberUpdateDTO == null || villaNum != villaNumberUpdateDTO.VillaNum)
                {
                    return BadRequest();
                }

                if (await _repoVilla.GetAsync(u => u.Id == villaNumberUpdateDTO.VillaID) == null)
                {
                    ModelState.AddModelError("CustomError", "VillaId doesnt Exists!");
                    return BadRequest(ModelState);
                }

                VillaNumber model = _mapper.Map<VillaNumber>(villaNumberUpdateDTO);

                await _repo.UpdateAsync(model);

                _response.StatusCode = System.Net.HttpStatusCode.OK;
                _response.Result = model;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        //[HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        //{
        //    if (patchDTO == null || id == 0)
        //    {
        //        return BadRequest();
        //    }

        //    //var villa = await _db.Villas.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        //    var villa = await _repo.GetAsync(u => u.Id == id, tracked: false);
        //    if (villa == null)
        //    {
        //        return BadRequest();
        //    }

        //    VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);
        //    patchDTO.ApplyTo(villaDTO, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }

        //    Villa model = _mapper.Map<Villa>(villaDTO);
        //    await _repo.UpdateAsync(model);

        //    return NoContent();
        //}
    }
}
