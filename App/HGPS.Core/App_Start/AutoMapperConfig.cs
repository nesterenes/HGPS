using System.Linq;
using HGPS.Data.ModelsEF;
using HGPS.Core.Models;

namespace HGPS.Core
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // --------------------------------------------------------
            // TO MODEL OBJECTS
            // --------------------------------------------------------

            AutoMapper.Mapper.CreateMap<Location, LocationModel>();
            AutoMapper.Mapper.CreateMap<Customer, CustomerModel>();

            //AutoMapper.Mapper.CreateMap<ActivityLog, ActivityLogModel>()
            //    .ForMember(dest => dest.DateOccurred, opts => opts.MapFrom(src => src.DateOccurred.ToString("MM/dd/yyyy")));

            //AutoMapper.Mapper


            // --------------------------------------------------------
            // TO DATABASE OBJECTS
            // --------------------------------------------------------



        }

    }
}