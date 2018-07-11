using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AsyncPartialView.Controllers
{
    public class AsyncPartialViewDemoController : Controller
    {
        // GET: AsyncPartialViewDemo
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Area_A()
        {
            Thread.Sleep(1000);
            return PartialView("_Area_A", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff"));
        }

        public async Task<ActionResult> Area_B()
        {
            Thread.Sleep(2000);
            return PartialView("_Area_B", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff"));
        }

        public async Task<ActionResult> Area_C()
        {
            Thread.Sleep(3000);
            return PartialView("_Area_C", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff"));
        }
    }
}