using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Song
{
    public interface ISongManager
    {
        Task<bool> CreateSong(SongCreateDTO dto);
        Task<IEnumerable<SongGetListItemDTO>> GetSongs();


    }
}
