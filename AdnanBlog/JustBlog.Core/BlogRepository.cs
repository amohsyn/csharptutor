using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBlog.Core.Objects;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Transform;
using PagedList;
using PagedList.Mvc;


namespace JustBlog.Core
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ISession _session;
       

        public BlogRepository(ISession session)
        {
            _session = session;
        }

        int? page;
        public IPagedList<Post> Posts(int pageNo, int pageSize)
        {

            var posts = _session.Query<Post>()
                .Where(p => p.Published)
                .OrderByDescending(p => p.PostedOn)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .Fetch(p => p.Category)
                .ToList();

            var postIds = posts.Select(p => p.Id).ToList();

            return _session.Query<Post>()
                   .Where(p => postIds.Contains(p.Id))
                   .OrderByDescending(p => p.PostedOn)
                   .FetchMany(p => p.Tags)
                   .ToList().ToPagedList(page?? 1,10);

                 
        
        }

        public int TotalPosts()
        {
            return _session.Query<Post>().Where(p => p.Published).Count();
        }

    }
}
