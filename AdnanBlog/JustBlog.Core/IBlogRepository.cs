using JustBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;

namespace JustBlog.Core
{
    public interface IBlogRepository
    {
        IPagedList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
