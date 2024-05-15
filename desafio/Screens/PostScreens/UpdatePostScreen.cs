using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando post");
            Console.WriteLine("----------------");

            Console.Write("Id: ");
            var id = Console.ReadLine()!;

             Console.Write("Título: ");
            var title = Console.ReadLine()!;

            Console.Write("Resumo: ");
            var summary = Console.ReadLine()!;

            Console.Write("Conteúdo: ");
            var body = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            Console.Write("Autor Id: ");
            var authorId = int.Parse(Console.ReadLine()!);

            Console.Write("Categoria Id: ");
            var categoryId = int.Parse(Console.ReadLine()!);

            var post = new Post{
                Id = int.Parse(id),
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                AuthorId = authorId,
                CategoryId = categoryId
            };

            Update(post);
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}