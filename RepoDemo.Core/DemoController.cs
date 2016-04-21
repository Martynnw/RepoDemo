using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoDemo.Core
{
	public class DemoController
	{
		private IRepository repo;

		public DemoController(IRepository repo)
		{
			this.repo = repo;
		}

		public List<Month> GetFirstQuarter()
		{
			return this.repo.GetMonths().Where(x => x.Number <= 3).ToList();
		}
	}
}

