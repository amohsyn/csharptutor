using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JustBlog.Core;
using JustBlog.Core.Objects;
using PagedList;
using PagedList.Mvc;

namespace JustBlog.Models
{
    public class ListViewModel
    {
        public IPagedList<Post> Posts { get;  set; }
        public int TotalPosts { get;  set; }

       
    }
}