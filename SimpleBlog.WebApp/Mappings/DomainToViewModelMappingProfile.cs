using System;
using AutoMapper;
using SimpleBlog.Model;

namespace SimpleBlog.WebApp.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        [Obsolete]
        protected override void Configure()
        {
            //CreateMap<RegisteredUser, ManageUsersViewModel>()
            //    .ForMember(vm => vm.Id, map => map.MapFrom(ru => ru.Id))
            //    .ForMember(vm => vm.FirstName, map => map.MapFrom(ru => ru.FirstName))
            //    .ForMember(vm => vm.LastName, map => map.MapFrom(ru => ru.LastName))
            //    .ForMember(vm => vm.Login, map => map.MapFrom(ru => ru.Login))
            //    .ForMember(vm => vm.Roles, map => map.MapFrom(ru => ru.Roles));
        }
    }
}