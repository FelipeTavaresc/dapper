namespace Blog.Screens.ReportScreens
{
    public static class MenuReportScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Relatórios");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuários e Perfis");
            Console.WriteLine("2 - Listar Posts e Tags");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ReportUserRoleScreen.Load();
                    break;
                case 2:
                    ReportPostTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}