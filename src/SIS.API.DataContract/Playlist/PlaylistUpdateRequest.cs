using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Playlist
{
    public class PlaylistUpdateRequest
    {
        public int PlaylistEntityId { get; set; }
        public string PlaylistName { get; set; }
    }
}
