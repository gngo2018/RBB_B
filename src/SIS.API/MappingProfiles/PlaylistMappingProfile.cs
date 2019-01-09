using AutoMapper;
using RedStarter.API.DataContract.Playlist;
using RedStarter.Business.DataContract.Playlist;
using RedStarter.Database.Contexts.Playlist;
using RedStarter.Database.DataContract.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class PlaylistMappingProfile : Profile 
    {
        public PlaylistMappingProfile()
        {
            CreateMap<PlaylistCreateRequest, PlaylistCreateDTO>();
            CreateMap<PlaylistCreateDTO, PlaylistCreateRAO>();
            CreateMap<PlaylistCreateRAO, PlaylistEntity>();

            CreateMap<PlaylistEntity, PlaylistGetListItemRAO>();
            CreateMap<PlaylistGetListItemRAO, PlaylistGetListItemDTO>();
            CreateMap<PlaylistGetListItemDTO, PlaylistGetListItemResponse>();
        }
    }
}
