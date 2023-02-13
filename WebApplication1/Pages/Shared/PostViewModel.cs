using DevopsDemo.Models;
using System.Collections.Generic;
namespace DevopsDemo.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
