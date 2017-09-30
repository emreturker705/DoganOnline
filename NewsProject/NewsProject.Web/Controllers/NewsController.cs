using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsProject.Business;

namespace NewsProject.Web.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

        public ActionResult Index()
        {
           var news =  BaseService.NewsService.GetAllNews();
            return View(news);
        }

    }
}
