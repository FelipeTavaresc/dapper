
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir perfil");
            Console.WriteLine("--------------");

            Console.Write("Qual id do Perfil que deseja excluir? ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o perfil");
                Console.WriteLine(ex.Message);                
            }
        }
    }
}