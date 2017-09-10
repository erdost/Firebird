using System.Net.Http;
using System.Threading.Tasks;

namespace Firebird
{
    public class Post
    {
        public int ID { get; set; }
        public string Description { get; set; }
    }

    public interface IPostService
    {
        Task<Post> GetAsync();
    }

    public class PostService : IPostService
    {
        public async Task<Post> GetAsync()
        {
            using (var client = new HttpClient())
            {
                var message = new Post {
                    ID = 1,
                    Description = "My beloved post"
                };
                
                return message;
            }
        }
    }
}