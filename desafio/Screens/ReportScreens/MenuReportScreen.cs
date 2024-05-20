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
            Console.WriteLine("1 - Listar Usuários por Perfis");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ReportUserRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}