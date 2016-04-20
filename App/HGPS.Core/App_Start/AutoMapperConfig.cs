using System.Linq;
using HGPS.Data.ModelsEF;

namespace HGPS.Core
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // --------------------------------------------------------
            // TO MODEL OBJECTS
            // --------------------------------------------------------

            //AutoMapper.Mapper.CreateMap<ActivityLog, ActivityLogModel>()
            //    .ForMember(dest => dest.DateOccurred, opts => opts.MapFrom(src => src.DateOccurred.ToString("MM/dd/yyyy")));

            //AutoMapper.Mapper


            // --------------------------------------------------------
            // TO DATABASE OBJECTS
            // --------------------------------------------------------



        }

    }
}