using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Song
{
    public class SongGetListItemDTO
    {
        public int SongEntityId { get; set; }
        public int OwnerId { get; set; }
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string SongLength { get; set; }
        public string SongAlbum { get; set; }
        public string SongGenre { get; set; }
        public string UploadedLink { get; set; }
    }
}
