using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Playlist
{
    public class PlaylistEntity
    {
        [Key]
        public int PlaylistEntityId { get; set; }

        public int SongId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string PlaylistName { get; set; }

        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
