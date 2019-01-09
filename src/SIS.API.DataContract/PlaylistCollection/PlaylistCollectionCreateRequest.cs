using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.PlaylistCollection
{
    public class PlaylistCollectionCreateRequest
    {
        public int SongId { get; set; }
        public int PlaylistId { get; set; }
    }
}
