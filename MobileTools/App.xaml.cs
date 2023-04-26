using MobileTools.Views;

namespace MobileTools;

public partial class App : Application
{
	public App(MainPage main)
	{
		InitializeComponent();
		MainPage = new NavigationPage(main);
    }
}

