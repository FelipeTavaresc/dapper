using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando usuário");
            Console.WriteLine("-------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine()!;

            Console.Write("Nome: ");
            var name = Console.ReadLine()!;

            Console.Write("Email: ");
            var email = Console.ReadLine()!;

            Console.Write("Senha: ");
            var password = Console.ReadLine()!;

            Console.Write("Biografia: ");
            var bio = Console.ReadLine()!;

            Console.Write("Imagem: ");
            var imagem = Console.ReadLine()!;

            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            var user = new User
            {
                Id = int.Parse(id),
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = imagem,
                Slug = slug
            };

            Update(user);
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atulizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}