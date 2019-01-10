using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Playlist
{
    public interface IPlaylistManager
    {
        Task<bool> CreatePlaylist(PlaylistCreateDTO dto);
        Task<IEnumerable<PlaylistGetListItemDTO>> GetPlaylists();
        Task <PlaylistGetListItemDTO> GetPlaylistById(int id);
        Task<bool> UpdatePlaylist(PlaylistUpdateDTO dto);
        Task<bool> DeletePlaylist(int id);
    }
}
