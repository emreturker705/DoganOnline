using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NewsProject.Business.Services;
using NewsProject.Core.Cache;
using NewsProject.Repository;

namespace NewsProject.Web
{
    public class IocConfig
    {
        public static void Register()
        {
            NewsProject.Ioc.IocContainer.RegisterTo<INewsService, NewsService>();
            NewsProject.Ioc.IocContainer.RegisterTo<INewsRepository, NewsRepository>();
            NewsProject.Ioc.IocContainer.RegisterTo<DbContext, NewsProject.Data.EntityFramework.Entity.NewsDatabaseEntities>();
            NewsProject.Ioc.IocContainer.RegisterTo<ICacheManager, RedisCacheManager>();

        }
    }
}