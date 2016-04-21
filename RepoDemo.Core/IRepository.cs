using System;
using System.Collections.Generic;

namespace RepoDemo.Core
{
	public interface IRepository
	{
		void Init();
		List<Month> GetMonths();
	}
}

