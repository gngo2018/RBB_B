using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Playlist;
using RedStarter.Business.DataContract.Playlist;

namespace RedStarter.API.Controllers.Playlist
{
    [AllowAnonymous]
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

        [HttpPost]
        public async Task<IActionResult> PostNote(PlaylistCreateRequest request)
        {
            var dto = _mapper.Map<PlaylistCreateDTO>(request);
            dto.DateCreated = DateTime.Now;

            await _manager.CreatePlaylist(dto);

            return Ok();
        }
    }
}