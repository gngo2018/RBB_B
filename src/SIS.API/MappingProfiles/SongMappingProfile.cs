using AutoMapper;
using RedStarter.API.DataContract.Song;
using RedStarter.Business.DataContract.Song;
using RedStarter.Database.DataContract.Song;
using RedStarter.Database.Entities.Song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class SongMappingProfile : Profile
    {
        public SongMappingProfile()
        {
            CreateMap<SongCreateRequest, SongCreateDTO>();
            CreateMap<SongCreateDTO, SongCreateRAO>();
            CreateMap<SongCreateRAO, SongEntity>();

            CreateMap<SongEntity, SongGetListItemRAO>();
            CreateMap<SongGetListItemRAO, SongGetListItemDTO>();
            CreateMap<SongGetListItemDTO, SongGetListItemResponse>();

            CreateMap<SongUpdateRequest, SongUpdateDTO>();
            CreateMap<SongUpdateDTO, SongUpdateRAO>();
            CreateMap<SongUpdateRAO, SongEntity>();

        }
    }
}
