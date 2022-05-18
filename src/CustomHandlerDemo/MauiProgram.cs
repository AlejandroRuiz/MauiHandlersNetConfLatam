using CustomHandlerDemo.Controls;
using CustomHandlerDemo.Handlers;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace CustomHandlerDemo
{
    public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers(handlers =>
				{
					handlers.AddHandler<HeartBeatView, HeartBeatViewHandler>();
					handlers.AddHandler<ExtendedEntry, ExtendedEntryViewHandler>();
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			return builder.Build();
		}
	}
}