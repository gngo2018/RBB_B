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
        public int PlaylistId { get; set; }
        [Required]
        public int SongId { get; set; }
    }
}
