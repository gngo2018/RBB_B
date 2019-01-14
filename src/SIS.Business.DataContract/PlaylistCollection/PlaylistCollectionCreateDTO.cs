using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.PlaylistCollection
{
    public class PlaylistCollectionCreateDTO
    {
        public int OwnerId { get; set; }
        public int SongEntityId { get; set; }
        public int PlaylistEntityId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
