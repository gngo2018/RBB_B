using AutoMapper;
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
    }
}
