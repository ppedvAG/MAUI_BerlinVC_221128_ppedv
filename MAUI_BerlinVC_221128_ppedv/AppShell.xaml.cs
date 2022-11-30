namespace MAUI_BerlinVC_221128_ppedv;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("navi/routeTarget", typeof(Navi.RouteTargetPage));
	}
}