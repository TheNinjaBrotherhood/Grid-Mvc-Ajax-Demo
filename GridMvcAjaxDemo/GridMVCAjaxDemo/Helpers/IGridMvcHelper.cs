namespace GridMVCAjaxDemo.Helpers
{
    using System.Linq;
    using System.Web.Mvc;

    using Grid.Mvc.Ajax.GridExtensions;

    public interface IGridMvcHelper
    {
        AjaxGrid<T> GetAjaxGrid<T>(IOrderedQueryable<T> items) where T : class;
        AjaxGrid<T> GetAjaxGrid<T>(IOrderedQueryable<T> items, int? page) where T : class;
        object GetGridJsonData<T>(AjaxGrid<T> grid, string gridPartialViewPath, Controller controller) where T : class;
    }
}
