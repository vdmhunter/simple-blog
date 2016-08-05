using System;
using AutoMapper;
using SimpleBlog.Model;
using SimpleBlog.WebApp.ViewModels;

namespace SimpleBlog.WebApp.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        [Obsolete]
        protected override void Configure()
        {
            CreateMap<PostViewModel, Post>();
            CreateMap<CommentViewModel, Comment>();
        }
    }
}