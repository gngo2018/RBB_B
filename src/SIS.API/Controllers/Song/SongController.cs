using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Song;
using RedStarter.Business.DataContract.Song;

namespace RedStarter.API.Controllers.Song
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISongManager _manager;

        public SongController(IMapper mapper, ISongManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostSong([FromForm]SongCreateRequest request)
        {
            //if (request.UploadedFile.ContentType != "audio/wave")
            //{
            //    return BadRequest("Wrong file type");
            //}

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<SongCreateDTO>(request);
            dto.OwnerId = identityClaimNum;

            if (await _manager.CreateSong(dto))
                return StatusCode(201);

            throw new Exception();
        }

        //GET All Songs
        [HttpGet]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetSongs()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetSongs();
            var response = _mapper.Map<IEnumerable<SongGetListItemResponse>>(dto);

            return Ok(response); //Handle Exceptions
        }

        //GET Song Detail
        [HttpGet("{id}")]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetSongById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetSongById(id);
            var response = _mapper.Map<SongGetListItemResponse>(dto);

            return Ok(response);
        }

        //PUT Song Update
        [HttpPut]
        public async Task<IActionResult> UpdateSong([FromForm]SongUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<SongUpdateDTO>(request);

            if (await _manager.UpdateSong(dto))
                return StatusCode(202);

            throw new Exception();
        }

        //POST Playlist Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSong(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            if (await _manager.DeleteSong(id))
                return StatusCode(207);

            throw new Exception();
        }
    }
}