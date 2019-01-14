using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.PlaylistCollection
{
    public class PlaylistCollectionGetListItemResponse
    {
        public int PlaylistCollectionEntityId { get; set; }
        public int OwnerId { get; set; }
        public int PlaylistEntityId { get; set; }
        public int SongEntityId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
