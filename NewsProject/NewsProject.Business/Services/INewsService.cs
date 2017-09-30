using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Services
{
    public interface INewsService
    {
        List<NewsProject.Model.ViewModel.NewsViewModel> GetAllNews();
        void SetRecentNews();
    }
}
