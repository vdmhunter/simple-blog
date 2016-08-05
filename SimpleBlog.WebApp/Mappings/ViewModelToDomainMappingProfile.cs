using AutoMapper;
using SimpleBlog.Model;

namespace SimpleBlog.WebApp.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public ViewModelToDomainMappingProfile()
        {
            //Mapper.Initialize(
            //    cfg => cfg.CreateMap<ManageUsersViewModel, SpotLightUser>()
            //        .ForMember(slu => slu.ApplicationUserId, map => map.MapFrom(vm => vm.Id))
            //        .ForMember(slu => slu.FirstName, map => map.MapFrom(vm => vm.FirstName))
            //        .ForMember(slu => slu.LastName, map => map.MapFrom(vm => vm.LastName))
            //        .ForMember(slu => slu.DomainLogin, map => map.MapFrom(vm => vm.Login))
            //    );
        }
    }
}