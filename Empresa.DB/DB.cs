using System;

namespace Empresa.DB
{
    public static class DB
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ClientsDB;Integrated Security=True";
            }
        }
    }
}
