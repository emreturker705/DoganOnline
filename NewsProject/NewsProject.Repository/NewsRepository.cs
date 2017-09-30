using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsProject.Converter;
using NewsProject.Core.Data;

namespace NewsProject.Repository
{
    public class NewsRepository : Repository<NewsProject.Data.EntityFramework.Entity.News>,INewsRepository  
    {
        #region INewsRepository Members

        public List<NewsProject.Model.Domain.News> GetAllNews()
        {
            return AsQueryable().ToList().Select(x => NewsConverter.ConvertToDomainModel(x)).ToList();
        }

        /// <summary>
        /// This Method returns recent top 10 updated News
        /// </summary>
        /// <returns></returns>
        public List<NewsProject.Model.Domain.News> GetRecentUpdatedNews()
        {
            return AsQueryable().OrderByDescending(x=> x.LastUpdatedTime).Take(10).ToList().Select(x => NewsConverter.ConvertToDomainModel(x)).ToList();
        }
        #endregion
    }
}
