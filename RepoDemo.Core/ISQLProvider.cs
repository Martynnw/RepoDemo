using System;
using SQLite;

namespace RepoDemo.Core
{
	public interface ISQLProvider
	{
		SQLiteConnection GetConnection();
	}
}

