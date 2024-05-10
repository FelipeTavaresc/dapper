
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.GategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir categoria");
            Console.WriteLine("-------------");

            Console.Write("Qual id da Categoria que deseja excluir? ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ñão foi possível excluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}