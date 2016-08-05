using AutoMapper;

namespace SimpleBlog.WebApp.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}