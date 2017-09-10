using Nancy;
 
namespace Firebird
{
    public class PostModule : NancyModule
    {
        public PostModule(PostService postService)
        {
            Get("/", args => "Super Duper Happy Path running on .NET Core");
 
            Get("/posts", async args => await postService.GetAsync());
        }
    }
}