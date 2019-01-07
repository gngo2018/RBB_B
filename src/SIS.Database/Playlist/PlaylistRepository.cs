using RedStarter.Database.DataContract.Playlist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Playlist
{
    public class PlaylistRepository : IPlaylistRepository
    {
        public Task<bool> CreatePlaylist(PlaylistCreateRAO rao)
        {
            throw new NotImplementedException();
        }
    }
}
