using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.GategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            var category = new Category { Name = name, Slug = slug };

            Create(category);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Categoria cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}