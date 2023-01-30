namespace KevinRosero_ExamenFinal;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.HomeView), typeof(Views.HomeView));
        Routing.RegisterRoute(nameof(Views.PerroItemPage), typeof(Views.PerroItemPage));
        Routing.RegisterRoute(nameof(Views.PerroListPage), typeof(Views.PerroListPage));
    }
}
