using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Repository
{
    public interface INewsRepository
    {
        List<NewsProject.Model.Domain.News> GetAllNews();
        List<NewsProject.Model.Domain.News> GetRecentUpdatedNews();
    }
}
