using Porfolio.Models;
using Firebase.Database;
using Firebase.Database.Query;


namespace Porfolio.Services.Blog
{
    public class BlogServices : IBlogServices
    {
        FirebaseClient _client;
        List<BlogM> _list = new List<BlogM>();
        public BlogServices()
        {
            _client = new FirebaseClient("https://mzansigopro-f8d36-default-rtdb.firebaseio.com");
                    
        }


        void Init()
        {
            _list = new List<BlogM> { 
                
                new BlogM()
                {
                     Id = "asdsa",
                      Header = "Header",
                       Description = "asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa ",
                        Image = "../drawables/event1.jpg",
                         Title = "Title Title Title"
                        
                },
                new BlogM()
                {
                     Id = "rrtrd",
                      Header = "Header",
                       Description = "asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa ",
                        Image = "../drawables/event1.jpg",
                        Title = "Title Title Title"
                },
                new BlogM()
                {
                     Id = "ffsxvb",
                      Header = "Header",
                       Description = "asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa ",
                        Image = "/drawables/event1.jpg",
                        Title = "Title Title Title"
                },
                new BlogM()
                {
                     Id = "jhvcssss",
                      Header = "Header",
                       Description = "asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa  asd as sads dasdas asdasda s asdasd adsd asdas dsasds dsasdasd asd s  sasd sasdsasdsasd sasd sa ",
                        Image = "drawables/event1.jpg",
                        Title = "Title Title Title"
                }

            };
        }

        public async Task<bool> CreateBlog(BlogM blog)
        {
            try
            {

               var create = await _client.Child("blogs").PostAsync(blog);

                if(create != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }


              
            }
            catch
            {
                return false;
            }

        }

        public async Task<List<BlogM>> GetAllAllBlogs()
        {
            try
            {

                Init();

                List<BlogM> blogs = new List<BlogM>();
          var list = await  _client.Child("blogs").OnceAsync<BlogM>();
               foreach(var i in list)
                {
                    blogs.Add(i.Object);
                }


                return blogs;
            }
            catch
            {
                return new List<BlogM>();
            }


           
        }

        public async Task<BlogM?> GetBlogById(string id)
        {
            try
            {
                var list = await GetAllAllBlogs();

                var selected = list.FirstOrDefault(x => x.Id == id);

                if(selected != null)
                {
                    return selected;
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }
        }
    }
}
