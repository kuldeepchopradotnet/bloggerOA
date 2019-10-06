using System;
using System.Collections.Generic;
using Bloggerweb.Data.DTO;
using Bloggerweb.Repo;

namespace Boggerweb.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        public PostService(IRepository<Post> postRepository) {
            _postRepository = postRepository;
        }
        public IEnumerable<Post> GetPosts()
        {
            return _postRepository.GetAll();
        }
    }
}
