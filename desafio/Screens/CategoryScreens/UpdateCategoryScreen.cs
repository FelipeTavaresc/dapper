using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.GategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando categoria");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine()!;

            Console.Write("Nome: ");
            var name = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            var category = new Category { Id = int.Parse(id), Name = name, Slug = slug };

            Update(category);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}