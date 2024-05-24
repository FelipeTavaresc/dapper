
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public static class ReportUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Usuários e perfis");
            Console.WriteLine("-------------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        private static void List()
        {
            var repository = new UserRoleRepository(Database.Connection);
            var userRoles = repository.ListUserRoles();
            foreach (var item in userRoles)
            {
                Console.WriteLine($"{item.Name}");
                foreach (var role in item.Roles)
                    Console.WriteLine($"- {role.Name}");
            }
        }
    }
}