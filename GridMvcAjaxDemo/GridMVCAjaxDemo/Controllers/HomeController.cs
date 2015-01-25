namespace GridMVCAjaxDemo.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using GridMVCAjaxDemo.Data;
    using GridMVCAjaxDemo.Helpers;

    public class HomeController : Controller
    {
        private const string GRID_PARTIAL_PATH = "~/Views/Home/_FootballersGrid.cshtml";

        private IGridMvcHelper gridMvcHelper;
        private IDemoData data;

        public HomeController()
        {
            this.gridMvcHelper = new GridMvcHelper();
            this.data = new FootballersData();
        }

        public ActionResult Index()
        {
            return View();
        }
        
        [ChildActionOnly]
        public ActionResult GetGrid()
        {
            var items = this.data.GetFootballers().OrderBy(f => f.FirstName);
            var grid = this.gridMvcHelper.GetAjaxGrid(items);

            return PartialView(GRID_PARTIAL_PATH, grid);
        }
        
        [HttpGet]
        public ActionResult GridPager(int? page)
        {
            var items = this.data.GetFootballers().OrderBy(f => f.FirstName);
            var grid = this.gridMvcHelper.GetAjaxGrid(items, page);
            object jsonData = this.gridMvcHelper.GetGridJsonData(grid, GRID_PARTIAL_PATH, this);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}