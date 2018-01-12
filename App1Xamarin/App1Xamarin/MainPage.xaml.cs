using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace App1Xamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{

			InitializeComponent();

			ToASCII.Clicked += ToASCII_Clicked;
			ToBinar.Clicked += ToBinar_Clicked;
			ToText.Clicked += ToText_Clicked;
			 
		}

		private void ToText_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToBinar_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToASCII_Clicked(object sender, EventArgs e)
		{
			string input = InputValue.Text;
			string output = null;

			input.ForEach(x => output += x);

			//foreach (char c in input)
			//{
			//    Console.WriteLine(System.Convert.ToInt32(c));
			//}
			//Console.ReadLine();
		}
	}
}
