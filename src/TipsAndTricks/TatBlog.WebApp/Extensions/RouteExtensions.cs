﻿using Microsoft.EntityFrameworkCore;
using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;
using TatBlog.Services.Blogs;

namespace TatBlog.WebApp.Extensions
{
    public static class RouteExtensions
    {
        //Định nghĩa route template, route constraint cho các
        //endpoint kết hợp với cá action trong các controller

        public static IEndpointRouteBuilder UseBlogRoutes(
            this IEndpointRouteBuilder endpoinrs)
        {
            endpoinrs.MapControllerRoute(
                name: "post-by-category",
                pattern: "blog/category/{slug}",
                defaults: new { controller = "Blog", action = "Category" });

            endpoinrs.MapControllerRoute(
                name: "post-by-tag",
                pattern: "blog/tag/{slug}",
                defaults: new { controller = "Blog", action = "Tag" });

            endpoinrs.MapControllerRoute(
                name: "single-post",
                pattern: "blog/post/{year:int}/{month:int}/{day:int}/{slug}",
                defaults: new { controller = "Blog", action = "Post" });

            endpoinrs.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blog}/{action=Index}/{id?}");

            return endpoinrs;
        }
    }
}