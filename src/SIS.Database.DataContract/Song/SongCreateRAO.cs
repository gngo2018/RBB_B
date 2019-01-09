using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Song
{
    public class SongCreateRAO
    {
        public int OwnerId { get; set; }
        public int GoogleId { get; set; }
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string SongGenre { get; set; }
        public string SongLength { get; set; }
        public string SongAlbum { get; set; }
    }
}
