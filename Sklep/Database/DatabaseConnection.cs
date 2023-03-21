using System;
using System.Net.Sockets;
using Npgsql;

namespace Sklep.Database
{
    class DatabaseConnection
    {
        public NpgsqlConnection Connection { get; private set; } = null;
        // First created connection is saved as Main, to allow easier access
        public static DatabaseConnection Main { get; private set; } = null;

        public DatabaseConnection()
        {
            if (Main == null) Main = this;
        }

        public bool Connect(DatabaseConnectionSettings settings)
        {
            if(Connection != null)
            {
                Console.WriteLine("Połączenie z bazą danych zostało zamknięte za sprawą nowego połączenia");
                Connection.Close();
            }

            Connection = new NpgsqlConnection(settings.GetConnectionString());
            try
            {
                Connection.Open();
            } 
            catch(SocketException ex)
            {
                Console.WriteLine("Błąd połączenia z bazą (brak internetu?)\n"+ex.Message);
                Connection = null;
                return false;
            }

            return true;
        }

        ~DatabaseConnection()
        {
            if(Connection != null)
            {
                Connection.Close();
            }
        }
    }
}
