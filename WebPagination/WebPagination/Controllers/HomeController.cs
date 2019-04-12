using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPagination.Models;
using PagedList;
using System.Threading.Tasks;

namespace WebPagination.Controllers
{
    public class HomeController : Controller
    {
        productdbEntities pdEntity = new productdbEntities();
        
        // GET: Home
        public async Task<ActionResult> Index(int page =1,int pageSize=3)
        {
            List<PRODUCT> _Product = pdEntity.PRODUCTs.ToList();
            PagedList<PRODUCT> model = new PagedList<PRODUCT>(_Product,page,pageSize);
            return View(model);
        }
    }
}