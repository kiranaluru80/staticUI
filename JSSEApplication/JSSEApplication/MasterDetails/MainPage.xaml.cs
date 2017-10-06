using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JSSEApplication
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                {
                    BackgroundColor = Color.Red
                };
				masterPage.ListView.SelectedItem = null;
                masterPage.BackgroundColor = Color.Red;
				IsPresented = false;
			}
		}
	}
}
