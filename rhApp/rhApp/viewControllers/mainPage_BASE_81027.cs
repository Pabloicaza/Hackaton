using System;

using Xamarin.Forms;

namespace rhApp
{
	public class mainPage : ContentPage
	{
		public mainPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


