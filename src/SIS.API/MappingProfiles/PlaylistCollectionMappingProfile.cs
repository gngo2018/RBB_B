using AutoMapper;
using RedStarter.API.DataContract.PlaylistCollection;
using RedStarter.Business.DataContract.PlaylistCollection;
using RedStarter.Database.DataContract.PlaylistCollection;
using RedStarter.Database.Entities.PlaylistCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class PlaylistCollectionMappingProfile: Profile
    {
        public PlaylistCollectionMappingProfile()
        {
            CreateMap<PlaylistCollectionCreateRequest, PlaylistCollectionCreateDTO>();
            CreateMap<PlaylistCollectionCreateDTO, PlaylistCollectionCreateRAO>();
            CreateMap<PlaylistCollectionCreateRAO, PlaylistCollectionEntity>();
        }
    }
}
