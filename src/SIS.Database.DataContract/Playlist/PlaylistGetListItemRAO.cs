using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Playlist
{
    public class PlaylistGetListItemRAO
    {
        public int PlaylistEntityId { get; set; }
        public int OwnerId { get; set; }
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
