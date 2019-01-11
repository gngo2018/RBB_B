using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.PlaylistCollection
{
    public interface IPlaylistCollectionRepository
    {
        Task<bool> CreatePlaylistCollection(PlaylistCollectionCreateRAO rao);
        Task<IEnumerable<PlaylistCollectionGetListItemRAO>> GetPlaylistCollections();
        Task<PlaylistCollectionGetListItemRAO> GetPlaylistCollectionById(int id);


    }
}
