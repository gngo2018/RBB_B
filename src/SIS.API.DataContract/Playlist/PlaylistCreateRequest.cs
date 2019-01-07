using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Playlist
{
    public class PlaylistCreateRequest
    {
        public int SongId { get; set; }
        public string PlaylistName { get; set; }
    }
}
