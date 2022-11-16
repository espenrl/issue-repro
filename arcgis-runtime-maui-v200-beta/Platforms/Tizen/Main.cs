using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace arcgis_runtime_maui_v200_beta;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
