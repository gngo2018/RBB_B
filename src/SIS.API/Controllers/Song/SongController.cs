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
        public async Task<IActionResult> PostSong(SongCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<SongCreateDTO>(request);
            dto.OwnerId = identityClaimNum;

            if (await _manager.CreateSong(dto))
                return StatusCode(201);

            throw new Exception();
        }
    }
}