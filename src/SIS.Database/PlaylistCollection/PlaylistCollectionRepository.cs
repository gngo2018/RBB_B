using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.PlaylistCollection;
using RedStarter.Database.DataContract.Song;
using RedStarter.Database.Entities.PlaylistCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.PlaylistCollection
{
    public class PlaylistCollectionRepository : IPlaylistCollectionRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PlaylistCollectionRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<bool> CreatePlaylistCollection(PlaylistCollectionCreateRAO rao)
        {
            var entity = _mapper.Map<PlaylistCollectionEntity>(rao);

            await _context.PlaylistCollectionTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<PlaylistCollectionGetListItemRAO>> GetPlaylistCollections()
        {
            var query = await _context.PlaylistCollectionTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<PlaylistCollectionGetListItemRAO>>(query);

            return rao;
        }

        public async Task<IEnumerable<SongGetListItemRAO>> GetPlaylistCollectionById(int id)
        {
            var query = await _context.PlaylistCollectionTableAccess.Where(e => e.PlaylistEntityId == id).ToArrayAsync();
            var songs = new List<SongGetListItemRAO>();
            foreach (PlaylistCollectionEntity entity in query)
            {
                var activeQuery = await _context.SongTableAccess.SingleOrDefaultAsync(e => e.SongEntityId == entity.SongEntityId);
                songs.Add(_mapper.Map<SongGetListItemRAO>(activeQuery));
            }

            return songs;
        }
    }
}
