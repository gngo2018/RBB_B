using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Playlist
{
    public class PlaylistCreateDTO
    {
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int OwnerId { get; set; }
    }
}
