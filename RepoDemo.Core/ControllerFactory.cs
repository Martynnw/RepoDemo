using System;
using Ninject;

namespace RepoDemo.Core
{
	public class ControllerFactory
	{
		private StandardKernel kernel;

		public ControllerFactory(IRepository repository)
		{
			kernel = new StandardKernel();
			kernel.Bind<IRepository>().ToConstant(repository);
		}

		public DemoController GetDemoController()
		{
			return kernel.Get<DemoController>();
		}
	}
}

