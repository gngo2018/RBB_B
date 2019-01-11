using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.PlaylistCollection;
using RedStarter.Database.Entities.PlaylistCollection;
using System;
using System.Collections.Generic;
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

        public async Task<PlaylistCollectionGetListItemRAO> GetPlaylistCollectionById(int id)
        {
            var query = await _context.PlaylistCollectionTableAccess.SingleAsync(q => q.PlaylistCollectionEntityId == id);
            var rao = _mapper.Map<PlaylistCollectionGetListItemRAO>(query);

            return rao;
        }
    }
}
