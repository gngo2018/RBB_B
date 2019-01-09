using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Playlist
{
    public class PlaylistCreateRAO
    {
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int OwnerId { get; set; }
    }
}
