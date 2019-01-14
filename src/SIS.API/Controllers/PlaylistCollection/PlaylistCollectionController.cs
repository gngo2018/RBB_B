using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.PlaylistCollection;
using RedStarter.API.DataContract.Song;
using RedStarter.Business.DataContract.PlaylistCollection;

namespace RedStarter.API.Controllers.PlaylistCollection
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistCollectionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPlaylistCollectionManager _manager;

        public PlaylistCollectionController(IMapper mapper, IPlaylistCollectionManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostPlaylistCollection(PlaylistCollectionCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<PlaylistCollectionCreateDTO>(request);
            dto.DateCreated = DateTime.Now;
            dto.OwnerId = identityClaimNum;

            if (await _manager.CreatePlaylistCollection(dto))
                return StatusCode(201);

            throw new Exception();
        }

        //GET All Playlist Collections
        [HttpGet]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetPlaylistCollections()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetPlaylistCollections();
            var response = _mapper.Map<IEnumerable<PlaylistCollectionGetListItemResponse>>(dto);

            return Ok(response); //Handle Exceptions
        }

        //GET Playlist Collection Detail
        [HttpGet("{id}")]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetPlaylistCollectionById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dtos = await _manager.GetPlaylistCollectionById(id);
            var response = _mapper.Map<IEnumerable<SongGetListItemResponse>>(dtos);

            return Ok(response);
        }

        //POST Song Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlaylistCollection(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            if (await _manager.DeletePlaylistCollection(id))
                return StatusCode(207);

            throw new Exception();
        }
    }
}