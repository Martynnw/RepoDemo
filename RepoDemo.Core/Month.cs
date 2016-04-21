using System;
using SQLite;

namespace RepoDemo.Core
{
	public class Month
	{
		public Month()
		{
		}

		public Month(int number, string name)
		{
			this.Number = number;
			this.Name = name;
		}

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		public int Number { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return this.Name;
		}
	}
}

