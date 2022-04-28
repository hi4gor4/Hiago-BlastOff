
namespace Balta.ContentContext
{
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
            Title = "";             
        }
        public int Order { get; set; }
        public string Title { get; set; }

        public IList<Lecture> Lectures {get; set;}

    }
}