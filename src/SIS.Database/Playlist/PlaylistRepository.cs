using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Playlist;
using RedStarter.Database.Entities.Playlist;
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

            _context.PlaylistTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
