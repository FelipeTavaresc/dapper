
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void List()
        {

            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.Get();

            foreach (var item in posts)
            {
                Console.WriteLine(@$"{item.Id} - {item.Title} - {item.Body} - {item.Summary} - {item.Slug} -
                                     {item.CreateDate} - {item.LastUpdateDate}");
            }

        }
    }
}