using System;

namespace CustomHandlerDemo
{
    public partial class MainPage
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
