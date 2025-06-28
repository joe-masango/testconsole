using Databases;

MongoDb.Connect();

PostgresSql.Connect();

SQLite.Connect();

MySQL.Connect();

SQLServer.Connect();

OracleDb.Connect();

Console.WriteLine("All database connections attempted. Check console for details.");

Databases.ORM.DapperORM.GetPeople();
Databases.ORM.EntityFrameworkORM.GetPeople();

Console.WriteLine("ORM operations completed.");