using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsProject.Model.Domain;
using NewsProject.Model.ViewModel;

namespace NewsProject.Converter
{

    public static class NewsConverter
    {
        //TODO: Make a generic converter an implamentation later.
        public static News ConvertToDomainModel(NewsProject.Data.EntityFramework.Entity.News news)
        {
            return new News
            {
                Id = news.Id,
                LastUpdatedTime = news.LastUpdatedTime,
                Title = news.Title
            };
        }

        public static NewsProject.Data.EntityFramework.Entity.News ConvertToEntity(News news)
        {
            return new NewsProject.Data.EntityFramework.Entity.News
            {
                Id = news.Id,
                LastUpdatedTime = news.LastUpdatedTime,
                Title = news.Title
            };
        }

        public static NewsViewModel ConvertToViewModel(News news)
        {
            return new NewsViewModel
            {
                Id = news.Id,
                LastUpdatedTime = news.LastUpdatedTime,
                Title = news.Title
            };
        }

    }
}


