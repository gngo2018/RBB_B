using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Song;
using RedStarter.Database.Entities.Song;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Song
{
    public class SongRepository: ISongRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public SongRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<bool> CreateSong(SongCreateRAO rao)
        {
            var entity = _mapper.Map<SongEntity>(rao);

            await _context.SongTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }


        public async Task<IEnumerable<SongGetListItemRAO>> GetSongs()
        {
            var query = await _context.SongTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<SongGetListItemRAO>>(query);

            return rao;
        }
        public async Task<SongGetListItemRAO> GetSongById(int id)
        {
            var query = await _context.SongTableAccess.SingleAsync(q => q.SongEntityId == id);
            var rao = _mapper.Map<SongGetListItemRAO>(query);

            return rao;
        }
    }
}
