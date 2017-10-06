using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JSSEApplication
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }
		public MasterPage()
		{
			InitializeComponent();
			var masterPageItems = new List<MasterPageItem>();

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Create New JSSE",
				//IconSource = "contacts.png",
				TargetType = typeof(CreateNewJSSE)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "My JSSEs",
				//IconSource = "todo.png",
				TargetType = typeof(MyJSSEs)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Request Access",
				//IconSource = "reminders.png",
				TargetType = typeof(RequestAccess)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Reports",
				//IconSource = "reminders.png",
				TargetType = typeof(Reports)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
