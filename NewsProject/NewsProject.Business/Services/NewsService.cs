using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsProject.Converter;
using NewsProject.Core.Cache;
using NewsProject.Model.ViewModel;
using NewsProject.Repository;

namespace NewsProject.Business.Services
{
    public class NewsService : INewsService
    {
        #region INewsService Members
        const string ALLITEMSKEY = "AllNews";
        const string RECENTITEMSKEY = "RecentUpdatedNews";
        public List<NewsViewModel> GetAllNews()
        {

            var result = GetListCache(ALLITEMSKEY);

            if (result == null || result.Count == 0)
            {
                var repository = Ioc.IocContainer.Resolve<INewsRepository>();
                result = repository.GetAllNews();
                SetToListOfCache(ALLITEMSKEY, result);
            }

            return result.Select(x => NewsConverter.ConvertToViewModel(x)).ToList();

        }


        public List<NewsViewModel> GetRecentUpdatedNews()
        {
            var result = GetListCache(RECENTITEMSKEY);

            if (result == null || result.Count == 0)
            {
                var repository = Ioc.IocContainer.Resolve<INewsRepository>();
                result = repository.GetRecentUpdatedNews();
                SetToListOfCache(RECENTITEMSKEY, result);
            }

            return result.Select(x => NewsConverter.ConvertToViewModel(x)).ToList();
        }

        public void SetRecentNews()
        {
            var repository = Ioc.IocContainer.Resolve<INewsRepository>();
            var recentList = repository.GetRecentUpdatedNews();
            SetToListOfCache(RECENTITEMSKEY, recentList);
        }

        private NewsProject.Model.Domain.News GetFromCache(string key)
        {
            var cacheManager = Ioc.IocContainer.Resolve<ICacheManager>();
            return cacheManager.Get<NewsProject.Model.Domain.News>(key);
        }

        private void SetToListOfCache(string key, List<NewsProject.Model.Domain.News> items)
        {
            var cacheManager = Ioc.IocContainer.Resolve<ICacheManager>();
            cacheManager.Set<List<NewsProject.Model.Domain.News>>(key, items);
        }

        private List<NewsProject.Model.Domain.News> GetListCache(string key)
        {
            var cacheManager = Ioc.IocContainer.Resolve<ICacheManager>();
            return cacheManager.Get<List<NewsProject.Model.Domain.News>>(key);
        }

        #endregion
    }
}
