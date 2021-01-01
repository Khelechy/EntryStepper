using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EntryStepper.Renderers
{
	public class CustomEntry : Entry
	{
		public delegate void BackspaceEventHandler(object sender, EventArgs e);

		public event BackspaceEventHandler OnBackspace;

		public CustomEntry() { }

        public void OnBackspacePressed()
        {
			if (OnBackspace != null)
			{
				OnBackspace(null, null);
			}
			
        }
    }
}
