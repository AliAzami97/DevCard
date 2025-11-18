namespace DevCard_Project.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

        public Article(int id, string title, List<string> description, string image, string link)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Link = link;
        }
    }
}
