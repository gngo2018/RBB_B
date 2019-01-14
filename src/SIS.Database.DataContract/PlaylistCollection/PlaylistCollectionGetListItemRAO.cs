using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.PlaylistCollection
{
    public class PlaylistCollectionGetListItemRAO
    {
        public int PlaylistCollectionEntityId { get; set; }
        public int OwnerId { get; set; }
        public int PlaylistEntityId { get; set; }
        public int SongEntityId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
