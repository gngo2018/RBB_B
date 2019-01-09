using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Contexts.Playlist
{
    public class PlaylistEntity
    {
        [Key]
        public int PlaylistEntityId { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        public string PlaylistName { get; set; }

        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
