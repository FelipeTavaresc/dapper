
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public static class ReportPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Posts e tags");
            Console.WriteLine("-------------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        private static void List()
        {
            var repository = new PostTagRepository(Database.Connection);
            var postTags = repository.ListPostTag();
            foreach (var item in postTags)
            {
                Console.WriteLine($"{item.Title} - {item.Summary}");
                foreach (var tag in item.Tags)
                    Console.WriteLine($"- {tag.Name}");
            }
        }
    }
}