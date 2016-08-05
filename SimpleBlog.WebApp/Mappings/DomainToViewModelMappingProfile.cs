using System;
using AutoMapper;
using SimpleBlog.Model;
using SimpleBlog.WebApp.ViewModels;

namespace SimpleBlog.WebApp.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        [Obsolete]
        protected override void Configure()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<Comment, CommentViewModel>();
        }
    }
}