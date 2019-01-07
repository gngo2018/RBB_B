using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Playlist
{
    public class PlaylistCreateDTO
    {
        public int SongId { get; set; }
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
