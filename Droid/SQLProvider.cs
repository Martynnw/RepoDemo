using System;
using RepoDemo.Core;
using SQLite;
using System.IO;
using Xamarin.Forms;
using RepoDemo.Droid;

[assembly: Dependency(typeof(SQLite_Android))]

namespace RepoDemo.Droid
{
	public class SQLite_Android : ISQLProvider
	{
		public SQLite_Android() { }
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFilename = "DemoSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);

			File.Delete(path);

			// Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;
		}
	}
}

