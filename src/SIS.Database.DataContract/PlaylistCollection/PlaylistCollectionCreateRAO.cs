using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.PlaylistCollection
{
    public class PlaylistCollectionCreateRAO
    {
        public int OwnerId { get; set; }
        public int SongId { get; set; }
        public int PlaylistId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
