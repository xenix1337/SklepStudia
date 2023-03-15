using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Sklep.Models
{
    struct NewProductModel
    {
        public string barcode;
        public string shortName;
        public string longName;
        public double price;
        public int? supplierID;
        public int? categoryID;

        public NpgsqlCommand GetInsertCommand(NpgsqlConnection connection) {
            NpgsqlCommand result = new NpgsqlCommand(
                "INSERT INTO produkty(kod_kreskowy, nazwa_krotka, nazwa_pelna, cena, id_dostawcy, id_kategorii) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5, @p6) ON CONFLICT(kod_kreskowy) " +
                "DO UPDATE SET nazwa_krotka=@p2, nazwa_pelna=@p3, cena=@p4, id_dostawcy=@p5, id_kategorii=@p6;"
                , connection) {
                Parameters =
                {
                    new NpgsqlParameter("p1", barcode),
                    new NpgsqlParameter("p2", shortName),
                    new NpgsqlParameter("p3", longName),
                    new NpgsqlParameter("p4", price),
                    new NpgsqlParameter("p5", (object)supplierID??DBNull.Value),
                    new NpgsqlParameter("p6", (object)categoryID??DBNull.Value),
                }
            };
            
            return result;
        }

    }
}
