using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SklepSever;

namespace Sklep.Database
{
    struct DatabaseConnectionSettings
    {
        public string Host;
        public string User;
        public string DBname;
        public string Password;
        public string Port;

        public string GetConnectionString()
        {
            return String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
        }

        public static DatabaseConnectionSettings FromEnv()
        {
            var env = EnvLoader.LoadFromFile(".env");
            DatabaseConnectionSettings result;
            result.Host = env["DATABASE_URL"];
            result.User = env["DATABASE_USER"];
            result.DBname = env["DATABASE_NAME"];
            result.Port = env["DATABASE_PORT"];
            result.Password = env["DATABASE_PASSWORD"];
            return result;
        }
    }
}
