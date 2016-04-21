using System;
using Xamarin.Forms;
using RepoDemo.Core;

namespace RepoDemo
{
	public class HomePage : ContentPage
	{
		public HomePage()
		{
			// Set up the repository.
			var sqlProvider = DependencyService.Get<ISQLProvider>();
			var repo = new SQLRepository(sqlProvider);
			repo.Init();

			// Set up the controller factory and controller.
			var controllerFactory = new ControllerFactory(repo);
			var controller = controllerFactory.GetDemoController();

			// Set up the list.
			var listView = new ListView
			{
				RowHeight = 40
			};

			listView.ItemsSource = controller.GetFirstQuarter();

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}
	}
}

