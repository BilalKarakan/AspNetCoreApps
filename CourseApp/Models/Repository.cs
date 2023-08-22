namespace CourseApp.Models
{
    public class Repository
    {
        public static readonly List<Course> _course = new();

        static Repository() 
        {
            _course = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Title = "Asp.Net Core MVC",
                    Description = "From Zero to Hero Asp.Net Core",
                    Image = "1.jpg",
                    Tags = new string[] {"Asp.Net Core", "Web Development", "Microsoft"},
                    isActive = true,
                    inHome = true
                },
                new Course()
                {
                    Id = 2,
                    Title = "Node.js",
                    Description = "From Zero to Hero Node.js",
                    Image = "2.jpg",
                    Tags = new string[] {"Node.js", "Web Development", "JavaScript"},
                    isActive = true,
                    inHome = true
                },
                new Course()
                {
                    Id = 3,
                    Title = "Java",
                    Description = "From Zero to Hero Java",
                    Image = "3.jpg",
                    Tags = new string[] {"Java", "Software Development"},
                    isActive = false,
                    inHome = true
                },
                new Course()
                {
                    Id = 4,
                    Title = "Rust",
                    Description = "From Zero to Hero Rust",
                    Image = "4.jpg",
                    Tags = new string[] {"Asp.Net Core", "Software Development"},
                    isActive = true,
                    inHome = false
                }
            };
        }

        public static List<Course> Courses
        {
            get { return _course; }
        }

        public static Course? GetById(int? id)
        {
            return _course.FirstOrDefault(x => x.Id == id);
        }
    }
}
