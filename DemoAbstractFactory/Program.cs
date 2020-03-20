using Model.Alliance;
using Model.Common;
using Model.NOD;
using Model.Russe;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new AllianceFactory();
            Console.WriteLine(factory.CreateCaserne());
            Usine usine = factory.CreateUsine();
            Console.WriteLine(usine);

            Console.WriteLine(usine.CreateJeep());
            Console.WriteLine(usine.CreateMoto());

            DbProviderFactory dbFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DbConnection dbConnection = dbFactory.CreateConnection();
            dbConnection.ConnectionString = @"Data Source=AW-BRIAREOS\SQL2016DEV;Initial Catalog=DemoModel;Integrated Security=True";

            DbCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = "Select * from Contact";

            dbConnection.Open();

            DbDataReader reader = dbCommand.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine($"{reader["Nom"]} {reader["Prenom"]}");
            }

            dbConnection.Dispose();
            

            Console.ReadLine();
        }
    }
}
