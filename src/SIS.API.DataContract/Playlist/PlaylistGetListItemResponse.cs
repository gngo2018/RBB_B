using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Playlist
{
    public class PlaylistGetListItemResponse
    {
        public int PlaylistEntityId { get; set; }
        public int OwnerId { get; set; }
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }

    }
}
