using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tuan4_NguyenMinhTien
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ListSach",
                url: "sach/danh-sach",
                defaults: new { controller = "Sach", action = "ListSach", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Edit",
                url: "chinh-sua-sach-{id}",
                defaults: new { controller = "Sach", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Detail",
                url: "chi-tiet-sach-{id}",
                defaults: new { controller = "Sach", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
