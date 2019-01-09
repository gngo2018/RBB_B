using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Playlist;
using RedStarter.Business.DataContract.Playlist;

namespace RedStarter.API.Controllers.Playlist
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPlaylistManager _manager;

        public PlaylistController(IMapper mapper, IPlaylistManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }
        //POST Create Playlist
        [HttpPost]
        public async Task<IActionResult> PostPlaylist(PlaylistCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<PlaylistCreateDTO>(request);
            dto.DateCreated = DateTime.Now;
            dto.OwnerId = GetUser();

            if (await _manager.CreatePlaylist(dto))
                return StatusCode(201);

            throw new Exception();
        }
        //GET All Playlists
        [HttpGet]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetPlaylists()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetPlaylists();
            var response = _mapper.Map<IEnumerable<PlaylistGetListItemResponse>>(dto);

            return Ok(response); //Handle Exceptions
        }

        //GET Playlist Detail
        [HttpGet("{id}")]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetPlaylistById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetPlaylistById(id);
            var response = _mapper.Map<PlaylistGetListItemResponse>(dto);

            return Ok(response);
        }

        private int GetUser()
        {
            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return identityClaimNum;
        }
    }
}