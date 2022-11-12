using Porfolio.Models;
using Firebase.Database.Query;
using Firebase.Database;

namespace Porfolio.Services.Project
{
    public class ProductServices : IProductServices
    {
        List<ProjectM> _projects;
        FirebaseClient _client;
        
        public ProductServices()
        {
            _client = new FirebaseClient("https://mzansigopro-f8d36-default-rtdb.firebaseio.com");
        }
        void Init()
        {
            _projects = new List<ProjectM>()
            {
                new ProjectM()
                {
                    Id = "frass",
                      Name = "Mzansi Go",
                     SubName = "Mall",
                     TitleBG = "Mobile",
                      FirstParagraph = "A platform that combanes retail stores services and present the best expirience of shop both offline and online",
                       SecondParagraph = "The application consist of a private API services feeding firebase database for retail stores data services",
                        Frame1_Name = "C#",
                         Frame1_Number = "90%",
                         Frame1_NameSub = "Dotnet",
                           Frame2_Number = "10%",
                            Frame2_Name = "XAML",
                            Frame2_NameSub = "Xamarin",
                             Frame3_Number = "5+",
                             Frame3_Name = "Services",
                             Frame3_NameSub = "In-App",
                              Frame4_Number = "200+",
                               Frame4_Name = "Consumers",
                               Frame4_NameSub = "Users",
                                TimeLineList = new List<TimeLineM>()
                                {
                                     new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     },
                                      new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     }
                                }
                          
                },
                 new ProjectM()
                {
                     Id = "asd",
                     Name = "Mzansi Go",
                     SubName = "Mall",
                     TitleBG = "Web",
                      FirstParagraph = "A platform that combanes retail stores services and present the best expirience of shop both offline and online",
                       SecondParagraph = "The application consist of a private API services feeding firebase database for retail stores data services",
                      Frame1_Name = "C#",
                         Frame1_Number = "90%",
                         Frame1_NameSub = "Dotnet",
                           Frame2_Number = "10%",
                            Frame2_Name = "XAML",
                            Frame2_NameSub = "Xamarin",
                             Frame3_Number = "5+",
                             Frame3_Name = "Services",
                             Frame3_NameSub = "In-App",
                              Frame4_Number = "200+",
                               Frame4_Name = "Consumers",
                               Frame4_NameSub = "Users",
                                TimeLineList = new List<TimeLineM>()
                                {
                                     new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     },
                                      new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     }
                                }

                },
                  new ProjectM()
                {
                      Id = "23",
                     Name = "Sbahle",
                     SubName = "nkosini",
                     TitleBG = "Website",
                      FirstParagraph = "A startup company that accomodates events hosting with catering, tents and all required decorations for hire.",
                       SecondParagraph = "Served as in-house production tool developer and developed an online order service application.",
                       Frame1_Name = "C#",
                         Frame1_Number = "60%",
                         Frame1_NameSub = "Dotnet",
                           Frame2_Number = "30%",
                            Frame2_Name = "Javascript",
                            Frame2_NameSub = "Front-end",
                             Frame3_Number = "10%",
                             Frame3_Name = "Html/css",
                             Frame3_NameSub = "Markup",
                              Frame4_Number = "30+",
                               Frame4_Name = "Consumers",
                               Frame4_NameSub = "Users",
                                TimeLineList = new List<TimeLineM>()
                                {
                                     new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     },
                                      new TimeLineM()
                                     {
                                           DateTi = "Sep 2022 (3 weeks)",
                                            Name = "Creation",
                                             Description = "The selection of basic structure of the application. Mvvm achitecture and external structure was placed for best practices of dependecy injection",
                                              Title = "Xamarin",
                                               SubTitle = "C#"
                                     }
                                }

                }
            };
        }

        public async Task<ProjectM?> GetProject(string id)
        {
            var items = await GetProjects();
            return items.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<ProjectM>> GetProjects()
        {

            try
            {

                List<ProjectM> projects = new List<ProjectM>();
                var response = await _client.Child("projects").OnceAsync<ProjectM>();

                if (response != null)
                {

                    foreach (var i in response)
                    {
                        projects.Add(i.Object);
                    }

                }
                return projects;

            }
            catch
            {
                return new List<ProjectM>();
                     
            }

            
        }
    }
}
