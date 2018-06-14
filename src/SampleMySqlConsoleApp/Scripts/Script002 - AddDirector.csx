#r "C:\Users\gdi\.nuget\packages\system.data.common\4.3.0\ref\netstandard1.2\System.Data.Common.dll"

using System.Data;

IDbConnection connection = Connection;
IDbCommand command = connection.CreateCommand();
connection.Open();
string sqlQuery = "INSERT INTO moviedb.Director(DirectorName)values('Stefanie')";
command.CommandText = sqlQuery;
command.CommandType = CommandType.Text;
command.ExecuteScalar();