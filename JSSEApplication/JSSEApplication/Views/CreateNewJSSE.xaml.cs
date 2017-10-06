using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JSSEApplication
{
	public partial class CreateNewJSSE : ContentPage
	{
		public CreateNewJSSE()
		{
			InitializeComponent();



            //StackLayout stackLayout = new StackLayout();
            //stackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            //stackLayout.VerticalOptions = LayoutOptions.Start;
            //stackLayout.Spacing = 5;
            //stackLayout.Orientation = StackOrientation.Vertical;

            //frameMainStack.Children.Add(stackLayout);

                

			var communicationTapGesture = new TapGestureRecognizer();
			communicationTapGesture.Tapped += (s, e) =>
			{
				if (ComminicationsRefVisible.IsVisible)
				{
					ComminicationsRefVisible.IsVisible = false;
				}
				else
				{
					ComminicationsRefVisible.IsVisible = true;
				}
			};
			ComminicationsRef.GestureRecognizers.Add(communicationTapGesture);
			communicationTapGesture.NumberOfTapsRequired = 1;


			var energyTapGesture = new TapGestureRecognizer();
			energyTapGesture.Tapped += (s, e) =>
						{
							if (EnergySourceControlRefVisible.IsVisible)
							{
								EnergySourceControlRefVisible.IsVisible = false;
							}
							else
							{
								EnergySourceControlRefVisible.IsVisible = true;
							}
						};
			EnergySourceControlRef.GestureRecognizers.Add(energyTapGesture);
			energyTapGesture.NumberOfTapsRequired = 1;


		}
	}
}
