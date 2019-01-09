using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Playlist
{
    public interface IPlaylistRepository
    {
        Task<bool> CreatePlaylist(PlaylistCreateRAO rao);
        Task<IEnumerable<PlaylistGetListItemRAO>> GetPlaylists();
    }
}
