namespace TraversalPro.Areas.Admin.Models
{
    public class ApiMovieViewModel
    {
        public List<string> director { get; set; }
        public List<string> genre { get; set; }
        public List<List<string>> image { get; set; }
        public int rank { get; set; }
        public string rating { get; set; }
        public string thumbnail { get; set; }
        public string title { get; set; }
        public int year { get; set; }


    }

}
