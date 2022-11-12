namespace Porfolio.Models
{
    public class ProjectM
    {

        public ProjectM()
        {
            TimeLineList = new List<TimeLineM>();
        }

        public string Id { get; set; }
        public string TitleBG { get; set; }
        public string? Name { get; set; }
        public string? SubName { get; set; }
        public string? FirstParagraph { get; set; }
        public string? SecondParagraph { get; set; }
        public string? DemoURL { get; set; }
        public string? SourceURL { get; set; }
        public string? API_URL { get; set; }
        public List<TimeLineM> TimeLineList { get; set; }





        public string? Frame1_Number { get; set; }
        public string? Frame1_Name { get; set; }
        public string? Frame1_NameSub { get; set; }

        public string? Frame2_Number { get; set; }
        public string? Frame2_Name { get; set; }
        public string? Frame2_NameSub { get; set; }

        public string? Frame3_Number { get; set; }
        public string? Frame3_Name { get; set; }
        public string? Frame3_NameSub { get; set; }

        public string? Frame4_Number { get; set; }
        public string? Frame4_Name { get; set; }
        public string? Frame4_NameSub { get; set; }

        public List<ImageM> Images { get; set; } = new List<ImageM>();

    }
    public class ImageM
    {

        public string URL { get; set; } = "";
        public string Id { get; set; } = "";
    }
}
