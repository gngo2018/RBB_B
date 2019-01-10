using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.PlaylistCollection
{
    public class PlaylistCollectionCreateRequest
    {
        public int SongEntityId { get; set; }
        public int PlaylistEntityId { get; set; }
    }
}
