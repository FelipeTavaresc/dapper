using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("-------------");

            Console.Write("Título: ");
            var title = Console.ReadLine()!;

            Console.Write("Resumo: ");
            var summary = Console.ReadLine()!;

            Console.Write("Conteúdo: ");
            var body = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            var createDate = DateTime.Now;

            Console.Write("Autor Id: ");
            var authorId = int.Parse(Console.ReadLine()!);

            Console.Write("Categoria Id: ");
            var categoryId = int.Parse(Console.ReadLine()!);

            var post = new Post{
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = createDate,
                LastUpdateDate = createDate,
                AuthorId = authorId,
                CategoryId = categoryId
            };

            Create(post);
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}