﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Song
{
    public interface ISongRepository
    {
        Task<bool> CreateSong(SongCreateRAO rao);
    }
}