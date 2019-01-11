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

    }
}
