using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Song
{
    public class SongEntity
    {
        [Key]
        public int SongEntityId { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public string SongTitle { get; set; }
        [Required]
        public string SongArtist { get; set; }
        public string SongLength { get; set; }
        public string SongAlbum { get; set; }
        public string SongGenre { get; set; }
        public string UploadedLink { get; set; }

    }
}
