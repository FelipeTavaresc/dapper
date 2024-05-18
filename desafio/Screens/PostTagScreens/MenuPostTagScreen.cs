using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreens
{
    public static class MenuPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Associar Post a tag");
            Console.WriteLine("-----------------------");

            Console.Write("Informe o Id da Tag: ");
            var tagId = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o Id do Post: ");
            var postId = int.Parse(Console.ReadLine()!);

            var postTag = new PostTag { PostId = postId, TagId = tagId };
            Create(postTag);
        }

        private static void Create(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                Console.WriteLine("Post associado a tag com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível associar post a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}