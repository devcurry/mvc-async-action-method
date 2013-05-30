using AsyncActionMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace AsyncActionMethods.Controllers
{
    public class BlogsController : ApiController
    {
        [HttpGet]
        public IList<Blog> GetPosts()
        {
            List<Blog> blogs = new List<Blog>();
            for (int i = 0; i < 10; i++)
            {
                blogs.Add(new Blog
                {
                    Id = i,
                    Title = "Title " + i.ToString(),
                    Post = "Post " + i.ToString(),
                    Author = "Author" + i.ToString()
                });
            }
            Thread.Sleep(1000);
            return blogs;
        }
    }
}
