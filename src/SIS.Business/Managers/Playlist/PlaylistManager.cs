using AutoMapper;
using RedStarter.Business.DataContract.Playlist;
using RedStarter.Database.DataContract.Playlist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Playlist
{
    public class PlaylistManager : IPlaylistManager
    {
        private readonly IMapper _mapper;
        private readonly IPlaylistRepository _repository;

        public PlaylistManager(IMapper mapper, IPlaylistRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public async Task<bool> CreatePlaylist(PlaylistCreateDTO dto)
        {
            var rao = _mapper.Map<PlaylistCreateRAO>(dto);

            if (await _repository.CreatePlaylist(rao))
                return true;

            throw new NotImplementedException();
        }


        public async Task<IEnumerable<PlaylistGetListItemDTO>> GetPlaylists()
        {
            var rao = await _repository.GetPlaylists();
            var dto = _mapper.Map<IEnumerable<PlaylistGetListItemDTO>>(rao);

            return dto;
        }
        public async Task<PlaylistGetListItemDTO> GetPlaylistById(int id)
        {
            var rao = await _repository.GetPlaylistById(id);
            var dto = _mapper.Map<PlaylistGetListItemDTO>(rao);

            return dto;
        }

        public async Task<bool> DeletePlaylist(int id)
        {
            if (await _repository.DeletePlaylist(id))
                return true;
            throw new NotImplementedException();
        }
    }
}
