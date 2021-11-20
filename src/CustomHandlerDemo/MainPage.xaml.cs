using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace CustomHandlerDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			heartBeatView.IsBeating = !heartBeatView.IsBeating;
		}
	}
}
