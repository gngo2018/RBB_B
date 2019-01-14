using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.PlaylistCollection
{
    public class PlaylistCollectionGetListItemDTO
    {
        public int PlaylistCollectionEntityId { get; set; }
        public int OwnerId { get; set; }
        public int PlaylistEntityId { get; set; }
        public int SongEntityId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
