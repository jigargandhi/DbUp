using System;
using System.IO;
using MySql.Data;

namespace SampleAppMySql.Repository
{
    public class RepositoryClass
    {

        public void Update(string contents)
        {

            File.WriteAllText(@"D:\help1.txt", contents);

            // Do something here that allows t

        }

    }
}
