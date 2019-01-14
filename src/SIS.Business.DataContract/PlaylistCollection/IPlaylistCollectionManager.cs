using RedStarter.Business.DataContract.Song;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.PlaylistCollection
{
    public interface IPlaylistCollectionManager
    {
        Task<bool> CreatePlaylistCollection(PlaylistCollectionCreateDTO dto);
        Task<IEnumerable<PlaylistCollectionGetListItemDTO>> GetPlaylistCollections();
        Task<IEnumerable<SongGetListItemDTO>> GetPlaylistCollectionById(int id);
        Task<bool> DeletePlaylistCollection(int id);

    }
}
