using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Song
{
    public interface ISongRepository
    {
        Task<bool> CreateSong(SongCreateRAO rao);
        Task<IEnumerable<SongGetListItemRAO>> GetSongs();
        Task<SongGetListItemRAO> GetSongById(int id);
        Task<bool> UpdateSong(SongUpdateRAO rao);

    }
}
