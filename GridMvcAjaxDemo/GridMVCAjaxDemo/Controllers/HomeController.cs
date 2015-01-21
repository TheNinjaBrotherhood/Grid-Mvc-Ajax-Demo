namespace GridMVCAjaxDemo.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using GridMVCAjaxDemo.Helpers;
    using GridMVCAjaxDemo.Models;

    public class HomeController : Controller
    {
        private const string GRID_PARTIAL_PATH = "~/Views/Home/_FootballersGrid.cshtml";
        private IGridMvcHelper gridMvcHelper;

        public HomeController()
        {
            this.gridMvcHelper = new GridMvcHelper();
        }

        public ActionResult Index()
        {
            return View();
        }
        
        [ChildActionOnly]
        public ActionResult GetGrid()
        {
            var items = this.GetFootballers().OrderBy(f => f.FirstName);
            var grid = this.gridMvcHelper.GetAjaxGrid(items);

            return PartialView(GRID_PARTIAL_PATH, grid);
        }
        
        [HttpGet]
        public ActionResult GridPager(int? page)
        {
            var items = GetFootballers().OrderBy(f => f.FirstName);
            var grid = this.gridMvcHelper.GetAjaxGrid(items, page);
            object jsonData = this.gridMvcHelper.GetGridJsonData(grid, GRID_PARTIAL_PATH, this);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }        
        
        private IQueryable<Footballer> GetFootballers()
        {
            var footballers = new List<Footballer>();            
            footballers.Add(new Footballer("Jon", "Doe2", 20));
            footballers.Add(new Footballer("Jon1", "Doe1", 18));
            footballers.Add(new Footballer("Jon7", "Doe2", 19));
            footballers.Add(new Footballer("Jon6", "Doe5", 31));
            footballers.Add(new Footballer("Jon", "Doe3", 33));
            footballers.Add(new Footballer("Jon", "Doe2", 20));
            footballers.Add(new Footballer("Jon2", "Doe", 28));
            footballers.Add(new Footballer("Jon", "Doe1", 26));
            footballers.Add(new Footballer("Jon8", "Doe4", 25));
            footballers.Add(new Footballer("Jon9", "Doe6", 25));
            footballers.Add(new Footballer("Jon3", "Doe4", 25));
            footballers.Add(new Footballer("Jon10", "Do4e", 21));
            footballers.Add(new Footballer("Jon4", "Doe2", 18));
            footballers.Add(new Footballer("Jon22", "Doe3", 44));
            footballers.Add(new Footballer("Jon5", "Doe15", 33));
            footballers.Add(new Footballer("Jon13", "Doe2", 21));

            return footballers.AsQueryable();
        }
    }
}