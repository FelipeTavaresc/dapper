using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("-------------");

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
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = imagem,
                Slug = slug
            };

            Create(user);
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}