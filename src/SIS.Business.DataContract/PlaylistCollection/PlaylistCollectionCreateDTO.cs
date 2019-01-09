using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.PlaylistCollection
{
    public class PlaylistCollectionCreateDTO
    {
        public int OwnerId { get; set; }
        public int SongId { get; set; }
        public int PlaylistId { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}
