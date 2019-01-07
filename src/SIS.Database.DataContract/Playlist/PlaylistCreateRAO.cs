using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Playlist
{
    public class PlaylistCreateRAO
    {
        public int SongId { get; set; }
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
