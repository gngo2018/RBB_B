using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.PlaylistCollection
{
    public class PlaylistCollectionEntity
    {
        [Key]
        public int PlaylistCollectionEntityId { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public int PlaylistEntityId { get; set; }
        [Required]
        public int SongEntityId { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
