using EntryStepper.Renderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static EntryStepper.Renderers.CustomEntry;

namespace EntryStepper
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			step1.Focus();
			step2.IsEnabled = false;
			step3.IsEnabled = false;
			step4.IsEnabled = false;
		}

		private void step1_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 1)
			{
				if (string.IsNullOrEmpty(step2.Text))
				{
					step2.IsEnabled = true;
					step2.Focus();
				}

			}
		}


		private void step2_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 1)
			{
				if (string.IsNullOrEmpty(step3.Text))
				{
					step3.Focus();
					step3.IsEnabled = true;
				}

			}

			if (e.NewTextValue.Length == 0)
			{
				step2.OnBackspace += EntryBackspaceEventHandler2;
				
			}
		}

		

		private void step3_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.NewTextValue.Length == 1)
			{
				step4.Focus();
				step4.IsEnabled = true;
				

			}

			if (e.NewTextValue.Length == 0)
			{
				step3.OnBackspace += EntryBackspaceEventHandler3;

			}
		}

		private void step4_TextChanged(object sender, TextChangedEventArgs e)
		{

			if (e.NewTextValue.Length == 0)
			{
				step4.OnBackspace += EntryBackspaceEventHandler4;

			}
		}


		public void EntryBackspaceEventHandler2(object sender, EventArgs e)
		{
			step1.Focus();
			step1.Text = string.Empty;
		}

		public void EntryBackspaceEventHandler3(object sender, EventArgs e)
		{
			step2.Focus();
			step2.Text = string.Empty;
		}

		public void EntryBackspaceEventHandler4(object sender, EventArgs e)
		{
			step3.Focus();
			step3.Text = string.Empty;
		}
	}
}
