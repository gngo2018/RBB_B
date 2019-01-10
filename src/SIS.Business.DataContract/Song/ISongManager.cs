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
        Task<SongGetListItemDTO> GetSongById(int id);
        Task<bool> UpdateSong(SongUpdateDTO dto);
        Task<bool> DeleteSong(int id);





    }
}
