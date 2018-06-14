using System;
using System.Reflection;
using DbUp;
using DbUp.MySql;
using Microsoft.CodeAnalysis.Scripting;
using MySql.Data.MySqlClient;
using SampleAppMySql.Repository;

namespace SampleAppMySql
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string connectionString = "database=moviedb;server=localhost;user=root;password=123BProject;SslMode=none";
                var options = ScriptOptions.Default.AddReferences(typeof(RepositoryClass).GetTypeInfo().Assembly);
                var upgradeEngine = DeployChanges.To.MySqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(typeof(Program).GetTypeInfo().Assembly)
                    .WithCSharpScriptsFromAssembly(new Assembly[] { typeof(RepositoryClass).GetTypeInfo().Assembly })
                    .WithCSharpScriptsOptions(options)
                    .WithDefaultScriptExecutor(new MySqlConnection(connectionString))
                    .Build();

                var result = upgradeEngine.PerformUpgrade();

            }
            catch (Exception)
            {



            }

            Console.ReadKey();
            // Database will be deleted at this point
        }
    }
}
