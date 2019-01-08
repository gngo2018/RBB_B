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
    }
}
