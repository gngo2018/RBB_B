using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.Contexts.Playlist;
using RedStarter.Database.DataContract.Playlist;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Playlist
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PlaylistRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<bool> CreatePlaylist(PlaylistCreateRAO rao)
        {
            var entity = _mapper.Map<PlaylistEntity>(rao);

            await _context.PlaylistTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<PlaylistGetListItemRAO>> GetPlaylists()
        {
            var query = await _context.PlaylistTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<PlaylistGetListItemRAO>>(query);

            return rao;
        }

        public async Task<PlaylistGetListItemRAO> GetPlaylistById(int id)
        {
            var query = await _context.PlaylistTableAccess.SingleAsync(q => q.PlaylistEntityId == id );
            var rao = _mapper.Map<PlaylistGetListItemRAO>(query);

            return rao;
        }
    }
}
