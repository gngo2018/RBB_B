using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Playlist;

namespace RedStarter.API.Controllers.Playlist
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> PostNote(PlaylistCreateRequest request)
        {

            return Ok();
        }
    }
}