(function () {
    var gridName = 'FootballersGrid';
    var pagingUrl = 'Home/GridPager';

    $('.grid-mvc').gridmvc();
    pageGrids[gridName].ajaxify({
        getData: pagingUrl,
        getPagedData: pagingUrl
    });
}())