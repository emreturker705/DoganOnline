using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsProject.Business.Services;

namespace NewsProject.Business
{
    public sealed class BaseService
    {
        public static INewsService NewsService 
        {
            get
            {
                return Ioc.IocContainer.Resolve<INewsService>();
            }
        }
    }
}
