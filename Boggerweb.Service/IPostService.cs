using Bloggerweb.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boggerweb.Service
{
    public interface IPostService
    {
        IEnumerable<Post> GetPosts();
    }
}
