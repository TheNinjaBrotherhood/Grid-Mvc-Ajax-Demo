namespace GridMVCAjaxDemo.Data
{
    using System.Linq;

    using GridMVCAjaxDemo.Models;

    public interface IDemoData
    {
        IQueryable<Footballer> GetFootballers();
    }
}
