using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BudgetControl.App
{
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent ();
		}

		void OnCreateBudget(object sender, EventArgs e )
		{
			Navigation.PushAsync (new BudgetView ());
		}

		void OnShowBudgets(object sender, EventArgs e )
		{
			
		}
	}
}

