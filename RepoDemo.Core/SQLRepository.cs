using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace RepoDemo.Core
{
	public class SQLRepository : IRepository
	{
		SQLiteConnection connection;

		public SQLRepository(ISQLProvider provider)
		{
			this.connection = provider.GetConnection();
		}

		public void Init()
		{
			this.connection.CreateTable<Month>();
			this.connection.Insert(new Month(12, "December"));
			this.connection.Insert(new Month(11, "November"));
			this.connection.Insert(new Month(10, "October"));
			this.connection.Insert(new Month(9, "September"));
			this.connection.Insert(new Month(8, "August"));
			this.connection.Insert(new Month(7, "July"));
			this.connection.Insert(new Month(6, "June"));
			this.connection.Insert(new Month(5, "May"));
			this.connection.Insert(new Month(4, "April"));
			this.connection.Insert(new Month(3, "March"));
			this.connection.Insert(new Month(2, "February"));
			this.connection.Insert(new Month(1, "January"));
		}

		public List<Month> GetMonths()
		{
			return this.connection.Table<Month>().ToList();
		}
	}
}

