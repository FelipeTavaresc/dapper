using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load(){
            Console.Clear();
            Console.WriteLine("Novo perfil");
            Console.WriteLine("-------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            var role = new Role { Name = name, Slug = slug };

            Create(role);
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Perfil cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}