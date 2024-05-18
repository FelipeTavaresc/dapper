
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.PostTagScreens;

namespace Blog.Screens.UserRoleScreens
{
    public static class MenuUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Associar Usuário Perfil");
            Console.WriteLine("-----------------------");

            Console.Write("Informe o Id do Usuário: ");
            var userId = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o Id do Perfil: ");
            var roleId = int.Parse(Console.ReadLine()!);

            var userRole = new UserRole { UserId = userId, RoleId = roleId };
            Create(userRole);
        }

        private static void Create(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(userRole);
                Console.WriteLine("Perfil associado ao usuário com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível associar perfil ao usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}