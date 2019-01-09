﻿using AutoMapper;
using RedStarter.Business.DataContract.PlaylistCollection;
using RedStarter.Database.DataContract.PlaylistCollection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.PlaylistCollection
{
    public class PlaylistCollectionManager : IPlaylistCollectionManager
    {
        private readonly IMapper _mapper;
        private readonly IPlaylistCollectionRepository _repository;

        public PlaylistCollectionManager(IMapper mapper, IPlaylistCollectionRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreatePlaylistCollection(PlaylistCollectionCreateDTO dto)
        {
            var rao = _mapper.Map<PlaylistCollectionCreateRAO>(dto);

            if (await _repository.CreatePlaylistCollection(rao))
                return true;

            throw new NotImplementedException();
        }


    }
}