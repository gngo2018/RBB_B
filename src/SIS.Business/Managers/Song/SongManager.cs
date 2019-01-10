using AutoMapper;
using RedStarter.Business.DataContract.Song;
using RedStarter.Business.Engines.Song;
using RedStarter.Database.DataContract.Song;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Song
{
    public class SongManager : ISongManager
    {
        private readonly IMapper _mapper;
        private readonly ISongRepository _repository;

        public SongManager(IMapper mapper, ISongRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateSong(SongCreateDTO dto)
        {
            var rao = _mapper.Map<SongCreateRAO>(dto);
            var engine = new SaveFileEngine();
            var uri = engine.Upload(dto.UploadedFile);
            rao.UploadedLink = uri;

            if (await _repository.CreateSong(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SongGetListItemDTO>> GetSongs()
        {
            var rao = await _repository.GetSongs();
            var dto = _mapper.Map<IEnumerable<SongGetListItemDTO>>(rao);

            return dto;
        }
        public async Task<SongGetListItemDTO> GetSongById(int id)
        {
            var rao = await _repository.GetSongById(id);
            var dto = _mapper.Map<SongGetListItemDTO>(rao);

            return dto;
        }

        public async Task<bool> UpdateSong(SongUpdateDTO dto)
        {
            var rao = _mapper.Map<SongUpdateRAO>(dto);
            var engine = new SaveFileEngine();
            var uri = engine.Upload(dto.UploadedFile);
            rao.UploadedLink = uri;

            if (await _repository.UpdateSong(rao))
                return true;

            throw new NotImplementedException();

        }

        public async Task<bool> DeleteSong(int id)
        {
            if (await _repository.DeleteSong(id))
                return true;
            throw new NotImplementedException();
        }
    }
}
