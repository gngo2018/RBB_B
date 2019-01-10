using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Playlist
{
    public class PlaylistGetListItemDTO
    {
        public int PlaylistEntityId { get; set; }
        public int OwnerId { get; set; }
        public string PlaylistName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
